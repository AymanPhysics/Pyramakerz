Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form2

    Dim ReportDoc As New ReportDocument


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ReportDoc.Load("C:\Users\Physics\Desktop\Report2.rpt")

        'CrystalReportViewer1.ReportSource = ReportDoc


        'For i As Integer = 0 To ReportDoc.DataDefinition.ParameterFields.Count - 1
        '    If ReportDoc.DataDefinition.ParameterFields(i).ParameterFieldName = "s1" Then
        '        Dim PFD As ParameterFieldDefinition = ReportDoc.DataDefinition.ParameterFields(i)
        '        Dim PValues As New ParameterValues()
        '        Dim Parm As New ParameterDiscreteValue()
        '        Parm.Value = "a"
        '        PValues.Add(Parm)
        '        Try
        '            PFD.ApplyCurrentValues(PValues)
        '        Catch ex As Exception
        '        End Try
        '        'Exit For
        '    End If
        'Next
    End Sub
End Class