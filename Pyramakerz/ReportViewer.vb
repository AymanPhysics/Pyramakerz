Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports CrystalDecisions.Shared

Public Class ReportViewer

    WithEvents ReportDoc As New ReportDocument
    Public Rpt As String = ""
    Public Header As String = ""
    Public paraname() As String = {}
    Public paravalue() As String = {}
    Dim MyPageContentWidth As Integer = 0
    Dim PS As PaperSize

    'Sub New()
    '    InitializeComponent()
    'End Sub

    Sub New(MyText As String)
        InitializeComponent()
    End Sub

    Public Sub ReportViewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not ReportDoc Is Nothing Then
                ReportDoc.Close()
                ReportDoc.Dispose()
                Me.CrystalReportViewer1.ReportSource = Nothing
                GC.Collect()
            End If
            ReportDoc.Dispose()

        Catch
        End Try
    End Sub


    Public Sub ReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MinimizeBox = True
            Text = Rpt.Replace(".rpt", "")
            CrystalReportViewer1.ShowRefreshButton = False
            'CrystalReportViewer1.ShowLogo = False
            'CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

            'RptPath = bm.GetNewTempName("dll")
            'IO.File.WriteAllBytes(RptPath, Rpt)

            Dim ServerName As String = con.DataSource
            Dim DataBase As String = con.Database

            ReportDoc.Load(System.Windows.Forms.Application.StartupPath & "\RPTs\" & Rpt)

            Dim stb As New SqlClient.SqlConnectionStringBuilder
            stb.ConnectionString = con.ConnectionString
            ReportDoc.SetDatabaseLogon(stb.UserID, stb.Password, ServerName, DataBase)

            Dim Table_LogOn_Info As New TableLogOnInfo()

            Table_LogOn_Info.ConnectionInfo.UserID = stb.UserID
            Table_LogOn_Info.ConnectionInfo.Password = stb.Password

            Table_LogOn_Info.ConnectionInfo.ServerName = ServerName
            Table_LogOn_Info.ConnectionInfo.DatabaseName = DataBase

            Dim TableServer() As String
            For Each Table_In_Report As CrystalDecisions.CrystalReports.Engine.Table In ReportDoc.Database.Tables
                Table_In_Report.ApplyLogOnInfo(Table_LogOn_Info)
                TableServer = Table_In_Report.Location.Split(".")
                Try
                    Table_In_Report.Location = DataBase & "." & TableServer(1) & "." & TableServer(2)
                Catch ex As Exception
                    Table_In_Report.Location = DataBase & ".dbo." & TableServer(0)
                End Try
            Next

            For i As Integer = 0 To ReportDoc.Subreports.Count - 1
                Try
                    For Each Table_In_Report As CrystalDecisions.CrystalReports.Engine.Table In ReportDoc.Subreports(i).Database.Tables
                        Table_In_Report.ApplyLogOnInfo(Table_LogOn_Info)
                        TableServer = Table_In_Report.Location.Split(".")
                        Try
                            Table_In_Report.Location = DataBase & "." & TableServer(1) & "." & TableServer(2)
                        Catch
                            Table_In_Report.Location = DataBase & ".dbo." & TableServer(0)
                        End Try
                    Next
                Catch
                End Try
            Next

            SetParamValue("DataBase", DataBase)
            SetParamValue("UserName", UserName)
            SetParamValue("EnName", EnName)
            For i As Integer = 0 To paraname.Length - 1
                SetParamValue(paraname(i), paravalue(i))
            Next

            CrystalReportViewer1.ReportSource = ReportDoc
        Catch ex As Exception
        End Try

        Try

            If MyPageContentWidth = 0 Then
                ComboBox1.Items.Clear()
                Dim MPS As New System.Drawing.Printing.PageSettings
                Dim dt As New DataTable With {.TableName = "tbl"}
                dt.Columns.Add("Kind")
                dt.Columns.Add("RawKind")
                For Each p As Object In MPS.PrinterSettings.PaperSizes
                    dt.Rows.Add({p.Kind, p.RawKind})
                Next
                ComboBox1.DataSource = dt
                ComboBox1.DisplayMember = "Kind"
                ComboBox1.ValueMember = "RawKind"
                ComboBox1.SelectedValue = Val(ReportDoc.PrintOptions.PaperSize.GetTypeCode())

                PS = ReportDoc.PrintOptions.PaperSize
                MyPageContentWidth = ReportDoc.PrintOptions.PageContentWidth
            End If
        Catch
        End Try


        'Try
        '    CType(ReportDoc.ReportDefinition.ReportObjects.Item("Logo"), CrystalDecisions.CrystalReports.ViewerObjectModel.FlashObjectInstance).
        '    ReportDoc.ReportDefinition.ReportObjects.Item("Logo").ObjectFormat = (New BasicMethods).ExecuteAdapter("select * from statics")("Logo")
        'Catch ex As Exception
        'End Try
    End Sub

    Public Sub Print(Optional ByVal ServerName As String = "", Optional ByVal PrinterName As String = "", Optional ByVal NoOfCopies As Integer = 1)
        ReportViewer_Load(Nothing, Nothing)
        'Show()
        Try
            If PrinterName <> "" Then ReportDoc.PrintOptions.PrinterName = PrinterName '"\\" & ServerName & "\" & PrinterName 
            For i As Integer = 1 To NoOfCopies
                CrystalReportViewer1.ShowLastPage()
                ReportDoc.PrintToPrinter(1, False, 1, CrystalReportViewer1.GetCurrentPageNumber)
            Next
        Catch ex As Exception
            Dim bm As New BasicMethods
            bm.ShowMSG(ex.Message)
        End Try
        ReportViewer_FormClosing(Nothing, Nothing)
    End Sub
    Public Sub SetParamValue(ByVal paramName As String, ByVal paramValue As String)

        For i As Integer = 0 To ReportDoc.DataDefinition.ParameterFields.Count - 1
            If ReportDoc.DataDefinition.ParameterFields(i).ParameterFieldName = paramName Then
                Dim PFD As ParameterFieldDefinition = ReportDoc.DataDefinition.ParameterFields(i)
                Dim PValues As New ParameterValues()
                Dim Parm As New ParameterDiscreteValue()
                Parm.Value = paramValue
                PValues.Add(Parm)
                Try
                    PFD.ApplyCurrentValues(PValues)
                Catch ex As Exception
                End Try
                'Exit For
            End If
        Next

        For i As Integer = 0 To ReportDoc.Subreports.Count - 1
            Try
                For i2 As Integer = 0 To ReportDoc.Subreports(i).DataDefinition.ParameterFields.Count - 1
                    If (ReportDoc.Subreports(i).DataDefinition.ParameterFields(i2).ParameterFieldName.ToLower() = paramName.ToLower()) Then
                        Dim PFD As ParameterFieldDefinition = ReportDoc.Subreports(i).DataDefinition.ParameterFields(i2)
                        Dim PValues As ParameterValues = New ParameterValues()
                        Dim Parm As ParameterDiscreteValue = New ParameterDiscreteValue()
                        Parm.Value = paramValue.Trim()
                        PValues.Add(Parm)
                        PFD.ApplyCurrentValues(PValues)
                        'Exit For
                    End If
                Next
            Catch
            End Try
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub ReportViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If MyPageContentWidth = 0 Then Return
        Try
            Dim r As Decimal = MyPageContentWidth / ReportDoc.PrintOptions.PageContentWidth
            ReportDoc.PrintOptions.PaperSize = PS
            For Each c As ReportObject In ReportDoc.ReportDefinition.ReportObjects
                Try
                    If TypeOf (c) Is CrystalDecisions.CrystalReports.Engine.LineObject Then
                        CType(c, CrystalDecisions.CrystalReports.Engine.LineObject).Right *= r
                    ElseIf TypeOf (c) Is CrystalDecisions.CrystalReports.Engine.BoxObject Then
                        CType(c, CrystalDecisions.CrystalReports.Engine.BoxObject).Right *= r
                    Else
                        c.Width *= r
                    End If
                    c.Left *= r
                Catch
                End Try
            Next

            Dim MPS As New System.Drawing.Printing.PageSettings
            ReportDoc.PrintOptions.PaperSize = MPS.PrinterSettings.PaperSizes(ComboBox1.SelectedIndex).Kind

            
            r = ReportDoc.PrintOptions.PageContentWidth / MyPageContentWidth
            For Each c As ReportObject In ReportDoc.ReportDefinition.ReportObjects
                Try
                    If TypeOf (c) Is CrystalDecisions.CrystalReports.Engine.LineObject Then
                        CType(c, CrystalDecisions.CrystalReports.Engine.LineObject).Right *= r
                    ElseIf TypeOf (c) Is CrystalDecisions.CrystalReports.Engine.BoxObject Then
                        CType(c, CrystalDecisions.CrystalReports.Engine.BoxObject).Right *= r
                        CType(c, CrystalDecisions.CrystalReports.Engine.BoxObject).Right = CType(c, CrystalDecisions.CrystalReports.Engine.BoxObject).Left + c.Width

                        Dim x As CrystalDecisions.CrystalReports.Engine.BoxObject = c
                        'x.FillColor = System.Drawing.Color.Red
                        x.Left = c.Left
                        x.Right = c.Left + c.Width

                    Else
                        c.Width *= r
                    End If
                    c.Left *= r
                Catch
                End Try
            Next
        ReportViewer_Load(Nothing, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class