using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Currency.API.Models
{
	[DataContract]
	public class Valute
	{
		//public long Id { get; set; }
		[DataMember]
		public ValuteData AUD { get; set; }
		[DataMember]
		public ValuteData AZN { get; set; }
		[DataMember]
		public ValuteData GBP { get; set; }
		[DataMember]
		public ValuteData AMD { get; set; }
		[DataMember]
		public ValuteData BYN { get; set; }
		[DataMember]
		public ValuteData BGN { get; set; }
		[DataMember]
		public ValuteData HUF { get; set; }
		[DataMember]
		public ValuteData HKD { get; set; }
		[DataMember]
		public ValuteData DKK { get; set; }
		[DataMember]
		public ValuteData USD { get; set; }
		[DataMember]
		public ValuteData EUR { get; set; }
		[DataMember]
		public ValuteData INR { get; set; }
		[DataMember]
		public ValuteData KZT { get; set; }
		[DataMember]
		public ValuteData CAD { get; set; }
		[DataMember]
		public ValuteData KGS { get; set; }
		[DataMember]
		public ValuteData CNY { get; set; }
		[DataMember]
		public ValuteData MDL { get; set; }
		[DataMember]
		public ValuteData NOK { get; set; }
		[DataMember]
		public ValuteData PLN { get; set; }
		[DataMember]
		public ValuteData RON { get; set; }
		[DataMember]
		public ValuteData XDR { get; set; }
		[DataMember]
		public ValuteData SGD { get; set; }
		[DataMember]
		public ValuteData TJS { get; set; }
		[DataMember]
		public ValuteData TRY { get; set; }
		[DataMember]
		public ValuteData TMT { get; set; }
		[DataMember]
		public ValuteData UZS { get; set; }
		[DataMember]
		public ValuteData UAH { get; set; }
		[DataMember]
		public ValuteData CZK { get; set; }
		[DataMember]
		public ValuteData SEK { get; set; }
		[DataMember]
		public ValuteData ZAR { get; set; }
		[DataMember]
		public ValuteData KRW { get; set; }
		[DataMember]
		public ValuteData JPY { get; set; }
	}
}