using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Atividade_08.Model;


namespace Atividade_08
{
    public partial class _Default : Page
    {
        HttpClient client;
        Uri usuarioUri;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getAll();
            }
        }

        public _default()
        {
          

            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://turmadobem.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        private void getAll()
        {
            //chamando a api pela url
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/instituicao").Result;

            //se retornar com sucesso busca os dados
            if (response.IsSuccessStatusCode)
            {
                //pegando o cabeçalho
                instituicaoUri = response.Headers.Location;

                //Pegando os dados do Rest e armazenando na variável usuários
                var instituicao = response.Content.ReadAsAsync<IEnumerable<Instituicao>>().Result;

                //preenchendo a lista com os dados retornados da variável
                grdInstituicao.DataSource = instituicao;
                grdInstituicao.DataBind();
            }

            //Se der erro na chamada, mostra o status do código de erro.
            else
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
        }
    }
}