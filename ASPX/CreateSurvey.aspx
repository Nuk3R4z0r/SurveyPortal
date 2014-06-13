<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateSurvey.aspx.cs" Inherits="ASPX_CreateSurvey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap 101 Template</title>

    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        html,body{ height:98%;}
    </style>
</head>
<body>
    <form id="form1" runat="server" style="width:100%; height:100%">
        <div style="float:left; width:350px; height:inherit; position:fixed" class="panel panel-default">
            <div class="col-md-12">
                <div class="panel-body">
                    <div class="form-group">
                        <asp:TextBox runat="server" class="form-control" id="propBox" placeholder="Enter property"/>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" OnClick="btnSect_Click" class="btn btn-default" ID="btnSect" Text="New Section"/>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" OnClick="btnRadio_Click" class="btn btn-default" ID="btnRadio" Text="New Radiobutton"/>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" OnClick="btnBox_Click" class="btn btn-default" ID="btnBox" Text="New Textbox"/>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" OnClick="btnDelete_Click" class="btn btn-default" ID="btnSave" Text="Save & Exit"/>
                    </div>
                </div>
            </div>
        </div>
        <div style="float:left; width:74%; " class="col-md-offset-3">
            <asp:PlaceHolder ID="plcDiv" runat="server">
            </asp:PlaceHolder>
        </div>
    </form>

    

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
