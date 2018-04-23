Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport1
''' </summary>
Public Class XtraReport1
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private xrLabel1 As XRLabel
	Private ReportHeader As ReportHeaderBand
	Private xrLabel3 As XRLabel
	Private xrPictureBox1 As XRPictureBox
	Private xrLabel2 As XRLabel
	Private northwind1 As Northwind
	Private CatID As DevExpress.XtraReports.Parameters.Parameter
	Private WithEvents xrSubreport1 As XRSubreport
	Private xtraReport21 As XtraReport2
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
		'
		' TODO: Add constructor logic here
		'
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resourceFileName As String = "XtraReport1.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
		Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
		Me.northwind1 = New Northwind()
		Me.CatID = New DevExpress.XtraReports.Parameters.Parameter()
		Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
		Me.xtraReport21 = New XtraReport2()
		CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.xtraReport21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrSubreport1, Me.xrLabel3, Me.xrPictureBox1, Me.xrLabel2})
		Me.Detail.HeightF = 132F
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel3
		' 
		Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spCategory.Description")})
		Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 49.95832F)
		Me.xrLabel3.Name = "xrLabel3"
		Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel3.SizeF = New System.Drawing.SizeF(348.9583F, 23F)
		Me.xrLabel3.Text = "xrLabel3"
		' 
		' xrPictureBox1
		' 
		Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "spCategory.Picture")})
		Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(427.0833F, 10.00001F)
		Me.xrPictureBox1.Name = "xrPictureBox1"
		Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(212.9167F, 62.95834F)
		Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
		' 
		' xrLabel2
		' 
		Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spCategory.CategoryName")})
		Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
		Me.xrLabel2.Name = "xrLabel2"
		Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel2.SizeF = New System.Drawing.SizeF(100F, 23F)
		Me.xrLabel2.Text = "xrLabel2"
		' 
		' TopMargin
		' 
		Me.TopMargin.HeightF = 100F
		Me.TopMargin.Name = "TopMargin"
		Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' BottomMargin
		' 
		Me.BottomMargin.HeightF = 100F
		Me.BottomMargin.Name = "BottomMargin"
		Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
		Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(275F, 0F)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.SizeF = New System.Drawing.SizeF(128.125F, 35.5F)
		Me.xrLabel1.StylePriority.UseFont = False
		Me.xrLabel1.Text = "Categories"
		' 
		' ReportHeader
		' 
		Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.ReportHeader.HeightF = 35.5F
		Me.ReportHeader.Name = "ReportHeader"
		' 
		' northwind1
		' 
		Me.northwind1.DataSetName = "Northwind"
		Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' CatID
		' 
		Me.CatID.Name = "CatID"
		Me.CatID.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
		Me.CatID.Value = 0
		' 
		' xrSubreport1
		' 
		Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 95.58334F)
		Me.xrSubreport1.Name = "xrSubreport1"
		Me.xrSubreport1.ReportSource = Me.xtraReport21
		Me.xrSubreport1.SizeF = New System.Drawing.SizeF(100F, 23F)
'		Me.xrSubreport1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrSubreport1_BeforePrint);
		' 
		' XtraReport1
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
		Me.DataMember = "spCategory"
		Me.DataSource = Me.northwind1
		Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CatID})
		Me.Version = "9.3"
'		Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
		CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.xtraReport21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
		Dim da As New NorthwindTableAdapters.spCategoryTableAdapter()

		da.Fill(northwind1.spCategory, Convert.ToInt32(Me.CatID.Value))
	End Sub

	Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrSubreport1.BeforePrint
		CType((CType(sender, XRSubreport)).ReportSource, XtraReport).Parameters("CatID").Value = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
	End Sub
End Class
