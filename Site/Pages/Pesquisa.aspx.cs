using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Pesquisa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (! IsPostBack)
                CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            try
            {
                var d = new FornecedorDal();

                ddlFornecedor.DataSource = d.SelectAll(); //popular
                ddlFornecedor.DataValueField = "idFornecedor"; //valor do campo
                ddlFornecedor.DataTextField = "Nome"; //texto do campo
                ddlFornecedor.DataBind(); //exibir

                //Adicionar um Elemento Default:
                ddlFornecedor.Items.Insert(0, new ListItem(" - Escolha uma Opção -"));
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
                throw;
            }
        }


        protected void PesquisarProdutos(object sender, EventArgs e)
        {
            try
            {
                var d = new ProdutoDal();

                int idFornecedor = Convert.ToInt32(ddlFornecedor.SelectedValue);

                //Executar a consulta:
                gridProdutos.DataSource = d.SelectByFornecedor(idFornecedor);
                gridProdutos.DataBind(); //exibir
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}