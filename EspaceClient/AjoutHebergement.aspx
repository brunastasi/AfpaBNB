<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="AjoutHebergement.aspx.cs" Inherits="AFPABNB.EspaceClient.AjoutHebergement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <div class="row">
            <div class="col-md-3">

                <div class="list-group">
                    <a href="Compte.aspx" class="list-group-item list-group-item-action">Mon Compte
                    </a>
                    <a href="Favoris.aspx" class="list-group-item list-group-item-action">Mes Favoris</a>
                    <a href="Reservation.aspx" class="list-group-item list-group-item-action">Mes Reservations</a>
                    <a href="AjoutHebergement.aspx" class="list-group-item list-group-item-action act active">Ajouter un Hebergement</a>
                    <a href="#" class="list-group-item list-group-item-action">Messagerie</a>
                </div>

            </div>
            <div class="col-md-9">

                <div class="card">
                    <header class="card-header">
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
                                <%--                                <div class="col form-group">
                                    <label>Photo</label>
                                    <asp:TextBox ID="txtPhoto" runat="server" type="text" class="form-control" placeholder="Nom" value="images/appart2.jpg"></asp:TextBox>
                                </div>--%>

                                <div class="col form-group">
                                    <label>Photo</label>
                                    <br />
                                    <asp:FileUpload ID="filePhoto" runat="server" />
                                    <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" />
                                    <br />
                                    <br />
                                    <asp:Label runat="server" ID="StatusLabel" Text="" />
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
                            <hr />
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

                            <!-- form-group// -->
                        </form>
                    </article>
                    <!-- card-body end .// -->
                    <div class="border-top card-body text-center">
                        <asp:Button ID="Button1" runat="server" Text="Ajouter" class="btn btn-primary btn-block" OnClick="AddHebergement_Click" />
                    </div>
                </div>
                <!-- card.// -->

            </div>
        </div>
    </div>
</asp:Content>
