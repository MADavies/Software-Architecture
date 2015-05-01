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
    
        class ProductViewModel : ViewModelBase, Iproduct
        {
            HttpClient client = new HttpClient();

            public ProductViewModel()
            {


                client.BaseAddress = new System.Uri("http://localhost:15063/");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.MaxResponseContentBufferSize = 266000;


            }



            //protected override void OnNavigatedTo(NavigationEventArgs e)
            //{

            //    //GetAll();

            //}

            public async Task<IEnumerable<ProductDTO>> GetProduct()
            {

                //  var response = await client.GetAsync("api/product");
                HttpResponseMessage response = await client.GetAsync("api/product");
                var productString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProductDTO[]>(productString);



            }


            private string Serialize(ProductDTO expense)
            {
                return JsonConvert.SerializeObject(expense);
            }


        }





    }

