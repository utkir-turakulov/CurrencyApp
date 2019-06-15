using System;
using System.Runtime.Serialization;

namespace Currency.API.Models
{
	[DataContract]
	public class ValuteHistory
	{
		//public long Id { get; set; }
		[DataMember]
		public DateTime Date { get; set; }
		[DataMember]
		public DateTime PreviousDate { get; set; }
		[DataMember]
		public string PreviousURL { get; set; }
		[DataMember]
		public DateTime TimeStamp { get; set; }
		[DataMember]
		public Valute Valute { get; set; }
	}
}