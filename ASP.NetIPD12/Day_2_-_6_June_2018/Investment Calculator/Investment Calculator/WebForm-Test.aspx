<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm-Test.aspx.cs" Inherits="Investment_Calculator.WebForm_Test" %>

<%@ Register src="UserControls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Header ID="Header1" runat="server" />
        </div>
    </form>
    <p>
        This is new test form</p>
</body>
</html>
