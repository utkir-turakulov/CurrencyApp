using Currency.API.Data;
using Currency.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Currency.API.Services
{
	public class CurrencyService
	{
		public ValuteHistory GetDailyData()
		{
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			string json = null;

			using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
			{
				json = reader.ReadToEnd();
			}

			var data = JsonConvert.DeserializeObject<ValuteHistory>(json);

			return data;
		}

		public async Task AddHistory(RequestHistory history)
		{
			using (CurrencyContext context = new CurrencyContext())
			{
				context.RequestHistory.Add(history);
				await context.SaveChangesAsync();
			}
		}

		public IEnumerable<RequestHistory> Find(Func<RequestHistory,bool> predicate)
		{
			using (CurrencyContext context = new CurrencyContext())
			{
				return context.RequestHistory.Where(predicate).ToList();
			}
		}
	}
}