<%@ Page Title="" Language="C#" MasterPageFile="~/WebPageMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="assignment1._default" %>

<%@ Register Src="~/game.ascx" TagPrefix="uc1" TagName="game" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="row">
    <div class="col-md-3">
     <uc1:game runat="server" id="game" />
            </div>
    <div class="col-md-3">
    <uc1:game runat="server" ID="game1" />
        </div>
    <div class="col-md-3">
    <uc1:game runat="server" ID="game2" />
        </div>
    <div class="col-md-3">
    <uc1:game runat="server" ID="game3" />
        </div>
       </div>
    <br />
    <div class="container text-center">
    <asp:Button ID="btnSubmit" runat="server" Text="Calculate Totals" OnClick="btnSubmit_Click" class="btn btn-primary btn-lg"/>
        </div>
        <div class="container text-center" style="color:red;">
    <asp:Label ID="lblSubmitWarning" runat="server"></asp:Label><br />
            </div>
    <div class="container text-center">
      <asp:Label ID="lblResults" runat="server" Visible="false" Text="Results: " Font-Bold="true"></asp:Label><br />
        <asp:Label ID="lblWins" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblLosses" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblWinPercent" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblPointScored" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblPointAllowed" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblPointDiff" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblTotalAtt" runat="server" Visible="false"></asp:Label><br />
        <asp:Label ID="lblAvgAtt" runat="server" Visible="false"></asp:Label><br />
    </div><br />
</asp:Content>
