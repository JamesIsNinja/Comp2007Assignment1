<!--
    James White, 200203355
    May 23rd, 2015
    This file is the default webpage, takes info from the master page, and has all the game objects.
    -->


<%@ Page Title="" Language="C#" MasterPageFile="~/WebPageMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="assignment1._default" %>
<!-- Info for UC1, game.ascx-->
<%@ Register Src="~/game.ascx" TagPrefix="uc1" TagName="game" %>
<!-- Place holder for the head -->
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<!--Area for main content-->
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Area for each of 4 games -->
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
    <!-- End of game area -->
    <br />
    <!-- Submit button, and error label for when they submit centered -->
    <div class="container text-center">
    <asp:Button ID="btnSubmit" runat="server" Text="Calculate Totals" OnClick="btnSubmit_Click" class="btn btn-primary btn-lg"/>
        </div>
        <div class="container text-center" style="color:red;">
    <asp:Label ID="lblSubmitWarning" runat="server"></asp:Label><br />
            </div>
    <!-- End of submit, and error label -->
    <!-- Area for displaying results-->
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
    <!--End of displayed results-->
</asp:Content>
<!--End of Content-->
