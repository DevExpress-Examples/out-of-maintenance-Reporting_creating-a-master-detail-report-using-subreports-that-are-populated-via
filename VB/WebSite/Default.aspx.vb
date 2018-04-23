Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim report As XtraReport = GetReport()

		report.Parameters("CatID").Value = Convert.ToInt32(ddlCategory.SelectedValue)
		report.CreateDocument()
		ReportViewer1.Report = report
	End Sub

	Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
		CType(sender, ReportViewer).Report = Nothing
	End Sub

	Protected Function GetReport() As XtraReport
		If CType(Session("report"), XtraReport) Is Nothing Then
			Session("report") = New XtraReport1()
		End If

		Return CType(Session("report"), XtraReport)
	End Function
End Class
