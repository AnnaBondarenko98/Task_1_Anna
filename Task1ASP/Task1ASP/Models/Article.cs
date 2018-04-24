using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1ASP.Models
{
	public class Article
	{
		public int Id { get; set; }

		[Display(Name = "Name")]
		[Required(ErrorMessage = "Enter the name of tariff!")]
		[StringLength(25, MinimumLength = 3, ErrorMessage = "Name of tariff must be from 3 to 25 characters")]
		public string Name { get; set; }

		[Display(Name = "Date of connection")]
		[DataType(DataType.DateTime)]
		public DateTime Date { get; set; }

		[Display(Name = "Article text")]
		public string Text { get; set; }
	}
}