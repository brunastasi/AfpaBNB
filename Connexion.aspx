<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Connexion.aspx.cs" Inherits="AFPABNB.Connexion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row justify-content-center align-items-center">
            <div class="col-md-5">
                <form action="" autocomplete="off">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="card-title mt-2">Connexion</h4>
                        </div>
                        <div class="card-body">

                            <asp:Label ID="lblMessage" runat="server"></asp:Label>

                            <div class="form-group">
                                <label for="login">Login</label>
                                <asp:TextBox ID="txtLogin" runat="server" type="text" class="form-control" placeholder="Login" value="anastasi" Style="height: 100%"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="password">Mot de passe</label>
                                <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control" placeholder="Password" value="anastasi"></asp:TextBox>
                            </div>

                            <asp:Button ID="btnValider" runat="server" Text="Valider" class="btn btn-primary" OnClick="btnValider_Click" />

                        </div>
                        <div class="card-footer">
                            <asp:HyperLink ID="HyperLink1" runat="server" href="/inscription">Crée mon compte</asp:HyperLink>
                        </div>
                    </div>
                </form>
            </div>

        </div>
    </div>

</asp:Content>
