<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597940/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2656)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WebSite/App_Code/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WebSite/App_Code/XtraReport1.vb))
* [XtraReport2.cs](./CS/WebSite/App_Code/XtraReport2.cs) (VB: [XtraReport2.vb](./VB/WebSite/App_Code/XtraReport2.vb))
* [Northwind_StoredProcedures.sql](./CS/WebSite/App_Data/Northwind_StoredProcedures.sql) (VB: [Northwind_StoredProcedures.sql](./VB/WebSite/App_Data/Northwind_StoredProcedures.sql))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# Creating a Master-Detail Report using subreports that are populated via stored procedures


<p>This example demonstrates how to create a Master-Detail Report using subreports. Data for reports is retrieved from the server via stored procedures. A parameter for a stored procedure that retrieves master data is selected by end-users from the DropDownList control and passed to the master report via its Parameter object (see the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument4812"><u>Report Parameters</u></a>) in the Page_Load event handler. Later, in the XtraReport.BeforePrint event handler, the value of this parameter is passed to the TableAdapter.Fill() method that invokes a stored procedure. A parameter for a stored procedure that retrieves detail data is obtained via the <a href="http://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_GetCurrentColumnValuetopic"><u>XtraReportBase.GetCurrentColumnValue Method</u></a> and passed to the subreport via its own Parameter object in the XRSubreport.BeforePrint event handler of the XRSubreport control within the master report. Finally, in the XtraReport.BeforePrint event handler of the subreport, the value of this parameter is passed to the TableAdapter.Fill() method that invokes the second stored procedure.</p><p>The Northwind_StoredProcedures.sql file containing stored procedures is included (tested with MS SQL Server 2005). You should create them in the Northwind database prior to running this example.</p><p><strong>Note 1:</strong><br />
Since parameterized TableAdapters are used in this example, and parameter values are provided manually, you should make sure that the TableAdapter is detached from the XtraReport.DataAdapter property for both reports. Otherwise, the "Expected parameter was not supplied" error might occur. BTW, we have a suggestion to provide an automatic parameter passing: <a href="https://www.devexpress.com/Support/Center/p/S33371">Parameters - Automatically create corresponding parameters for table adapters and stored procedures</a>. If you find this functionality useful, you can increase its popularity by tracking it.</p><p><strong>Note 2:</strong><br />
A master report instance in this example is assigned to the ReportViewer.Report property manually. At that point, you should make sure that the ReportViewer.Report property value is <strong>not</strong> set at design time. Please review the <a href="https://www.devexpress.com/Support/Center/p/K18179">Troubleshooting: The Report Toolbar isn't working, so it's impossible to navigate to other pages or export the report</a> Knowledge Base article for more information on this subject.</p><p><strong>Note 3:</strong><br />
The Master-Detail Report in this example is created via subreports only to demonstrate the parameters passing technique. Since the "Categories" and "Products" tables in the Northwind database have a relation by default, creating a Master-Detail Report via the DetailReportBand is preferable. Please review the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument1466"><u>Master-Detail Report</u></a> help section for more information.</p><p><strong>Related examples:</strong></p><p><a href="https://www.devexpress.com/Support/Center/p/E889">How to dynamically produce a web report using the SQL query with parameters as data source</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E509">How to pass a parameter to a web report</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E488">How to query a report's parameters in a Web application using a combo box control</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E999">How to use a stored procedure with parameters as a report data source in a Web application</a><br />
<a href="https://www.devexpress.com/Support/Center/p/E1740">How to use a stored procedure with parameters as a report data source in a WinForms application </a></p>

<br/>


