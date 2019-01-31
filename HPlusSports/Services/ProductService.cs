using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;

namespace HPlusSports.Services
{
    // the ProductService is used to call the API
    public class ProductService
    {
        private const string WISHLIST_FILE = "wishlist.json";
        static HttpClient client;

        public static List<Product> WishList
        {
            get;
            set; 
        }




        static ProductService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://hplussport.com/api/");
        }


        // this is going to use the HTTPclient to retrive JSON data and 
        // deserialize it into our list of products.
        public static async Task<List<Product>> GetProductAsync()
        {
            var productsRaw = await client.GetStringAsync("products/");

            var serializer = new JsonSerializer();
            using (var tReader = new StringReader(productsRaw))
            {
                using (var jReader = new JsonTextReader(tReader))
                {
                    var products = serializer.Deserialize<List<Product>>(jReader);
                    return products;
                }
            }
        }

        public static async Task SaveWishList()
        {
            if (WishList != null)
            {
                //Save wishlist to file
            }
        }

        public static async Task LoadWishList()
        {
            // Load wishlist from file 
        }




    }
}
