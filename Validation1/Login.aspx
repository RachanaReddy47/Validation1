<%@ Page Title="" Language="C#" MasterPageFile="~/MyMaster1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Validation1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Employee Id</td>
            <td><asp:TextBox ID="txtEmpid" runat="server" ClientIDMode="Static"  ></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Cannot be blank" ControlToValidate="txtEmpid"></asp:RegularExpressionValidator></td>
        </tr>

        <tr>
            <td>Password</td>
            <td>  <asp:TextBox ID="txtPswd" runat="server" TextMode="Password" ClientIDMode="Static"  ></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Cannot be blank" ControlToValidate="txtPswd"></asp:RegularExpressionValidator></td>
        </tr>

        <tr>
            <td > 
                <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td> <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/></td>
        </tr>
    </table>

</asp:Content>
