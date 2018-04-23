using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel1;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrLabel3;
    private XRPictureBox xrPictureBox1;
    private XRLabel xrLabel2;
    private Northwind northwind1;
    private DevExpress.XtraReports.Parameters.Parameter CatID;
    private XRSubreport xrSubreport1;
    private XtraReport2 xtraReport21;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport1()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
	
	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
        string resourceFileName = "XtraReport1.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.northwind1 = new Northwind();
        this.CatID = new DevExpress.XtraReports.Parameters.Parameter();
        this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
        this.xtraReport21 = new XtraReport2();
        ((System.ComponentModel.ISupportInitialize)(this.northwind1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xtraReport21)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1,
            this.xrLabel3,
            this.xrPictureBox1,
            this.xrLabel2});
        this.Detail.HeightF = 132F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel3
        // 
        this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spCategory.Description")});
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 49.95832F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(348.9583F, 23F);
        this.xrLabel3.Text = "xrLabel3";
        // 
        // xrPictureBox1
        // 
        this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "spCategory.Picture")});
        this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(427.0833F, 10.00001F);
        this.xrPictureBox1.Name = "xrPictureBox1";
        this.xrPictureBox1.SizeF = new System.Drawing.SizeF(212.9167F, 62.95834F);
        this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
        // 
        // xrLabel2
        // 
        this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spCategory.CategoryName")});
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
        this.xrLabel2.Text = "xrLabel2";
        // 
        // TopMargin
        // 
        this.TopMargin.HeightF = 100F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.HeightF = 100F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(275F, 0F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(128.125F, 35.5F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.Text = "Categories";
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.ReportHeader.HeightF = 35.5F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // northwind1
        // 
        this.northwind1.DataSetName = "Northwind";
        this.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // CatID
        // 
        this.CatID.Name = "CatID";
        this.CatID.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32;
        this.CatID.Value = 0;
        // 
        // xrSubreport1
        // 
        this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.58334F);
        this.xrSubreport1.Name = "xrSubreport1";
        this.xrSubreport1.ReportSource = this.xtraReport21;
        this.xrSubreport1.SizeF = new System.Drawing.SizeF(100F, 23F);
        this.xrSubreport1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrSubreport1_BeforePrint);
        // 
        // XtraReport1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
        this.DataMember = "spCategory";
        this.DataSource = this.northwind1;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CatID});
        this.Version = "9.3";
        this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XtraReport1_BeforePrint);
        ((System.ComponentModel.ISupportInitialize)(this.northwind1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xtraReport21)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    private void XtraReport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        NorthwindTableAdapters.spCategoryTableAdapter da = new NorthwindTableAdapters.spCategoryTableAdapter();

        da.Fill(northwind1.spCategory, Convert.ToInt32(this.CatID.Value));
    }

    private void xrSubreport1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        ((XtraReport)((XRSubreport)sender).ReportSource).Parameters["CatID"].Value =
            Convert.ToInt32(GetCurrentColumnValue("CategoryID"));
    }
}
