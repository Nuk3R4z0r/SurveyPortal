<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="ASPX_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <br />
    <br />

    <div class="col-md-4 col-md-offset-4">
        <div class="panel panel-default">
            <div class="panel-heading">Register</div>
            <div class="panel-body">

                <div class="form-group">
                    <label for="Email">Email address</label>
                    <asp:TextBox runat="server" type="email" class="form-control" id="emailBox" placeholder="Enter email"/>
                </div>

                <div class="form-group">
                    <label for="Password">Password</label>
                    <asp:TextBox runat="server" type="password" class="form-control" id="passBox" placeholder="Enter password"/>
                </div>
                <div class="form-group">
                    <label for="Password">Re-enter Password</label>
                    <asp:TextBox runat="server" type="password" class="form-control" id="confirmBox" placeholder="Enter password"/>
                </div>

                <asp:Button runat="server" type="submit" OnClick="btnSubmit_Click" ID="btnSubmit" class="btn btn-default" Text="Submit"/>
                <asp:Button runat="server" type="submit" OnClick="btnCancel_Click" class="btn btn-default" ID="btnCancel" Text="Cancel"/>
                <asp:Label id="statusLabel" runat="server"/>
                <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
                <script src="js/bootstrap.min.js"></script>
            </div>
        </div>
        </div>
    </div>
    </form>
</body>
</html>
