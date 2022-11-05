Public Class RPT1

    Dim bm As New BasicMethods
    Public Flag As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If Branch.SelectedIndex < 0 Then Branch.SelectedIndex = 0

        If (Flag = 11 Or Flag = 12) And Branch.SelectedIndex < 1 And Branch.Visible Then
            bm.ShowMSG("Please, Select A Branch ...")
            Return
        End If
        If Flag = 19 And Branch.SelectedIndex < 1 And Branch.Visible Then
            bm.ShowMSG("Please, Select A Company ...")
            Return
        End If

        Dim br As String = "-1"
        Try
            br = Branch.SelectedValue.ToString
        Catch ex As Exception
        End Try
        Dim rpt As New ReportViewer(Text)
        rpt.paraname = New String() {"@BranchId", "@FromDate", "@ToDate"}
        rpt.paravalue = New String() {br, FromDate.Text, ToDate.Text}
        If Flag = 1 Then
            rpt.Rpt = "LateInstallments.rpt"
        ElseIf Flag = 2 Then
            rpt.Rpt = "Complaints.rpt"
        ElseIf Flag = 3 Then
            rpt.Rpt = "Candidates.rpt"
        ElseIf Flag = 4 Then
            rpt.Rpt = "ManagementEvaluation.rpt"
        ElseIf Flag = 5 Then
            rpt.Rpt = "EquipmentEvaluation.rpt"
        ElseIf Flag = 6 Then
            rpt.Rpt = "MonthlyNewStudents.rpt"
            rpt.paraname = New String() {"@BranchId", "@FromYear", "@ToYear"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString, FromDate.Text, ToDate.Text}
            'ElseIf Flag = 7 Then
            '    rpt.Rpt = "KnownUs.rpt"
        ElseIf Flag = 8 Then
            rpt.Rpt = "Maintenance.rpt"
        ElseIf Flag = 9 Then
            rpt.Rpt = "EvaluationPremise.rpt"
        ElseIf Flag = 10 Then
            rpt.Rpt = "Appraisal.rpt"
        ElseIf Flag = 11 Then
            rpt.Rpt = "MissedInRealInvoices.rpt"
        ElseIf Flag = 12 Then
            rpt.Rpt = "MissedOutRealInvoices.rpt"
        ElseIf Flag = 13 Then
            rpt.Rpt = "SpecielOffer.rpt"
        ElseIf Flag = 14 Then
            rpt.Rpt = "Pyramakerz_NetIncome.rpt"
        ElseIf Flag = 15 Then
            rpt.Rpt = "Mistakes.rpt"
        ElseIf Flag = 16 Then
            rpt.Rpt = "StudentAttendance.rpt"
        ElseIf Flag = 17 Then
            rpt.Rpt = "InstractorsChange.rpt"
        ElseIf Flag = 18 Then
            rpt.Rpt = "StudentsContinuity.rpt"
        ElseIf Flag = 19 Then
            rpt.Rpt = "Companies.rpt"
            rpt.paraname = New String() {"@CompanyId", "CompanyName", "@FromDate", "@ToDate"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString, Branch.Text, FromDate.Text, ToDate.Text}
        ElseIf Flag = 20 Then
            rpt.Rpt = "Logging In.rpt"
        ElseIf Flag = 21 Then
            rpt.Rpt = "PlacementPeriods.rpt"
        ElseIf Flag = 22 Then
            rpt.Rpt = "StudentsImported.rpt"
        ElseIf Flag = 23 Then
            rpt.Rpt = "NoOfCourses.rpt"
        ElseIf Flag = 24 Then
            rpt.Rpt = "FaceBookMail.rpt"
        ElseIf Flag = 25 Then
            rpt.Rpt = "NonEvaluateStudents.rpt"
        ElseIf Flag = 26 Then
            rpt.Rpt = "Reporting.rpt"
        ElseIf Flag = 27 Then
            rpt.Rpt = "StudentsAll.rpt"
        ElseIf Flag = 28 Then
            rpt.Rpt = "StudentsCompanies.rpt"
            rpt.paraname = New String() {"@CompanyId", "CompanyName", "@FromDate", "@ToDate"}
            rpt.paravalue = New String() {Branch.SelectedValue.ToString, Branch.Text, FromDate.Text, ToDate.Text}
        ElseIf Flag = 29 Then
            rpt.Rpt = "Popup.rpt"
        End If
        rpt.ShowDialog()
    End Sub

    Private Sub RPT1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Flag = 19 OrElse Flag = 28 Then
            bm.FillCombo("select Id,Name from Companies union select 0 Id,'-' Name", Branch)
            Label3.Text = "Company"
        Else
            bm.FillCombo("select Id,Name from Branches union select 0 Id,'-' Name", Branch)
        End If

        FromDate.Value = Now
        ToDate.Value = Now
        If Flag = 6 Or Flag = 7 Or Flag = 14 Or Flag = 15 Or Flag = 18 Or Flag = 13 Or Flag = 21 Or Flag = 24 Or Flag = 26 Then
            Label3.Visible = False
            Branch.Visible = False
        End If

        If Flag = 6 Then
            FromDate.CustomFormat = "yyyy"
            ToDate.CustomFormat = "yyyy"
            FromDate.ShowUpDown = True
            ToDate.ShowUpDown = True
            FromDate.Value = New DateTime(Now.Year, Now.Month, 1)
            ToDate.Value = New DateTime(Now.Year, Now.Month, 1)
        ElseIf Flag = 14 Then
            FromDate.CustomFormat = "MMM-yyyy"
            ToDate.CustomFormat = "MMM-yyyy"
            FromDate.ShowUpDown = True
            ToDate.ShowUpDown = True
            FromDate.Value = New DateTime(Now.Year, Now.Month, 1)
            ToDate.Value = New DateTime(Now.Year, Now.Month, 1)
        End If

        If Flag = 2 Or Flag = 4 Or Flag = 5 Or Flag = 8 Or Flag = 10 Then
            bm.TestBranch(Branch)
        End If
    End Sub

    Private Sub FromDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToDate.KeyDown, FromDate.KeyDown, Branch.KeyDown
        If e.KeyData = Keys.Enter Then
            SelectNextControl(ctl:=sender, forward:=True, nested:=True, tabStopOnly:=True, wrap:=True)
        End If
    End Sub
End Class