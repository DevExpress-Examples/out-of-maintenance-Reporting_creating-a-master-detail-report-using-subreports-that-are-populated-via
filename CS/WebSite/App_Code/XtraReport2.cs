using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport2
/// </summary>
public class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRLabel xrLabel1;
    private Northwind northwind1;
    private DevExpress.XtraReports.Parameters.Parameter CatID;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport2()
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
        string resourceFileName = "XtraReport2.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.northwind1 = new Northwind();
        this.CatID = new DevExpress.XtraReports.Parameters.Parameter();
        ((System.ComponentModel.ISupportInitialize)(this.northwind1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
        this.Detail.HeightF = 47F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "spProducts.ProductName")});
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(225F, 12.5F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(206.25F, 23F);
        this.xrLabel1.Text = "xrLabel1";
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
        // XtraReport2
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
        this.DataMember = "spProducts";
        this.DataSource = this.northwind1;
        this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.CatID});
        this.Version = "9.3";
        this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XtraReport2_BeforePrint);
        ((System.ComponentModel.ISupportInitialize)(this.northwind1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

    private void XtraReport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
        NorthwindTableAdapters.spProductsTableAdapter da = new NorthwindTableAdapters.spProductsTableAdapter();

        da.Fill(northwind1.spProducts, Convert.ToInt32(this.CatID.Value));
    }
}
