<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="Paiement.aspx.cs" Inherits="AFPABNB.EspaceClient.Paiement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">

        <asp:ListView ID="gdvReserver" runat="server">
            <ItemTemplate>

                <div class="row">
                    <div class="col-9">

                        <div class="card">
                            <div class="card-body">

                                <h4 class="mb-3">Moyen de Paiement</h4>

                                <ul class="nav bg-light nav-pills rounded nav-fill mb-3" role="tablist">
                                    <li class="nav-item">
                                        <a class="nav-link active" data-toggle="pill" href="#nav-tab-card">
                                            <i class="fa fa-credit-card"></i> Carte Bancaire</a></li>
                                    <li class="nav-item">
                                        <a class="nav-link" data-toggle="pill" href="#nav-tab-paypal">
                                            <i class="fab fa-paypal"></i> Paypal</a></li>
                                    <li class="nav-item">
                                        <a class="nav-link" data-toggle="pill" href="#nav-tab-bank">
                                            <i class="fa fa-university"></i> Compte Bancaire</a></li>
                                </ul>

                                <div class="tab-content">
                                    <div class="tab-pane fade show active" id="nav-tab-card">
                                        <form role="form">
                                            <div class="form-group">
                                                <label for="username">Nom complet</label>
                                                <input type="text" class="form-control" name="username" placeholder="" required="" value="ANASTASI Bruno">
                                            </div>
                                            <!-- form-group.// -->

                                            <div class="form-group">
                                                <label for="cardNumber">Numéro de carte</label>
                                                <div class="input-group">
                                                    <input type="text" class="form-control" name="cardNumber" placeholder="" value="0000-0000-0000-0000">
                                                    <div class="input-group-append">
                                                        <span class="input-group-text text-muted">
                                                            <i class="fab fa-cc-visa"></i><i class="fab fa-cc-amex"></i>
                                                            <i class="fab fa-cc-mastercard"></i>
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- form-group.// -->

                                            <div class="row">
                                                <div class="col-sm-8">
                                                    <div class="form-group">
                                                        <label><span class="hidden-xs">Date d'expiration</span> </label>
                                                        <div class="input-group">
                                                            <input type="number" class="form-control" placeholder="MM" name="" value="01">
                                                            <input type="number" class="form-control" placeholder="YY" name="" value="2020">
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class="col-sm-4">
                                                    <div class="form-group">
                                                        <label data-toggle="tooltip" title="" data-original-title="3 digits code on back side of the card">CVV <i class="fa fa-question-circle"></i></label>
                                                        <input type="number" class="form-control" required="" value="000">
                                                    </div>
                                                    <!-- form-group.// -->
                                                </div>
                                            </div>
                                            <!-- row.// -->
                                            <button class="btn btn-primary btn-lg btn-block" type="button">Payer</button>
                                        </form>
                                    </div>
                                    <!-- tab-pane.// -->
                                    <div class="tab-pane fade" id="nav-tab-paypal">
                                        <p>Paypal est le moyen le plus simple de payer en ligne.</p>
                                        <p>
                                            <button type="button" class="btn btn-primary"><i class="fab fa-paypal"></i>Se connecter à Paypal </button>
                                        </p>
                                    </div>
                                    <div class="tab-pane fade" id="nav-tab-bank">
                                        <p>Informations Bancaire :</p>
                                        <dl class="param">
                                            <dt>BANK: </dt>
                                            <dd>THE WORLD BANK</dd>
                                        </dl>
                                        <dl class="param">
                                            <dt>Accaunt number: </dt>
                                            <dd>12345678912345</dd>
                                        </dl>
                                        <dl class="param">
                                            <dt>IBAN: </dt>
                                            <dd>123456789</dd>
                                        </dl>
                                    </div>
                                    <!-- tab-pane.// -->
                                </div>
                                <!-- tab-content .// -->

                                <hr class="mb-4" />

                                <h3 class="card-title"><%#Eval("Nom") %></h3>
                                <span class="badge badge-pill badge-secondary"><%#Eval("Adresse.Numero") %> <%#Eval("Adresse.Voie") %> - <%#Eval("Adresse.CodePostal") %> <%#Eval("Adresse.Ville") %></span>
                                <span class="badge badge-pill badge-warning"><%#Eval("Reservation.Prix") %> €</span>
                                <p class="card-text"><%#Eval("Description") %></p>
                                <span class="text-warning">★ ★ ★ ★ ☆</span>
                                4.0 étoiles
                            </div>
                            <img class="card-img-bottom img-fluid" src='../Images/<%#Eval("Photo") %>' alt="" style="width: 1200px; height: 500px;">
                        </div>

                    </div>
                    <div class="col-3">

                        <h4 class="d-flex justify-content-between align-items-center mb-3">
                            <span class="text-muted">Votre Panier</span>
                            <span class="badge badge-secondary badge-pill">1</span>
                        </h4>

                        <ul class="list-group mb-3">
                            <li class="list-group-item d-flex justify-content-between lh-condensed">
                                <div>
                                    <h6 class="my-0"><%#Eval("Nom") %></h6>
                                </div>
                                <span class="text-muted"><%#Eval("Reservation.Prix") %> €</span>
                            </li>

                            <li class="list-group-item d-flex justify-content-between">
                                <span>Total (EUR)</span>
                                <strong><%#Eval("Reservation.Prix") %> €</strong>
                            </li>
                        </ul>

                        <div class="list-group">
                            <a href="../EspaceClient/Reservation.aspx" class="list-group-item list-group-item-action">
                                <button class="btn btn-outline-secondary btn-md btn-block" type="button">Retour</button>
                            </a>

                        </div>

                    </div>
                </div>

            </ItemTemplate>
        </asp:ListView>

    </div>

</asp:Content>
