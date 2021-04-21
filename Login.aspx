﻿<%@ Page Language="C#" Async="true" AutoEventWireup="true"   CodeBehind="Login.aspx.cs" Inherits="Montres.Login" %>
<!DOCTYPE html>
<html lang="es">
    <head>
        <title>Inicio de sesión</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="Shortcut Icon" type="image/x-icon" href="assets/icons/montres.ico" />
        <link rel="stylesheet" href="css/loginnew.css"/>
        <meta http-equiv="Expires" content="0" />
        <meta http-equiv="Pragma" content="no-cache" />
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>

        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.8/css/solid.css">
        <script src="https://use.fontawesome.com/releases/v5.0.7/js/all.js"></script>


    </head>

    <body  style="background-image: url('assets/img/fondo.jpg');">
        
        

         <figure>
                        <img src="assets/img/montres.png" alt="Montres" class="img-responsive center-box" style=" margin-bottom: 25px; ">
                    </figure>
        
        
            <div class="modal-dialog text-center">
        <div class="col-sm-8 main-section">
            <div class="modal-content" style="background-color: #3b4652;  opacity: .85; padding: 0 20px; box-shadow: 0px 0px 3px #848484;">
                <div class="col-12 user-img">
                    <img src="assets/img/user.png" th:src="@{/img/user.png}"/>
                </div>
               
                <form runat="server" method="post" class="col-12">

                    

                
                        <asp:Panel  id="error_login" class="alert alert-danger" runat="server">
                                                    <asp:Label   ID="Label1" runat="server" Text="Label"><strong>¡Error!</strong> Usuario o contraseña incorrecta.</asp:Label>

                        </asp:Panel>
               

                    
               
                
                    
             



                    <div class="form-group" id="user-group">
                        <asp:TextBox runat="server" type="text" class="form-control" placeholder="Cédula" id="user" name="user"/>
                    </div>
                    <div class="form-group" id="contrasena-group">
                        <asp:TextBox runat="server" type="password" class="form-control" placeholder="Contraseña" ID="contra" name="contra"/>

                    </div>
                    <asp:LinkButton  OnClick="click_Button"  runat="server"  style="margin-bottom: 25px;" class="btn btn-primary">
                        <i class="fas fa-sign-in-alt"></i>  Ingresar
                    </asp:LinkButton>
                </form>
            </div>
        </div>
    </div>
        
        <br><br><br><br>
        
            <footer class="my-5 pt-5 text-muted text-center text-small">
    <p class="mb-1" style="color: black;">&copy; 2019 Software O&B</p>
  </footer>




      




    </body>
</html>