<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UpdatePanel_Exemplo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="scpManager" runat="server"></asp:ScriptManager>

        <asp:Button ID="btnAtualizarParcial" runat="server" Text="Atualizar Paineis" OnClick="Atualizar_Click" />
        <asp:Button ID="btnAtualizarGeral" runat="server" Text="Atualizar Pagina" OnClick="Atualizar_Click" />

        <!-- Update Panel 1 -->
        <asp:UpdatePanel ID="updPainel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="false">
            <ContentTemplate>
                <asp:TextBox ID="txtPainel1" runat="server"></asp:TextBox>
                <asp:Button ID="btnPainel1" runat="server" Text="Painel 1" OnClick="Painel1_Click" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="btnAtualizarParcial" EventName="Click" />
                <asp:PostBackTrigger ControlID="btnAtualizarGeral" />
            </Triggers>
        </asp:UpdatePanel>
        <!-- Update Panel 2 -->
        <asp:UpdatePanel ID="updPainel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:TextBox ID="txtPainel2" runat="server"></asp:TextBox>
                <asp:Button ID="btnPainel2" runat="server" Text="Painel 2" OnClick="Painel2_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- Update Panel 3 -->
        <asp:UpdatePanel ID="updPainel3" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="txtPainel3" runat="server"></asp:TextBox>
                <asp:Button ID="btnPainel3" runat="server" Text="Painel 3" OnClick="Painel3_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>

    </form>
</body>
</html>
