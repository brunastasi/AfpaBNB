<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="Compte.aspx.cs" Inherits="AFPABNB.EspaceClient.Compte" %>

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
                <div class="jumbotron">
                    <h1 class="display-4">Hello, world!</h1>
                    <p class="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
                    <hr class="my-4">
                    <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
                    <a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
