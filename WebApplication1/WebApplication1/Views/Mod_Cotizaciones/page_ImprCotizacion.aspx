﻿<%@ Page Title="Impresion de Cotizaciones" Language="C#" MasterPageFile="~/Views/website.Master" AutoEventWireup="true" CodeBehind="page_ImprCotizacion.aspx.cs" Inherits="WebApplication1.Views.page_ImprCotizacion" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="crystalreportviewers13/js/crviewer/crv.js"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="crystalreportviewers13/js/crviewer/crv.js"></script>

    <style>
        a {
            color: #337ab7;
        }
    </style>

    <script type="text/javascript">
        $('input[name$="TestButton2"]').on("click", function () {

            $('#example').modal('toggle');
            return false;

        });
    </script>

    <!-- Contenido -->
    <div id="page-wrapper">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="page-header">Impresion de Cotizaciones</h1>
                </div>

                <!-- /.row -->
                <div class="row">
                    <div class="col-lg-12">
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Consulta de numero de Cotizacion
                            </div>
                            <div class="panel-body">
                                <div class="row">

                                    <div class="col-lg-12">
                                        <div runat="server" id="NotConsulta" />

                                        <!--Consulta de numero de Cotizacion-->
                                        <form>
                                            <div class="form-group">
                                                <label>Ingrese el numero de Cotizacion:</label>
                                                <asp:TextBox ID="txtConsultar" CssClass="form-control" runat="server" />
                                                <br />
                                                <p>
                                                    <asp:Button CssClass="btn btn-primary btn-lg" runat="server" ID="btConsultarNumero" OnClick="btConsultarNumero_Click" Text="Consultar" />
                                                   <!-- <asp:Button CssClass="btn btn-primary" runat="server" ID="btnMostrarReporte" OnClick="btMostrarReporte_Click" Text="Mostrar Cotizacion" />-->
                                                                                                     
                                                </p>

                                            </div>

                                            <div>
                                                

                                            </div>
                                    </div>

                                </div>
                                <!-- /.panel-body -->
                            </div>
                            <!-- /.panel -->
                        </div>
                        <!-- /.col-lg-12 -->
                    </div>
                    <!-- /.row -->

                </div>

            </div>

        </div>
        <!--Fin Contenido -->
</asp:Content>


