using System;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        XtraReport report = GetReport();

        report.Parameters["CatID"].Value = Convert.ToInt32(ddlCategory.SelectedValue);
        report.CreateDocument();
        ReportViewer1.Report = report;
    }

    protected void ReportViewer1_Unload(object sender, EventArgs e) {
        ((ReportViewer)sender).Report = null;
    }

    protected XtraReport GetReport() {
        if ((XtraReport)Session["report"] == null)
            Session["report"] = new XtraReport1();

        return (XtraReport)Session["report"];
    }
}
