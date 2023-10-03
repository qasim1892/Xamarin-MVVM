using Android.Util;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinMvvm.Models;

namespace XamarinMvvm.Repository
{
    public class ProductRepository
    {
        private const string ApiUrl = "https://dummyjson.com/products";
        private const string tag = "ProductRepository";
        public async Task<List<ProductsResponse>> GetProductsAsync()
        {
            try
            {
                var httpClient = new HttpClient();
                var productResponse = await httpClient.GetAsync(ApiUrl);
                if (productResponse.IsSuccessStatusCode)
                {
                    var content = await productResponse.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ApiResponse>(content);
                    return result.Products;
                }
                else
                {
                    //Handle error or throw exception
                    Log.Error(tag, "API Error Response:"+productResponse.StatusCode);
                }
            }catch(Exception ex)
            {
                Log.Error(tag, "API Exception Response:" +ex.Message);
            }
            return new List<ProductsResponse>();
        }

    }
}
