<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="Site.Pages.Pesquisa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pesquisa</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Pesquisa de Produtos</h3>

        Selecione o Fornecedor:
        <asp:DropDownList ID="ddlFornecedor" runat="server" 
            OnSelectedIndexChanged="PesquisarProdutos"
            AutoPostBack="True" />
        
        <asp:GridView ID="gridProdutos" runat="server" Width="80%" />

        <p>
            <asp:Label ID="lblMensagem" runat="server" />
        </p>
    </div>
    </form>
</body>
</html>
