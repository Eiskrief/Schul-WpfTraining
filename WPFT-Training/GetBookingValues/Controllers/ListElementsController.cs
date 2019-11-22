using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using GetBookingValues.Models;


namespace GetBookingValues.Controllers
{
    public class ListElementsController : ApiController
    {
        public static List<ListElements> GetListElements()
        {
            string json = new WebClient().DownloadString("https://api.coinmarketcap.com/v1/ticker/");

            List<ListElements> items = JsonConvert.DeserializeObject<List<ListElements>>(json);

            return items;
        }
    }
}
