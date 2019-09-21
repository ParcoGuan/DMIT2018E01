﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListViewCRUDODS.aspx.cs" Inherits="WebApp.SamplePages.ListViewCRUDODS" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>List View ODS CRUD</h1>
    <blockquote class="alert alert-info">
        This page will review demostrate a CRUD process using the list view control and only ODS datascoure
    </blockquote>
    <uc1:MessageUserControl runat="server" ID="MessageUserControl" />

    <asp:ListView ID="AlbumList" runat="server" DataSourceID="AlbumListODS" InsertItemPosition="LastItem" DataKeyNames="AlbumId">
        <AlternatingItemTemplate>
            <tr style="background-color: #FFFFFF; color: #284775;">
                <td>
                    <asp:Button runat="server" CommandName="Delete" Text="Remove" ID="DeleteButton"  OnClientClick ="return confirm('Are you sure you want to remove')"/>
                    <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("AlbumId") %>' runat="server" ID="AlbumIdLabel"  Width="50px" Enabled ="false" /></td>
                <td>
                    <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td>
                    
                    <asp:DropDownList ID="ArtistList" runat="server" 
                        DataSourceID="ArtistListODS" DataTextField="Name" 
                        DataValueField="ArtistId" SelectedValue='<%# Eval("ArtistId") %>' Enabled="false" Width="300px" >

                    </asp:DropDownList>

                </td>
                <td>
                    <asp:Label Text='<%# Eval("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel"  Width="50px"/></td>
                <td>
                    <asp:Label Text='<%# Eval("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>
                
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <asp:RequiredFieldValidator ID="RequiredvalidtexttboxE" runat="server" ErrorMessage="title is Required" Display ="None" ControlToValidate ="TitleTextBoxE" ValidationGroup ="Egroup"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RevalidtexttboxE" runat="server" ErrorMessage="title is limited to 160 charater" Display ="None"
                 ControlToValidate ="TitleTextBoxE" ValidationGroup ="Egroup" ValidationExperssion=" {1,160}$"></asp:RequiredFieldValidator>
            <tr style="background-color: #999999;">
                <td>
                    <asp:Button runat="server" CommandName="Update" Text="Update" ID="UpdateButton" />
                    <asp:Button runat="server" CommandName="Cancel" Text="Cancel" ID="CancelButton" />
                </td>
                <td>
                    <asp:TextBox Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdTextBox"  Width="50px" Enabled ="false"/></td>
                <td>
                    <asp:TextBox Text='<%# Bind("Title") %>' runat="server" ID="TitleTextBoxE" /></td>
                <td>
                   
                      <asp:DropDownList ID="ArtistList" runat="server" 
                        DataSourceID="ArtistListODS" DataTextField="Name" 
                        DataValueField="ArtistId" SelectedValue='<%# Bind("ArtistId") %>' Width="300px" >
                    </asp:DropDownList>

                </td>
                <td>
                    <asp:TextBox Text='<%# Bind("ReleaseYear") %>' runat="server" ID="ReleaseYearTextBox"  Width="50px"/></td>
                <td>
                    <asp:TextBox Text='<%# Bind("ReleaseLabel") %>' runat="server" ID="ReleaseLabelTextBox" /></td>
               
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <asp:RequiredFieldValidator ID="RequiredvalidtexttboxI" runat="server" ErrorMessage="title is Required" Display ="None"
                ControlToValidate ="TitleTextBoxI" ValidationGroup ="Igroup"></asp:RequiredFieldValidator>
             <asp:RequiredFieldValidator ID="RevalidtexttboxI" runat="server" ErrorMessage="title is limited to 160 charater" Display ="None"
                 ControlToValidate ="TitleTextBoxI" ValidationGroup ="Igroup" ValidationExperssion=" {1,160}$"></asp:RequiredFieldValidator>
            <tr style="">
                <td>
                    <asp:Button runat="server" CommandName="Insert" Text="Insert" ID="InsertButton" />
                    <asp:Button runat="server" CommandName="Cancel" Text="Clear" ID="CancelButton" />
                </td>
                <td>
                    <asp:TextBox Text='<%# Bind("AlbumId") %>' runat="server" ID="AlbumIdTextBox" Width="50px" Enabled ="false"/></td>
                <td>
                    <asp:TextBox Text='<%# Bind("Title") %>' runat="server" ID="TitleTextBoxI" /></td>
                <td>
                   
                      <asp:DropDownList ID="ArtistList" runat="server" 
                        DataSourceID="ArtistListODS" DataTextField="Name" 
                        DataValueField="ArtistId" SelectedValue='<%# Bind("ArtistId") %>' Width="300px" >

                    </asp:DropDownList>
                </td>
                <td>
                    <asp:TextBox Text='<%# Bind("ReleaseYear") %>' runat="server" ID="ReleaseYearTextBox" Width="50px"/></td>
                <td>
                    <asp:TextBox Text='<%# Bind("ReleaseLabel") %>' runat="server" ID="ReleaseLabelTextBox" /></td>
                
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color: #E0FFFF; color: #333333;">
                <td>
                    <asp:Button runat="server" CommandName="Delete" Text="Remove" ID="DeleteButton"  OnClientClick ="return confirm('Are you sure you want to remove')"/>
                    <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("AlbumId") %>' runat="server" ID="AlbumIdLabel"  Width="50px" Enabled ="false"/></td>
                <td>
                    <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td>
                      <asp:DropDownList ID="ArtistList" runat="server" 
                        DataSourceID="ArtistListODS" DataTextField="Name" 
                        DataValueField="ArtistId" SelectedValue='<%# Eval("ArtistId") %>' Enabled="false" Width="300px" >

                    </asp:DropDownList>

                </td>
                <td>
                    <asp:Label Text='<%# Eval("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel" Width="50px"/></td>
                <td>
                    <asp:Label Text='<%# Eval("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>
               
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table runat="server" id="itemPlaceholderContainer" style="background-color: #FFFFFF; border-collapse: collapse; border-color: #999999; border-style: none; border-width: 1px; font-family: Verdana, Arial, Helvetica, sans-serif;" border="1">
                            <tr runat="server" style="background-color: #E0FFFF; color: #333333;">
                                <th runat="server"></th>
                                <th runat="server">Id</th>
                                <th runat="server">Title</th>
                                <th runat="server">ArtistId</th>
                                <th runat="server">Year</th>
                                <th runat="server">Label</th>
                              
                            </tr>
                            <tr runat="server" id="itemPlaceholder"></tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center; background-color: #5D7B9D; font-family: Verdana, Arial, Helvetica, sans-serif; color: #000000">
                        <asp:DataPager runat="server" ID="DataPager1">
                            <Fields>
                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True"></asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color: #E2DED6; font-weight: bold; color: #333333;">
                <td>
                    <asp:Button runat="server" CommandName="Delete" Text="Delete" ID="DeleteButton" />
                    <asp:Button runat="server" CommandName="Edit" Text="Edit" ID="EditButton" />
                </td>
                <td>
                    <asp:Label Text='<%# Eval("AlbumId") %>' runat="server" ID="AlbumIdLabel" Width="50px" Enabled ="false"/></td>
                <td>
                    <asp:Label Text='<%# Eval("Title") %>' runat="server" ID="TitleLabel" /></td>
                <td>
                    <asp:DropDownList ID="ArtistList" runat="server" 
                        DataSourceID="ArtistListODS" DataTextField="Name" 
                        DataValueField="ArtistId" SelectedValue='<%# Eval("ArtistId") %>' Enabled="false" Width="300px" >

                    </asp:DropDownList></td>
                <td>
                    <asp:Label Text='<%# Eval("ReleaseYear") %>' runat="server" ID="ReleaseYearLabel" Width="50px"/></td>
                <td>
                    <asp:Label Text='<%# Eval("ReleaseLabel") %>' runat="server" ID="ReleaseLabelLabel" /></td>
               
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>


    <asp:ObjectDataSource ID="AlbumListODS" runat="server" 
        DataObjectTypeName="ChinookSystem.Data.Entities.Album" 
        DeleteMethod="Album_Delete" 
        InsertMethod="Album_Add" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="Album_List" 
        TypeName="ChinookSystem.BLL.AlbumController" 
        UpdateMethod="Album_Update"
         OnDeleted="CheckForException"
         OnInserted="CheckForException"
         OnUpdated="CheckForException"
         OnSelected="CheckForException" >

    </asp:ObjectDataSource>

    <asp:ObjectDataSource ID="ArtistListODS" runat="server"
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="Artist_List" 
        TypeName="ChinookSystem.BLL.ArtistController"
         OnSelected="CheckForException"></asp:ObjectDataSource>

</asp:Content>
