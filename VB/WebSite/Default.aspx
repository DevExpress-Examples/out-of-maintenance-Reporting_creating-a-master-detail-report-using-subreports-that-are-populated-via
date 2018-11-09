<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.1.Web, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<p><b>Select a category:</b>
		<asp:DropDownList ID="ddlCategory" runat="server" Width="100px" 
			AutoPostBack="True" 
			DataSourceID="SqlDataSource1" 
			DataTextField="CategoryName" 
			DataValueField="CategoryID"
			AppendDataBoundItems="True">
			<asp:ListItem Text="[All]" Value="-1" />
		</asp:DropDownList></p>
		<dx:ReportToolbar ID="ReportToolbar1" runat="server" ShowDefaultButtons="False" ReportViewer="<%#ReportViewer1%>">
			<Items>
				<dx:ReportToolbarButton ItemKind="Search" />
				<dx:ReportToolbarSeparator />
				<dx:ReportToolbarButton ItemKind="PrintReport" />
				<dx:ReportToolbarButton ItemKind="PrintPage" />
				<dx:ReportToolbarSeparator />
				<dx:ReportToolbarButton Enabled="False" ItemKind="FirstPage" />
				<dx:ReportToolbarButton Enabled="False" ItemKind="PreviousPage" />
				<dx:ReportToolbarLabel ItemKind="PageLabel" />
				<dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
				</dx:ReportToolbarComboBox>
				<dx:ReportToolbarLabel ItemKind="OfLabel" />
				<dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
				<dx:ReportToolbarButton ItemKind="NextPage" />
				<dx:ReportToolbarButton ItemKind="LastPage" />
				<dx:ReportToolbarSeparator />
				<dx:ReportToolbarButton ItemKind="SaveToDisk" />
				<dx:ReportToolbarButton ItemKind="SaveToWindow" />
				<dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
					<Elements>
						<dx:ListElement Value="pdf" />
						<dx:ListElement Value="xls" />
						<dx:ListElement Value="rtf" />
						<dx:ListElement Value="mht" />
						<dx:ListElement Value="txt" />
						<dx:ListElement Value="csv" />
						<dx:ListElement Value="png" />
					</Elements>
				</dx:ReportToolbarComboBox>
			</Items>
			<Styles>
				<LabelStyle>
					<Margins MarginLeft="3px" MarginRight="3px" />
				</LabelStyle>
			</Styles>
		</dx:ReportToolbar>
		<dx:ReportViewer ID="ReportViewer1" runat="server" OnUnload="ReportViewer1_Unload">
		</dx:ReportViewer>
	</div>
	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
		SelectCommand="spCategory" SelectCommandType="StoredProcedure">
		<SelectParameters>
			<asp:Parameter DefaultValue="-1" Name="CategoryID" Type="Int32" />
		</SelectParameters>
	</asp:SqlDataSource>
	</form>
</body>
</html>