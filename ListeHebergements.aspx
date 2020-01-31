<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListeHebergements.aspx.cs" Inherits="AFPABNB.ListeHebergements" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="lvwArticle" runat="server" OnPagePropertiesChanging="lvwArticle_PagePropertiesChanging">
        <ItemTemplate>
            <div class="d-flex border bg-light p-2 mb-1">
                <div class="border">
                    <img src="./Images/<%#Eval("Photo") %>" class="petite" />
                    <div class="grande">
                    </div>
                </div>
                <div class="d-flex flex-column px-4">
                    <div>
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Detail_Click" CommandArgument='<%#Eval("IdHebergement") %>'><h3><%#Eval("Nom") %></h3></asp:LinkButton>
                    </div>
                    <div>
                        <span class="badge badge-pill badge-info"><%#Eval("Adresse.Ville") %></span>
                        <span class="badge badge-pill badge-warning"><%#Eval("Reservation.Prix") %> €</span>
                    </div>
                    <div>
                        <p></br><%#Eval("Description") %></p>
                    </div>
                    <div>
                        <div class="btn-group" role="group" aria-label="Button group with nested dropdown">
                            <asp:Button ID="Button1" runat="server" CssClass="btn btn-warning mt-3" Text='&#x2661;' OnClick="Favoris_Click" CommandArgument='<%#Eval("IdHebergement") %>' />
                            <asp:Button ID="Button2" runat="server" CssClass="btn btn-info mt-3" Text='Réserver' OnClick="Reserver_Click" CommandArgument='<%#Eval("IdHebergement") %>' />
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>


<%--    <nav aria-label="...">
        <ul class="pagination pagination-lg justify-content-end">
            <li class="page-item">
                <a class="page-link" href="#">--%>
                    <asp:DataPager ID="dtpArticle" PagedControlID="lvwArticle" PageSize="5" runat="server">
                        <Fields>
                            <asp:NumericPagerField />
                        </Fields>
                    </asp:DataPager>
<%--                </a>
            </li>
        </ul>
    </nav>--%>


</asp:Content>
