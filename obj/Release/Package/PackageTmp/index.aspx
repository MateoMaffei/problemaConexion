<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/masterZulu.Master" CodeBehind="index.aspx.vb" Inherits="Zulu_K_Page.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .imagen-slider-1{
            width:100%;
            margin:10px 0;
        }
        .algunos-Productos{
            background-color:#c1c1c1;
            width:90%;
            margin:10px auto;
        }
        .prod-1{
            width:33%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <img class="imagen-slider-1" src="img/slider-1.jpg" />
    </div>
    <div class="algunos-Productos">
        <a href="productos.aspx"><img class="prod-1" src="imagenes/img_0001.png" style="border:1px solid black;"/></a>
        <a href="productos.aspx"><img class="prod-1" src="imagenes/img_0003.png" style="border:1px solid black;" /></a>
        <a href="productos.aspx"><img class="prod-1" src="imagenes/img_0005.png" style="border:1px solid black;" /></a>
    </div>
</asp:Content>
