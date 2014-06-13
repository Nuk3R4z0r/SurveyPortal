<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CreateSurvey.aspx.cs" Inherits="ASPX_CreateSurvey" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
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
        <div style="float:left; width:59%; " class="col-md-offset-5">
            <asp:PlaceHolder ID="plcDiv" runat="server">
            </asp:PlaceHolder>
        </div>
    </asp:Content>