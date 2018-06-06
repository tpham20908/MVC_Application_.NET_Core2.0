<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Investment_Calculator.Default" %>

<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 250px;
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            width: 250px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton ="btnCalculate" defaultfocus="txtName">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="2">
                        <uc1:Header ID="Header1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Name</strong></td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Investment</strong></td>
                    <td>
                        <asp:DropDownList ID="ddlInvest" runat="server" Height="20px" Width="202px">
                        </asp:DropDownList>
                    &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Annual interest rate</strong></td>
                    <td>
                        <asp:TextBox ID="txtRate" runat="server" Width="200px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="rfVRate" runat="server" ControlToValidate="txtRate" Display="Dynamic" ErrorMessage="Interest rate is required" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvRate" runat="server" ControlToValidate="txtRate" Display="Dynamic" ErrorMessage="Interest rate has to be between 1  &amp; 20" Font-Bold="True" ForeColor="Red" MaximumValue="20" MinimumValue="1" SetFocusOnError="True" Type="Double">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"><strong>Number of years</strong></td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtYears" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvYears" runat="server" ControlToValidate="txtYears" Display="Dynamic" ErrorMessage="Please enter the number of years" Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cvYears" runat="server" ControlToValidate="txtYears" Display="Dynamic" ErrorMessage="Please enter a number (No decimals)" Font-Bold="True" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnClear" runat="server" Text="Clear" Width="100px" OnClick="btnClear_Click" />
                    </td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" ForeColor="#0066CC" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblResult" runat="server" Font-Bold="True" Font-Names="Centaur" Font-Size="X-Large" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
