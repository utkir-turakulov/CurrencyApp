using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Currency.API.Models
{
	[DataContract]
	public class ValuteData
	{
		[DataMember]
		public string Id { get; set; }
		[DataMember]
		public long NumCode { get; set; }
		[DataMember]
		public string CharCode { get; set; }
		[DataMember]
		public long Nominal { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public double Value { get; set; }
		[DataMember]
		public double Previous { get; set; }
	}
}