<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="User_Information.Index" Title="User Information" ErrorPage="Error.html" %>

<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="UserControls/Footer.ascx" tagname="Footer" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 83%;
        }
        .auto-style2 {
            width: 128px;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            width: 128px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 128px;
            height: 31px;
        }
        .auto-style8 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnSubmit">

        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <uc1:Header ID="Header1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Name is a required field" Font-Bold="True" Font-Size="X-Large" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">Date of Birth</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtDOB" runat="server" Width="200px" TextMode="Date"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDOB" Display="Dynamic" ErrorMessage="Date of birth is a required field" Font-Bold="True" Font-Size="X-Large" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDOB" ErrorMessage="Not a valid date format" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Email</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtEmail" runat="server" Width="200px" TextMode="Email"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email is a required field" Font-Bold="True" Font-Size="X-Large" ForeColor="Red">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Not a valid email format" Font-Bold="True" Font-Size="X-Large" ForeColor="#006600" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Province</td>
                    <td>
                        <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" Height="25px" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged" Width="200px">
                            <asp:ListItem>Please select a province</asp:ListItem>
                            <asp:ListItem>Quebec</asp:ListItem>
                            <asp:ListItem>Ontario</asp:ListItem>
                            <asp:ListItem>BC</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlProvince" Display="Dynamic" ErrorMessage="Please select a province" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" InitialValue="Please select a province">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City</td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server" Height="25px" Width="200px">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ddlCity" Display="Dynamic" ErrorMessage="RequiredFieldValidator" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" InitialValue="Please select a city">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Red" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" Width="250px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Label ID="lblRecord" runat="server" Font-Bold="True" Font-Italic="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ListBox ID="lbRecords" runat="server" Width="459px"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </div>
        <input type="hidden" id="hidVal" name="hidVal" runat="server" value="0" /> 
        <uc2:Footer ID="Footer1" runat="server" />
    </form>
</body>
</html>
