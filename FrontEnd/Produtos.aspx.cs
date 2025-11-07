using System;
using System.Threading.Tasks;
using System.Web.UI;

namespace FrontEnd
{
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // registra a tarefa assíncrona para o ciclo da página
                Page.RegisterAsyncTask(new PageAsyncTask(CarregarProdutosAsync));
            }
        }

        private async Task CarregarProdutosAsync()
        {
            try
            {
                var produtos = await ApiClient.GetProdutosAsync();
                gvProdutos.DataSource = produtos;
                gvProdutos.DataBind();
                lblErro.Text = "";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro ao carregar produtos: " + ex.Message;
            }
        }
    }
}
