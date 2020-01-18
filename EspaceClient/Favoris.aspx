<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="Favoris.aspx.cs" Inherits="AFPABNB.EspaceClient.Favoris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True"></asp:Label>

    <asp:ListView ID="gdvFavoris" runat="server">
        <ItemTemplate>
            <div class="d-flex border bg-light p-2 mb-1">
                <div class="border">
                    <img src="../<%#Eval("Photo") %>" class="petite" />
                    <div class="grande">
                    </div>
                </div>
                <div class="d-flex flex-column px-4">
                    <div>
                        <h3><%#Eval("Nom") %></h3>
                    </div>
                    <div>
                        <%--    <span class="badge badge-pill badge-info"><%#Eval("Ville") %></span>--%>
                        <%--  <span class="badge badge-pill badge-warning"><%#Eval("Prix") %> €</span>--%>
                    </div>
                    <div>
                        <p></br><%#Eval("Description") %></p>
                    </div>
                    <div>
                        <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CssClass="btn btn-danger" CommandArgument='<%# Eval("IdHebergement") %>' CommandName='Supprimer' OnClick="btnDelete_Click" />
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <%--        <asp:GridView ID="gdvFavoris" runat="server" AutoGenerateColumns="False">
        <Columns> 
            <asp:TemplateField>
                <ItemTemplate>
                     <a href='<%#Eval("Photo") %>' data-lightbox="image-1" data-title='<%#Eval("Nom") %>'>
                     <asp:Image ID="Image1" runat="server" src='<%#Eval("Photo") %>' CssClass="img-fluid myImg" /></a>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="Nom" HeaderText="Nom"/>
            <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-CssClass="just"/>
            <asp:BoundField DataField="Prix" HeaderText="Prix €/nuit" />
            <asp:BoundField DataField="Ville" HeaderText="Ville" />
            <asp:BoundField DataField="CodePostal" HeaderText="CodePostal" />
            <asp:BoundField DataField="Type" HeaderText="Type d'hébergement" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" Text="X" CssClass="btn btn-danger" CommandArgument='<%# Eval("Id") %>' CommandName='Supprimer' OnClick="btnDelete_Click" Width="100%" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>--%>
</asp:Content>
