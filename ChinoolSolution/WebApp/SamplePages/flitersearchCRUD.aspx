﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="flitersearchCRUD.aspx.cs" Inherits="WebApp.Single_page.flitersearchCRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Review Basic CRUD</h1>
    <div class ="row">
        <div class="col-sm-offset3"></div>
        <asp:Label ID="Label1" runat="server" Text="Slect an artist to view Albums"></asp:Label> &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="AtistList" runat="server"></asp:DropDownList>
    </div>
</asp:Content>
