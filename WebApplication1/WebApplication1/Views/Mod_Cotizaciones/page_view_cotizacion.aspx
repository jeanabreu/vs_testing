<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_view_cotizacion.aspx.cs" Inherits="WebApplication1.Views.Mod_Cotizaciones.page_view_cotizacion" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="crystalreportviewers13/js/crviewer/crv.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="label" Text="Label" runat="server"></asp:Label>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" ToolPanelView="None" />
    
    </div>
    </form>
</body>
</html>
