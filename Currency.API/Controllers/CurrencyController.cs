using Currency.API.Models;
using Currency.API.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace Currency.API.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class CurrencyController : ApiController
    {
		[HttpGet]
		[EnableCors(origins: "*", headers: "*", methods: "*")]
		public async Task<JsonResult<ValuteHistory>> Get()
		{
			CurrencyService currencyService = new CurrencyService();
			var all = currencyService.Find(x => x.InsertDate.Date == DateTime.Now.Date);
			RequestHistory today = null;

			if (all.Any())
			{
				today = all.First();
			}

			if (today == null)
			{
				var data = currencyService.GetDailyData();
				var valuteHistory = JsonConvert.SerializeObject(data);

				await currencyService.AddHistory(new RequestHistory()
				{
					InsertDate = DateTime.Now,
					History = valuteHistory
				});

				return Json(data);
			}
			var history = JsonConvert.DeserializeObject<ValuteHistory>(today.History);

			return Json(history);
		}
    }
}
