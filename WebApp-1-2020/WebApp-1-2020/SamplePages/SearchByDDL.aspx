﻿<%@ Page Title="Filter Search!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchByDDL.aspx.cs" Inherits="WebApp_1_2020.SamplePages.SearchByDDL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Search Albums By Artist</h1>
    <div class="row">
        <asp:Label ID="Label1" runat="server" 
            Text="Select An artist"></asp:Label> &nbsp; &nbsp; 

        <asp:DropDownList ID="ArtistList" runat="server"></asp:DropDownList> &nbsp; &nbsp; 
        <asp:LinkButton ID="SearchAlbums" runat="server">Search For Albums!</asp:LinkButton>
    </div>
    <br /> <br />

        <div class="row">
            <asp:Label ID="MessageLabel" runat="server"></asp:Label>
     </div>
</asp:Content>
