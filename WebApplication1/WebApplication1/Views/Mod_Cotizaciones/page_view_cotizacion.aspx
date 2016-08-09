<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_view_cotizacion.aspx.cs" Inherits="WebApplication1.Views.Mod_Cotizaciones.page_view_cotizacion" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="../bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"/>

    <script src="crystalreportviewers13/js/crviewer/crv.js"></script>
</head>
<body>
     
    <form id="form1" runat="server">
    <div class="col-md-1">
        <asp:Button CssClass="btn btn-danger btn-lg" runat="server" ID="btCerrar" OnClick="btCerrar_Click" Text="Cerrar" /><br /> 
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" PageZoomFactor="150" ToolPanelView="None" />
    
    </div>
    </form>
</body>
</html>
