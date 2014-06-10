<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="content/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server" role="form">
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
            </div>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
