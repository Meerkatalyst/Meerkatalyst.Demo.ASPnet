﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Meerkatalyst.Demo.ASPnet
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Meerkatalyst.Demo.ASPnet - Different heading</h1>
    <h2><%= Html.Encode(ViewData["Message"]) %></h2>
</asp:Content>
