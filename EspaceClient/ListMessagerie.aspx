<%@ Page Title="" Language="C#" MasterPageFile="~/EspaceClient/EspaceClient.Master" AutoEventWireup="true" CodeBehind="ListMessagerie.aspx.cs" Inherits="AFPABNB.EspaceClient.Messageries" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<%--            <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" >
    <link rel="stylesheet" href="http://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css" >
       <style>/* CSS used here will be applied after bootstrap.css */

.nav-tabs .glyphicon:not(.no-margin) { margin-right:10px; }
.tab-pane .list-group-item:first-child {border-top-right-radius: 0px;border-top-left-radius: 0px;}
.tab-pane .list-group-item:last-child {border-bottom-right-radius: 0px;border-bottom-left-radius: 0px;}
.tab-pane .list-group .checkbox { display: inline-block;margin: 0px; }
.tab-pane .list-group input[type=&quot;checkbox&quot;]{ margin-top: 2px; }
.tab-pane .list-group .glyphicon { margin-right:5px; }
.tab-pane .list-group .glyphicon:hover { color:#FFBC00; }
a.list-group-item.read { color: #222;background-color: #F3F3F3; }
hr { margin-top: 5px;margin-bottom: 10px; }
.nav-pills>li>a {padding: 5px 10px;}

.ad { padding: 5px;background: #F5F5F5;color: #222;font-size: 80%;border: 1px solid #E5E5E5; }
.ad a.title {color: #15C;text-decoration: none;font-weight: bold;font-size: 110%;}
.ad a.url {color: #093;text-decoration: none;}</style>

    <div class="container">
    <div class="row">
        <div class="col-sm-9 col-md-10">
          <h1>THD Inbox View</h1>
        </div>
    </div>
    <hr class="">
    <div class="row">
        <div class="col-sm-3 col-md-2"> <a href="#" class="btn btn-danger btn-sm btn-block" role="button"><i class="glyphicon glyphicon-edit"></i> THD Inbox </a> 
            <hr class="">
                <ul class="nav nav-pills nav-stacked">
                    <li class="active"><a href="#" class=""><span class="badge pull-right">32</span> Inbox </a>

                    </li>
                    <li><a href="#" class=""><span class="badge pull-right">15</span>In progress</a>

                    </li>
                    <li><a href="#" class=""><span class="badge pull-right">10</span>P1 Priority</a>

                    </li>
                    <li><a href="#" class=""><span class="badge pull-right">4</span>AOG</a>

                    </li>
                    <li><a href="#" class=""><span class="badge pull-right">3</span>Breached</a>

                    </li>
                </ul>
        </div>
        <div class="col-sm-9 col-md-10">
            <!-- Nav tabs -->
            <ul class="nav nav-tabs">
                <li class="active"><a href="#home" data-toggle="tab" class=""><span class="glyphicon glyphicon-inbox">
                </span>C - Series</a>

                </li>
                <li><a href="#profile" data-toggle="tab" class=""><span class="glyphicon glyphicon-user"></span>
                    CRC</a>

                </li>
                <li><a href="#messages" data-toggle="tab" class=""><span class="glyphicon glyphicon-tags"></span>
                    Q - series</a>

                </li>
                <li><a href="#settings" data-toggle="tab" class=""><span class="glyphicon glyphicon-plus no-margin">
                </span></a>

                </li>
            </ul>
            <!-- Tab panes -->
            <div class="tab-content">
                <div class="tab-pane fade in active" id="home">
                    <div class="list-group"> <a href="#" class="list-group-item">
                            <div class="checkbox">
                                <label class="">
                                    <input type="checkbox" class="">
                                </label>
                            </div>
                            <span class="glyphicon glyphicon-star-empty"></span><span class="name" style="min-width: 120px;
                                display: inline-block;">Mark Otto</span> <span class="">Nice work on the lastest version</span>
                            <span class="text-muted" style="font-size: 11px;">- More content here</span> <span class="badge">12:10 AM</span> <span class="pull-right"><span class="glyphicon glyphicon-paperclip">
                                </span></span></a><a href="#" class="list-group-item">
                                    <div class="checkbox">
                                        <label class="">
                                            <input type="checkbox" class="">
                                        </label>
                                    </div>
                                    <span class="glyphicon glyphicon-star-empty"></span><span class="name" style="min-width: 120px;
                                        display: inline-block;">Jason Markus</span> <span class="">This is big title</span>
                                    <span class="text-muted" style="font-size: 11px;">- I saw that you had..</span> <span class="badge">12:09 AM</span> <span class="pull-right"><span class="glyphicon glyphicon-paperclip">
                                        </span></span></a><a href="#" class="list-group-item read">
                                            <div class="checkbox">
                                                <label class="">
                                                    <input type="checkbox" class="">
                                                </label>
                                            </div>
                                            <span class="glyphicon glyphicon-star"></span><span class="name" style="min-width: 120px;
                                                display: inline-block;">Jane Patel</span> <span class="">This is big title</span>
                                            <span class="text-muted" style="font-size: 11px;">- Hi hello how r u ?</span> <span class="badge">11:30 PM</span> <span class="pull-right"><span class="glyphicon glyphicon-paperclip">
                                                </span></span></a>

                    </div>
                </div>
                <div class="tab-pane fade in" id="profile">
                    <div class="list-group">
                        <div class="list-group-item"> <span class="text-center">No Cases in the Queue.</span>

                        </div>
                    </div>
                </div>
                <div class="tab-pane fade in" id="messages">...</div>
                <div class="tab-pane fade in" id="settings">No Cases in the Queue.</div>
            </div>
        </div>
    </div>
</div>--%>

    <div class="container">
        Desti<br />
        <asp:TextBox ID="txtDestinataire" runat="server"></asp:TextBox><br />
        Message<br />
        <asp:TextBox ID="txtMessages" runat="server"></asp:TextBox><br />
        Date<br />
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox><br />

        <asp:Button ID="Button1" runat="server" Text="Envoyer" OnClick="btnAddMessage_Click" />
    </div>

    <asp:GridView ID="gdvMessagerie" runat="server"></asp:GridView>

<%--    <asp:ListView ID="lvwMessagerie" runat="server">
        <ItemTemplate>

            <%#Eval("Messages") %>

        </ItemTemplate>

    </asp:ListView>--%>

</asp:Content>
