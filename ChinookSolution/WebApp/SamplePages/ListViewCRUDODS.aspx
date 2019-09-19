<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListViewCRUDODS.aspx.cs" Inherits="WebApp.SamplePages.ListViewCRUDODS" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>List View ODS CRUD</h1>
    <blockquote class="alert alert-info">
        This page will review demostrate a CRUD process using the list view control and only ODS datascoure
    </blockquote>
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

 <asp:ListView ID="AlbumList" runat="server"></asp:ListView>


    <asp:ObjectDataSource ID="AlbumListODS" runat="server"></asp:ObjectDataSource>

   

</asp:Content>
