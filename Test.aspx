<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="AFPABNB.Test" %>

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
                        <h4 class="card-title mt-2">Ajouter un Hebergement</h4>
                    </header>

                    <article class="card-body">
                        <form>
                            <div class="form-row">
                                <div class="col form-group">
                                    <label>Nom Hebergement: </label>
                                    <asp:TextBox ID="txtNomHebergement" runat="server" type="text" class="form-control" placeholder="Prenom" value="NomHebergement"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                                <div class="col form-group">
                                    <label>Photo</label>
                                 <asp:TextBox ID="txtPhoto" runat="server" type="text" class="form-control" placeholder="Nom" value="images/appart2.jpg"></asp:TextBox>
                                </div>

                                <!-- form-group end.// -->
                            </div>
                            <!-- form-row end.// -->

                            <div class="form-group">
                                <label>Type</label>
                                <asp:TextBox ID="txtType" runat="server" type="text" class="form-control" placeholder="Email" value="TypeHebergement"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->

                            <div class="form-group">
                                <label>Description</label>
                                <asp:TextBox ID="txtDescription" runat="server" type="text" class="form-control" placeholder="Type" value="Description"></asp:TextBox>
                            </div>
                            <!-- form-group end.// -->

                            <div class="form-row">
                                <div class="col form-group">
                                    <label>Nom Adresse</label>
                                    <asp:TextBox ID="txtNomAdresse" runat="server" type="text" class="form-control" placeholder="Adresse" value="NomAdresse"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                                <div class="col form-group">
                                    <label>Numero</label>
                                    <asp:TextBox ID="txtNumero" runat="server" type="text" class="form-control" placeholder="Numero" value="0606060606"></asp:TextBox>
                                </div>
                                <!-- form-group end.// -->
                            </div>
                            <!-- form-row end.// -->
                            <div class="form-group">
                                <label>Voie</label>
                                <asp:TextBox ID="txtVoie" runat="server" type="text" class="form-control" placeholder="Type" value="Voie"></asp:TextBox>
                            </div>

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
                                <asp:Button ID="btnValider" runat="server" Text="Valider" class="btn btn-primary btn-block" OnClick="AddHebergement_Click" />
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
