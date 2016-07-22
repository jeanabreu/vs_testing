<%@ Page Title="" Language="C#" MasterPageFile="~/Views/website.Master" AutoEventWireup="true" CodeBehind="page_ImprCotizacion.aspx.cs" Inherits="WebApplication1.Views.page_ImprCotizacion" %>
    
    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    </asp:Content>
  
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                                    <div   runat="server"  id="NotConsulta" />

                                    <!--Consulta de numero de Cotizacion-->
                                    <form> 
                                        <div class="form-group">
                                            <label>Ingrese el numero de Cotizacion:</label>
                                            <asp:TextBox ID="txtConsultar" CssClass ="form-control" runat="server" /> <br />
                                                <p> 
                                                    <asp:button  CssClass="btn btn-primary" runat="server" ID="btConsultarNumero" OnClick="btConsultarNumero_Click" Text="Consultar"/>
                                                    <button type="reset"  class="btn btn-danger">Limpiar Campos</button>
                                                </p>
                     
                                        </div>


                                        <!--Validacion de Campos Post-Consulta -->
                                 
                                    </form>
                                </div>
                                <!-- /.col-lg-6 (nested) -->
                               <!-- <div class="col-lg-6">
                                    <h1>Disabled Form States</h1>
                                    <form role="form">
                                        <fieldset disabled>
                                            <div class="form-group">
                                                <label for="disabledSelect">Disabled input</label>
                                                <input class="form-control" id="disabledInput" type="text" placeholder="Disabled input" disabled>
                                            </div>
                                            <div class="form-group">
                                                <label for="disabledSelect">Disabled select menu</label>
                                                <select id="disabledSelect" class="form-control">
                                                    <option>Disabled select</option>
                                                </select>
                                            </div>
                                            <div class="checkbox">
                                                <label>
                                                    <input type="checkbox">Disabled Checkbox
                                                </label>
                                            </div>
                                            <button type="submit" class="btn btn-primary">Disabled Button</button>
                                        </fieldset>
                                    </form>
                                    <h1>Form Validation States</h1>
                                    <form role="form">
                                        <div class="form-group has-success">
                                            <label class="control-label" for="inputSuccess">Input with success</label>
                                            <input type="text" class="form-control" id="inputSuccess">
                                        </div>
                                        <div class="form-group has-warning">
                                            <label class="control-label" for="inputWarning">Input with warning</label>
                                            <input type="text" class="form-control" id="inputWarning">
                                        </div>
                                        <div class="form-group has-error">
                                            <label class="control-label" for="inputError">Input with error</label>
                                            <input type="text" class="form-control" id="inputError">
                                        </div>
                                    </form>
                                    <h1>Input Groups</h1>
                                    <form role="form">
                                        <div class="form-group input-group">
                                            <span class="input-group-addon">@</span>
                                            <input type="text" class="form-control" placeholder="Username">
                                        </div>
                                        <div class="form-group input-group">
                                            <input type="text" class="form-control">
                                            <span class="input-group-addon">.00</span>
                                        </div>
                                        <div class="form-group input-group">
                                            <span class="input-group-addon"><i class="fa fa-eur"></i>
                                            </span>
                                            <input type="text" class="form-control" placeholder="Font Awesome Icon">
                                        </div>
                                        <div class="form-group input-group">
                                            <span class="input-group-addon">$</span>
                                            <input type="text" class="form-control">
                                            <span class="input-group-addon">.00</span>
                                        </div>
                                        <div class="form-group input-group">
                                            <input type="text" class="form-control">
                                            <span class="input-group-btn">
                                                <button class="btn btn-default" type="button"><i class="fa fa-search"></i>
                                                </button>
                                            </span>
                                        </div>
                                    </form>
                                </div>
                                <!-- /.col-lg-6 (nested) -->
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

   
