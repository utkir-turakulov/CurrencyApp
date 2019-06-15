using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Currency.API.Models
{
	/// <summary>
	/// Таблица истории запросов
	/// </summary>
	[DataContract]
	public class RequestHistory
	{
		[DataMember]
		[Key]
		public long Id { get; set; }

		[DataMember]
		public DateTime InsertDate { get; set; }

		[DataMember]
		public string History { get; set; }
	}
}