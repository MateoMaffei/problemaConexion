<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/masterZulu.Master" CodeBehind="productos.aspx.vb" Inherits="Zulu_K_Page.productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .imagenes{
            width:900px;
        }
        .colores{
        }
        .rojo{
            width:20px;
            height:20px;
            background-color:red;
            float:left;
            margin-left:5px;
            margin-right:5px;
            margin-top:7px;
        }
        .azul {
            width: 20px;
            height: 20px;
            background-color: blue;
            float: left;
            margin-right: 5px;
            margin-top: 7px;
        }

        .amarillo {
            width: 20px;
            height: 20px;
            background-color: yellow;
            float: left;
            margin-right: 5px;
            margin-top: 7px;
        }

        .celeste {
            width: 20px;
            height: 20px;
            background-color: deepskyblue;
            float: left;
            margin-right: 5px;
            margin-top: 7px;
        }

        .verde {
            width: 20px;
            height: 20px;
            background-color: green;
            float: left;
            margin-right: 5px;
            margin-top: 7px;
        }

        .negro {
            width: 20px;
            height: 20px;
            background-color: black;
            float: left;
            margin-right: 5px;
            margin-top: 7px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <form runat="server">
        <div class="row" style="margin-top:30px;">
            <div style="float: left; margin-left: 986px; margin-top: 6px; margin-right:5px; color: dodgerblue;">
                <p>Ordenar por :</p>
            </div>
            <asp:DropDownList ID="ddlSeleccion" runat="server" AutoPostBack="true" Width="150" class="form-control" ForeColor="DodgerBlue">
                <asp:ListItem Value="Normal">Normal</asp:ListItem>
                <asp:ListItem Value="PorNombre">Por Nombre</asp:ListItem>
                <asp:ListItem>Precio</asp:ListItem>
                <asp:ListItem>Stock</asp:ListItem>
            </asp:DropDownList>
        </div>
    <div class="container">
            <asp:Repeater ID="repProductos" runat="server">
                <itemtemplate>
                    <div class="card" style="margin:50px 0; background-color:transparent; border:1px solid dodgerblue">
                        <div class="card-body">
                            <div class="col-3" style="float:left">
                                <asp:Image ID="Image1" ImageUrl='<%# Eval("url-imagen")%>' Width="100%" runat="server" />
                            </div>
                            <div class="col-5" style="float:left; margin-left:10px;font-family:Gotham;font-size:22px;color:black">
                                <div class="row"><u>Nombre</u>: <%# Eval("nombre") %></div>
                                <div class="row"><u>Marca</u>: <%# Eval("marca") %></div>
                                <div class="row"><u>Tipo de Producto</u>: <%# Eval("tipo")%></div>
                                <div class="row"><u>Precio</u>: $<%# Eval("precio")%></div>
                                <div class="row"><u>En stock</u>: <%# Eval("stockkkk")%> </div>
                                <div class="row colores"><u>Colores</u>: 
                                    <div class="rojo"></div>
                                    <div class="azul"></div>
                                    <div class="amarillo"></div>
                                    <div class="celeste"></div>
                                    <div class="verde"></div>
                                    <div class="negro"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </itemtemplate>
            </asp:Repeater>
    </div>

    </form>

</asp:Content>
