<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paiement.aspx.cs" Inherits="AFPABNB.Paiement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True"></asp:Label>


    <asp:ListView ID="gdvReserver" runat="server">
        <ItemTemplate>
            <div class="d-flex border bg-light p-2 mb-1">
                <div class="border">
                    <img id='<%#Eval("IdHebergement") %>' src="<%#Eval("Photo") %>" class="petite" />
                    <div class="grande">
                    </div>
                </div>
                <div class="d-flex flex-column px-4">
                    <div>
                        <h3><%#Eval("Nom") %></h3>
                    </div>
                    <div>
                        <span class="badge badge-pill badge-info"><%#Eval("Adresse.Ville") %></span>
                        <span class="badge badge-pill badge-warning"><%--<%#Eval("Prix") %>--%> €</span>
                    </div>
                    <div>
                        <p></br><%#Eval("Description") %></p>
                    </div>
                    <div>
                        <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CssClass="btn btn-danger" CommandArgument='<%# Eval("IdHebergement") %>' CommandName='Supprimer' OnClick="btnDelete_Click" />
                    </div>
                </div>
            </div>

            <div class="d-flex justify-content-center">
                <div style="width: 1140px" class="bg-light border rounded p-3">

                    <div class="input-group">
                        <asp:DropDownList ID="DropDownList2" class="custom-select" runat="server">
                            <asp:ListItem>CB</asp:ListItem>
                            <asp:ListItem>Visa</asp:ListItem>
                            <asp:ListItem>Mastercard</asp:ListItem>
                            <asp:ListItem>American Express</asp:ListItem>
                            <asp:ListItem>Paypal</asp:ListItem>
                        </asp:DropDownList>
                        <div class="input-group-append">
                            <button class="btn btn-md btn-outline-success" type="button">PAIEMENT</button>
                        </div>
                    </div>

                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
