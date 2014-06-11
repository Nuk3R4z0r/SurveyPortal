<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateSurvey.aspx.cs" Inherits="ASPX_CreateSurvey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div class="col-md-5">
        <div>
            <label for="questionOne"> Question 1</label>
            <div class="panel panel-default">
                <div class="panel-body">
                   TestTestTestTest
                </div>
            </div>
            <input type="text" class="form-control" id="questionone" placeholder="Enter Answer" />
        </div>

        <br />
        <br />
        <asp:Button ID="Createbtn" runat="server" Text="Add Question" class="btn btn-default" OnClick="Createbtn_Click"/>

        <asp:PlaceHolder runat="server" id="New_Question">

        </asp:PlaceHolder>

        <asp:Label runat="server" ID="testlabel" >

        </asp:Label>

    </div>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>
