<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Montres.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/cards.css">
        <script src="js/cards.js"></script>

        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/morris.js/0.5.1/morris.css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.6/css/bootstrap.min.css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootcards/1.1.1/css/bootcards-desktop.min.css">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/morris.js/0.5.1/morris.css">
        <script src=" https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.4/jquery.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.6/js/bootstrap.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/bootcards/1.1.1/js/bootcards.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/raphael/2.1.2/raphael-min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/morris.js/0.5.1/morris.min.js"></script>

        <title>Inicio</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <div class="page-header">
                <h1 class="all-tittles"><small>Inicio</small></h1>
            </div>

            <div class="row">
                <div class=" col-12">
                    <div class="panel panel-default bootcards-summary">
                        <div class="panel-heading">
                            <h3 class="panel-title">Información actual</h3>
                        </div>
                        <div class="panel-body">
                            <div class="row">

                                <div class="col-xs-6 col-sm-4">
                                    <a class="bootcards-summary-item" href="ListarParte.jsp" style="text-decoration:none">
                                        <i class="zmdi zmdi-shape zmdi-hc-4x"></i>
                                        <h4>Partes <span class="label label-info">22</span></h4>
                                    </a>
                                </div>
                                <div class="col-xs-6 col-sm-4">
                                    <a class="bootcards-summary-item" href="Bitacora2.jsp" style="text-decoration:none">
                                        <i class="zmdi zmdi-trending-down zmdi-hc-4x"></i>
                                        <h4>Salidas <span class="label label-warning">33</span></h4>
                                    </a>
                                </div>
                                <div class="col-xs-6 col-sm-4">
                                    <a class="bootcards-summary-item" href="#" style="text-decoration:none">
                                        <i class="zmdi zmdi-refresh-alt zmdi-hc-4x"></i>
                                        <h4>Devoluciones <span class="label label-info">109</span></h4>
                                    </a>
                                </div>
                                <div class="col-xs-6 col-sm-4">
                                    <a class="bootcards-summary-item" href="#" style="text-decoration:none">
                                        <i class="zmdi zmdi-minus-circle-outline zmdi-hc-4x"></i>
                                        <h4>Minimos <span class="label label-info">110</span></h4>
                                    </a>
                                </div>
                                <div class="col-xs-6 col-sm-4">
                                    <a class="bootcards-summary-item" href="#" style="text-decoration:none">
                                        <i class="zmdi zmdi-money zmdi-hc-4x"></i>
                                        <h4>Cotizaciones <span class="label label-warning">110</span></h4>
                                    </a>
                                </div>
                                <div class="col-xs-6 col-sm-4">
                                    <a class="bootcards-summary-item" href="ListarUsuarios.jsp" class="link-dark" style="text-decoration:none">
                                        <i class="zmdi zmdi-face zmdi-hc-4x"></i>
                                        <h4>Usuarios <span class="label label-info">444</span></h4>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
</asp:Content>
