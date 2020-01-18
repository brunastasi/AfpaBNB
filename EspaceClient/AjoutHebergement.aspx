<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="AjoutHebergement.aspx.cs" Inherits="AFPABNB.EspaceClient.AjoutHebergement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <div class="row">
            <div class="col-3">

                <div class="list-group">
                    <a href="#" class="list-group-item list-group-item-action active">Mon Compte
                    </a>
                    <a href="Favoris.aspx" class="list-group-item list-group-item-action">Mes Favoris</a>
                    <a href="Reservation.aspx" class="list-group-item list-group-item-action">Mes Reservations</a>
                    <a href="#" class="list-group-item list-group-item-action">Messagerie</a>
                </div>

            </div>
            <div class="col-9">

                <div class="card">
                    <header class="card-header">
                        <a href="connexion.aspx" class="float-right btn btn-outline-primary mt-1">Connexion</a>
                        <h4 class="card-title mt-2">Inscription</h4>
                    </header>
                    <article class="card-body">
                        <form>
                            <div class="form-row">
                                <div class="col form-group">
                                    <label>Prénom </label>
                                    <asp:TextBox ID="txtPrenom" runat="server" type="text" class="form-control" placeholder="Prenom" value="Bruno"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                                <div class="col form-group">
                                    <label>Nom</label>
                                    <asp:TextBox ID="txtNom" runat="server" type="text" class="form-control" placeholder="Nom" value="ANASTASI"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                            </div>
                            <!-- form-row end.// -->

                            <div class="form-group">
                                <label>Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" type="text" class="form-control" placeholder="Email" value="abc@abc.fr"></asp:TextBox>
                                <small class="form-text text-muted">Nous ne partagerons jamais votre e-mail.</small>
                            </div>
                            <!-- form-group end.// -->

                            <div class="form-group">
                                <asp:TextBox ID="txtType" runat="server" type="text" class="form-control" placeholder="Type" value="Locataire"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->

                            <div class="form-row">
                                <div class="col form-group">
                                    <label>Numero</label>
                                    <asp:TextBox ID="txtNumero" runat="server" type="text" class="form-control" placeholder="Adresse" value="6 8"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                                <div class="col form-group">
                                    <label>Voie</label>
                                    <asp:TextBox ID="txtVoie" runat="server" type="text" class="form-control" placeholder="Téléphone" value="Rue Georges et Mai Politzer"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                            </div>
                            <!-- form-row end.// -->

                            <div class="form-row">
                                <div class="form-group col-md-6">
                                    <label>Ville</label>
                                    <asp:TextBox ID="txtVille" runat="server" type="text" class="form-control" placeholder="Ville" value="Paris"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                                <div class="form-group col-md-6">
                                    <label>Code Postal</label>
                                    <asp:TextBox ID="txtCodePostal" runat="server" type="text" class="form-control" placeholder="Code Postal" value="75012"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                            </div>
                            <!-- form-row.// -->

                            <div class="form-group">
                                <asp:TextBox ID="txtTelephone" runat="server" type="text" class="form-control" placeholder="Type" value="0632207972"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->

                            <div class="form-group">
                                <label>Login</label>
                                <asp:TextBox ID="txtLogin" runat="server" type="text" class="form-control" placeholder="Login" value="anastasi"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->

                            <div class="form-row">
                                <div class="col form-group">
                                    <label>Mot de passe</label>
                                    <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control" placeholder="Mot de passe" value="anastasi"></asp:TextBox>
                                    <small class="form-text text-muted">Nous ne vous demanderons plus jamais votre mot de passe.</small>
                                </div>
                                <!-- form-group end.// -->
                                <%--		<div class="col form-group">
			<label>Re Mot de passe</label>
            <asp:TextBox ID="txtPassword1" runat="server" type="password" class="form-control" placeholder="Re Mot de passe" value="anastasi"></asp:TextBox>
		</div> <!-- form-group end.// -->--%>
                            </div>
                            <!-- form-row end.// -->

                            <div class="form-group">
                             <%--   <asp:Button ID="btnValider" runat="server" Text="Valider" class="btn btn-primary btn-block" OnClick="btnCreate_Click" />--%>
                            </div>
                            <!-- form-group// -->
                            <small class="text-muted">En cliquant sur le bouton "S'inscrire" vous confirmez que vous acceptez nos
                            <br />
                                conditions d'utilisation et notre politique de confidentialité.</small>
                        </form>
                    </article>
                    <!-- card-body end .// -->
                    <div class="border-top card-body text-center">Déjà un compte? <a href="connexion.aspx">Connexion</a></div>
                </div>
                <!-- card.// -->

            </div>
        </div>
    </div>
</asp:Content>
