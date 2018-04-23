Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for XtraReport2
''' </summary>
Public Class XtraReport2
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Private xrLabel1 As XRLabel
	Private northwind1 As Northwind
	Private CatID As DevExpress.XtraReports.Parameters.Parameter
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
		Dim resourceFileName As String = "XtraReport2.resx"
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.northwind1 = New Northwind()
		Me.CatID = New DevExpress.XtraReports.Parameters.Parameter()
		CType(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		' 
		' Detail
		' 
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
		Me.Detail.HeightF = 47F
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		' 
		' xrLabel1
		' 
		Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "spProducts.ProductName")})
		Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(225F, 12.5F)
		Me.xrLabel1.Name = "xrLabel1"
		Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
		Me.xrLabel1.SizeF = New System.Drawing.SizeF(206.25F, 23F)
		Me.xrLabel1.Text = "xrLabel1"
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
		' XtraReport2
		' 
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
		Me.DataMember = "spProducts"
		Me.DataSource = Me.northwind1
		Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CatID})
		Me.Version = "9.3"
'		Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport2_BeforePrint);
		CType(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region

	Private Sub XtraReport2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
		Dim da As New NorthwindTableAdapters.spProductsTableAdapter()

		da.Fill(northwind1.spProducts, Convert.ToInt32(Me.CatID.Value))
	End Sub
End Class
