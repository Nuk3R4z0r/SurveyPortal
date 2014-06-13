<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
    <br />
    <br />
    <br />
    <div class="col-md-4 col-md-offset-4">
        <div class="panel panel-default">
            <div class="panel-heading">Login</div>
            <div class="panel-body">
                    <div class="form-group">
                        <label for="exampleInputEmail1">Email address</label>
&nbsp;                  <asp:TextBox type="email" runat="server" class="form-control" id="emailBox" placeholder="Enter email"/>
                    </div>
                    <div class="form-group">
                        <label for="exampleInputPassword1">Password</label>
                        <asp:TextBox type="password" ID="passBox" runat="server" class="form-control" placeholder="Password"/>
                    </div>
                    <asp:Button ID="Button1" runat="server" OnClick="Login_Click" Text="Submit" class="btn btn-default"/>
                    <asp:Button ID="Button2" runat="server" OnClick="Register_Click" Text="Register" class="btn btn-default" style="margin-left:67 %"/>

                <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
                <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
                <!-- Include all compiled plugins (below), or include individual files as needed -->
                <script src="js/bootstrap.min.js"></script>
                    <asp:Label ID="statusLabel" runat="server"></asp:Label>
            </div>
        </div>
    </div>
    </div>
    </asp:Content>