<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailHebergement.aspx.cs" Inherits="AFPABNB.DetailHebergement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="gdvDetail" runat="server">
        <ItemTemplate>

            <div class="col-lg-12">

                <div class="card">
                    <img class="card-img-top img-fluid" src='./Images/<%#Eval("Photo") %>' alt="" style="width: 1200px; height: 500px;">
                    <div class="card-body">
                        <h3 class="card-title"><%#Eval("Nom") %></h3>
                        <span class="badge badge-pill badge-secondary"><%#Eval("Adresse.Numero") %> <%#Eval("Adresse.Voie") %> - <%#Eval("Adresse.CodePostal") %> <%#Eval("Adresse.Ville") %></span>
                        <span class="badge badge-pill badge-warning"><%#Eval("Reservation.Prix") %> €</span>
                        <p class="card-text"><%#Eval("Description") %></p>
                        <span class="text-warning">★ ★ ★ ★ ☆</span>
                        4.0 étoiles
            <div>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning mt-3" Text='Mettre en favoris' OnClick="Favoris_Click" CommandArgument='<%#Eval("IdHebergement") %>' />
                <asp:Button ID="Button2" runat="server" CssClass="btn btn-info mt-3" Text='Réserver' OnClick="Reserver_Click" CommandArgument='<%#Eval("IdHebergement") %>' />

                 <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary mt-3" Text='Contacter' OnClick="Contact_Click" CommandArgument='<%#Eval("IdHebergement") %>' />
            </div>
                        <asp:TextBox ID="txtMessages" runat="server">@"Data Source=localhost\sqlexpress;Initial Catalog=AfpaBNB;User ID=sa;Password = root";</asp:TextBox>
                    </div>
                </div>

            </div>

        </ItemTemplate>
    </asp:ListView>


    <%--    <asp:GridView ID="gdvDetail" runat="server" AutoGenerateColumns="false" CssClass="Grid">
        <Columns>

            <asp:TemplateField>
                <ItemTemplate>
                     <a href='<%#Eval("Photo") %>' data-lightbox="image-1" data-title='<%#Eval("Nom") %>'>
                            <asp:Image ID="Image1" runat="server" src='<%#Eval("Photo") %>' style="width: 400px; height: 400px;" /></a>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:BoundField DataField="Nom" HeaderText="Nom"/>
            <asp:BoundField DataField="Description" HeaderText="Description"/>
            <asp:BoundField DataField="Prix" HeaderText="Prix €/nuit" />
            <asp:BoundField DataField="Ville" HeaderText="Ville" />
            <asp:BoundField DataField="CodePostal" HeaderText="Code Postal" />
            <asp:BoundField DataField="Type" HeaderText="Type d'hébergement" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="btnReserver" CssClass="btn btn-danger my-3" runat="server" Text="Réserver" CommandArgument='<%#Eval("Id") %>' OnClick="Reserver_Click" />
                    <asp:LinkButton ID="btnFavoris" runat="server" Text="Favoris" CssClass="btn btn-warning my-3" CommandArgument='<%#Eval("Id") %>' OnClick="Favoris_Click" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>--%>
</asp:Content>
