﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="StylingContent.AddEvent" %>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
    <link rel="stylesheet"  href="/Styles/Page.css" type="text/css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="error" id="errorDiv" runat="server"></div>
    <div class="standardDiv">
        <div class="columnDiv elementDiv">
            <p>Month:</p>
            <p>Day:</p>
            <p>Year:</p>
            <p>Athlete</p>
        </div>
        <div class="columnDiv elementDiv">
            <p>
                <select id="monthSelect" runat="server" />
            </p>
            <p>
                <input type="text" id="dayInput" runat="server" />
            </p>
            <p>
                <input type="text" id="yearInput" runat="server" />
            </p>
            <p>
                <select id="athleteSelect" runat="server" />
            </p>
        </div>
    </div>
    <div class="standardDiv">
        <div class="columnDiv elementDiv">
            <p>Event Type:</p>
            <p>Swim:</p>
            <p>Cycle:</p>
            <p>Run:</p>
        </div>
        <div class="columnDiv elementDiv">
            <p>
                <select id="eventTypeSelect" runat="server" />
            <p>
                <input type="text" id="swimTimeInput" runat="server" placeholder="00:35:33" />
            </p>
            <p>
                <input type="text" id="cycleTimeInput" runat="server" placeholder="00:35:57" />
            </p>
            <p>
                <input type="text" id="runTimeInput" runat="server" placeholder="00:21:20" />
            </p>
        </div>
    </div>
    <div class="clear" style="text-align: center">
        <p>
           <input type="submit" value="Add" />
        </p>
    </div>
</asp:Content>
