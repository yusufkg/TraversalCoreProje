using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
	[AllowAnonymous]
	[Area("Admin")]
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> Index()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-11-20&filter_by_currency=EUR&dest_id=-1456928&locale=en-gb&checkout_date=2023-11-23&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
				Headers =
	{
		{ "X-RapidAPI-Key", "cab93dbc5amsh1479325aa6a6a06p1d1b8djsnd9a631709b2f" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var bodyReplace = body.Replace(".", "");
				var values = JsonConvert.DeserializeObject<BookingHotelSearchViewModel>(bodyReplace);
				return View(values.results);

			}
        }

		[HttpGet]
		public IActionResult GetCityDestId()
        {
			return View();
        }

		[HttpPost]
		public async Task<IActionResult> GetCityDestId(string p) 
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-11-20&filter_by_currency=EUR&dest_id=-1456928&locale=en-gb&checkout_date=2023-11-23&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
				Headers =
	{
		{ "X-RapidAPI-Key", "cab93dbc5amsh1479325aa6a6a06p1d1b8djsnd9a631709b2f" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();

				return View();
			}
		}
    }
}
