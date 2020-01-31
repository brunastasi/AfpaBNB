<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="AFPABNB.EspaceClient.Reservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <div class="row">
            <div class="col-3">

                <div class="list-group">
                    <a href="Compte.aspx" class="list-group-item list-group-item-action">Mon Compte
                    </a>
                    <a href="Favoris.aspx" class="list-group-item list-group-item-action">Mes Favoris</a>
                    <a href="Reservation.aspx" class="list-group-item list-group-item-action active">Mes Reservations</a>
                    <a href="AjoutHebergement.aspx" class="list-group-item list-group-item-action">Ajouter un Hebergement</a>
                    <a href="#" class="list-group-item list-group-item-action">Messagerie</a>
                </div>

            </div>
            <div class="col-9">

                <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True"></asp:Label>

                <asp:ListView ID="gdvReserver" runat="server">
                    <ItemTemplate>
                        <div class="d-flex border bg-light p-2 mb-1">
                            <div class="border">
                                <img src="../Images/<%#Eval("Photo") %>" class="petite" />
                                <div class="grande">
                                </div>
                            </div>
                            <div class="d-flex flex-column px-4">
                                <div>
                                    <h3><%#Eval("Nom") %></h3>
                                </div>
                                <div>
                                    <span class="badge badge-pill badge-info"><%#Eval("Adresse.Ville") %></span>
<%--                                    <span class="badge badge-pill badge-warning"><%#Eval("Reservation.Prix") %> €</span>--%>
                                </div>
                                <div>
                                    <p></br><%#Eval("Description") %></p>
                                </div>
                                <div>

                                    <asp:Button ID="Button1" Text="Procéder au paiement" runat="server" CssClass="btn btn-warning" CommandArgument='<%# Eval("IdHebergement") %>' OnClick="btnPaiement_Click" />
                                    <asp:Button ID="Button2" runat="server" Text="Avis" CssClass="btn btn-primary" CommandArgument='<%# Eval("IdHebergement") %>' CommandName='Avi' OnClick="btnAvis_Click" />
                                    <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CssClass="btn btn-danger" CommandArgument='<%# Eval("IdHebergement") %>' CommandName='Supprimer' OnClick="btnDelete_Click" />
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:ListView>

            </div>
        </div>
    </div>

</asp:Content>
