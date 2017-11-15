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
            
            System.Net.Http.HttpResponseMessage response = client.GetAsync("api/instituicao").Result;

            if (response.IsSuccessStatusCode)
            {

                instituicaoUri = response.Headers.Location;

                var instituicao = response.Content.ReadAsAsync<IEnumerable<Instituicao>>().Result;

                grdInstituicao.DataSource = instituicao;
                grdInstituicao.DataBind();
            }

            else
                Response.Write(response.StatusCode.ToString() + " - " + response.ReasonPhrase);
        }
    }
}