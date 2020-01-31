<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="Avis.aspx.cs" Inherits="AFPABNB.EspaceClient.Avis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <%--        <asp:ListView ID="gdvReserver" runat="server">
            <ItemTemplate>--%>

        <div class="row">
            <div class="col-12">

                <div class="card">
                    <div class="card-body">

                        <h4 class="mb-3">Ajouter un avis</h4>

                        <div class="form-row">
                            <div class="col form-group">
                                <label>Note : </label>
                                <asp:TextBox ID="txtNote" runat="server" type="text" class="form-control" placeholder="Note" value="5"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->
                            <div class="col form-group">
                                <label>Commentaire</label>
                                <asp:TextBox ID="txtCommentaire" runat="server" type="text" class="form-control" placeholder="Commentaire" value="Super"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->
                            <asp:Button ID="Button1" runat="server" Text="Ajouter" class="btn btn-primary btn-block" OnClick="btnAvis_Click" />
                        </div>

                        <hr class="mb-4" />

                        <h3 class="card-title">
                            <asp:Label ID="lblClient" runat="server" Text="Label"></asp:Label></h3>
                        <span class="badge badge-pill badge-secondary">

                            <asp:Label ID="lblNumero" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="lblVoie" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="lblAdresse" runat="server" Text="Label"></asp:Label>
                            -
                            <asp:Label ID="lblCodePostal" runat="server" Text="Label"></asp:Label>
                            <asp:Label ID="lblVille" runat="server" Text="Label"></asp:Label></span>
                        <span class="badge badge-pill badge-warning"><%#Eval("Prix") %> €</span>
                        <p class="card-text"><%#Eval("Description") %></p>
                        <span class="text-warning">★ ★ ★ ★ ☆</span>
                        4.0 étoiles
                    </div>
                    <asp:Image ID="lblPhoto" runat="server" Style="width: 1100px; height: 500px;" />
                </div>

            </div>
        </div>

        <%--            </ItemTemplate>
        </asp:ListView>--%>
    </div>

</asp:Content>
