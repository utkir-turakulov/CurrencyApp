using Currency.API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Currency.API.Data
{
	public class CurrencyContext:DbContext
	{
		public CurrencyContext(): base("Bank_API")
		{

		}

		public DbSet<RequestHistory> RequestHistory { get; set; }
	}
}