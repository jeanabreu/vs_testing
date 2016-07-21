<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" EnableEventValidation="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!--<script language="javascript">
            window.location.href = "Views/pages/index.html"
    </script>-->

    <link href="../Views/bower_components/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="../Views/dist/css/sb-admin-2.css" rel="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        

          <div class="container">
        <div class="row">
                
            <div class="col-md-4 col-md-offset-4">
                
                <div class="login-panel panel panel-default">

                    <div class="panel-heading">
                         
                        <h3 class="panel-title">Please Sign In</h3>
                    </div>
                   
                    <div class="panel-body">
                        <div   runat="server"  id="myDiv" /> 
                        <form role="form">
                            <fieldset>
                                <div class="form-group">
                                    <asp:TextBox cssClass="form-control" type="text" runat="server" ID="email" required ="required" />
                                </div>
                                <div class="form-group">
                                     <asp:TextBox cssClass="form-control" type="password" value="" runat="server" ID="tpassword"/>
                                </div>
                                 <div class="checkbox">
                                    <label>
                                        <input name="remember" type="checkbox" value="Remember Me">Remember Me
                                    </label>
                                </div>
                             
                                <asp:Button cssClass="btn btn-lg btn-success btn-block" runat="server" ID="Login" OnClick="Login_Click"  Text="Login"/>
                            
                                
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>

            
            
        </div>
    </div>

    <!-- jQuery -->
    <script src="../bower_components/jquery/dist/jquery.min.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="../bower_components/bootstrap/dist/js/bootstrap.min.js"></script>

    <!-- Metis Menu Plugin JavaScript -->
    <script src="../bower_components/metisMenu/dist/metisMenu.min.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="../dist/js/sb-admin-2.js"></script>


    </div>
    </form>
</body>
</html>
