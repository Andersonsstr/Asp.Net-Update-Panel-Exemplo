using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UpdatePanel_Exemplo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  Response.Write("Criei um Post Back! :D");
        }

        protected void Atualizar_Click(object sender, EventArgs e)
        {
            txtPainel1.Text = "Botão quem atualizou";
            txtPainel2.Text = "Botão quem atualizou";
            txtPainel3.Text = "Botão quem atualizou";
        }

        protected void Painel1_Click(object sender, EventArgs e)
        {
            txtPainel1.Text = "Painel 1 quem atualizou";
            txtPainel2.Text = "Painel 1 quem atualizou";
            txtPainel3.Text = "Painel 1 quem atualizou";
        }

        protected void Painel2_Click(object sender, EventArgs e)
        {
            txtPainel1.Text = "Painel 2 quem atualizou";
            txtPainel2.Text = "Painel 2 quem atualizou";
            txtPainel3.Text = "Painel 2 quem atualizou";
        }

        protected void Painel3_Click(object sender, EventArgs e)
        {
            txtPainel1.Text = "Painel 3 quem atualizou";
            txtPainel2.Text = "Painel 3 quem atualizou";
            txtPainel3.Text = "Painel 3 quem atualizou";

            updPainel1.Update();
        }

        /*Resultados
            Ao clicar no botão “Atualizar Painéis”:
            ------------------------------------------------------
            Painel 1: é atualizado, pois está como UpdateModel=”Conditional” e o botão que gerou o PostBack é um Trigger dele;
            Painel 2: não é atualizado, pois está como UpdateModel=”Conditional” e o PostBack foi gerado por um componente fora dele;
            Painel 3: é atualizado, porque por padrão está definido como UpdateModel=”Always”.

            Ao clicar no botão “Atualizar Página”:
            ------------------------------------------------------
            Como o Trigger desse botão é do tipo PostBackTrigger, a página é recarregada completamente, atualizando todos os painéis.

            Ao clicar no botão “Painel 1″:
            ------------------------------------------------------
            Painel 1: está com a propriedade ChildrenAsTriggers=”false”, então mesmo que o botão esteja dentro dele, seu conteúdo não é atualizado porque o ele não está definido como um Trigger em;
            Painel 2: não é atualizado, pois está definido como UpdateModel=”Conditional” e o PostBack foi gerado por um componente fora dele;
            Painel 3: é atualizado, porque por padrão está com UpdateModel=”Always”.

            Ao clicar no botão “Painel 2″:
           ------------------------------------------------------
            Painel 1: não é atualizado, pois está definido como UpdateModel=”Conditional” e o PostBack foi gerado por um componente fora dele;
            Painel 2: é atualizado, pois está definido como UpdateModel=”Conditional” mas o PostBack foi gerado por um componente dentro dele;
            Painel 3: é atualizado, porque por padrão está definido como UpdateModel=”Always”.

            Ao clicar no botão “Painel 3″:
            ------------------------------------------------------
            Painel 1: é atualizado, porque o método “Painel3_Click” chama manualmente a função “updPainel1.Update()”;
            Painel 2: não é atualizado, pois está definido como UpdateModel=”Conditional” e o PostBack foi gerado por um componente fora dele;
            Painel 3: é atualizado, porque por padrão está definido como UpdateModel=”Always”.*/
            
    }
}
