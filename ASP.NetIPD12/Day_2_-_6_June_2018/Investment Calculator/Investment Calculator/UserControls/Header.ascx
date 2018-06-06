<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="Investment_Calculator.UserControls.Header" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 131px;
        height: 71px;
    }
    .auto-style3 {
        width: 227px;
    }
    .auto-style4 {
        width: 375px;
        font-size: xx-large;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <img alt="" class="auto-style2" src="../images/invest.jpg" /></td>
        <td class="auto-style4">Investment Calculator LLC.</td>
        <td>
            <asp:Label ID="lblDate" runat="server"></asp:Label>
        </td>
    </tr>
</table>

