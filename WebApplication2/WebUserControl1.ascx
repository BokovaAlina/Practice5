<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication2.WebUserControl1" %>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Result" runat="server"></asp:Label>
&nbsp;<p>
    &nbsp;</p>
<asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="+" />
&nbsp;
<asp:Button ID="Sub" runat="server" OnClick="Sub_Click" Text="-" />
&nbsp;
<asp:Button ID="Mult" runat="server" OnClick="Mult_Click" Text="*" />
&nbsp;
<asp:Button ID="Div" runat="server" OnClick="Div_Click" Text="/" />
&nbsp;<p>
    &nbsp;</p>

