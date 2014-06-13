<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="ASPX_HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/MainCSS.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <nav class="navbar navbar-default col-md-8 col-md-offset-2" role="navigation">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">SurveyPortal</a>
                </div> 

                <!-- Collect the nav links, forms, and other content for toggling -->

                <ul class="nav navbar-nav">
                    <li class="active"><a href="#">Home</a></li>
                    <li><a href="#">New Survey</a></li>
                </ul>

                <div class="navbar-header pull-right">
                    <p class="navbar-text pull-right">Signed in as Batman</p>
                    <button type="button" class="btn btn-default navbar-btn pull-right">Sign in</button>
                    <button type="button" class="btn btn-default navbar-btn pull-right">Change Password</button>
                </div>
                </div>
                <!-- /.container-fluid -->
        </nav>
        
    <div class="jumbotron col-md-8 col-md-offset-2">
        <h1>Hello, and welcome to SurveyPortal</h1>
        <p>A place to create Surveys for your Company, hobbies and other..</p>
    </div>

    <div class="col-md-8 col-md-offset-2">
        <p class="lead">Filler Text</p>
        <br />
        <br />
        <p class="lead"> More Filler Text</p>
    </div>
    
    </div>
    </form>
</body>
</html>
