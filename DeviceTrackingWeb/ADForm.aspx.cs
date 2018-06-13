using System;
using System.Collections.Generic;
using RestSharp;

namespace DeviceTrackingWeb
{
    public partial class ADForm : System.Web.UI.Page
    {
        private RestClient client = new RestClient("http://localhost:63761/api/");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click_Click(object sender, EventArgs e)
        {
            RestRequest request = new RestRequest("AD", Method.GET);
            IRestResponse<List<string>> response = client.Execute<List<string>>(request);
        }
    }
}