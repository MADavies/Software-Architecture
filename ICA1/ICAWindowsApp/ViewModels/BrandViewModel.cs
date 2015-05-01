using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

using Windows.Data.Json;
using ICAWindowsApp.Model;
using Newtonsoft.Json;
using ICAWindowsApp.ServiceAgents;
using ICAWindowsApp.ViewModels;
namespace ICAWindowsApp.ViewModels
{
    class BrandViewModel
    {

         HttpClient client = new HttpClient();

        public BrandViewModel()
        {


            client.BaseAddress = new System.Uri("http://localhost:15063/");

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.MaxResponseContentBufferSize = 266000;


        }


        public async Task<IEnumerable<BrandDTO>> GetCategory()
        {

            //  var response = await client.GetAsync("api/product");
            HttpResponseMessage response = await client.GetAsync("api/brand");
            var categoryString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<BrandDTO[]>(categoryString);



        }



    }
}
