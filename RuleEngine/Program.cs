using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

public class Program
{
	public static void Main()
	{
		var Items = new[] {
			new Items {
				Name = "How to fish",
				Type = "Physical",
				Category = "Book"
			},
			new Items {
				Name = "How to fish",
				Type = "Virtual",
				Category = "Video"
			},
			new Items {
				Name = "Learning to ski",
				Type = "Virtual",
				Category = "Video"
			},
			new Items {
				Name = "First aid",
				Type = "Virtual",
				Category = "Video"
			},
			new Items {
				Name = "Gold Plan",
				Type = "Virtual",
				Category = "Membership"
			},
			new Items {
				Name = "Gold Plan",
				Type = "Virtual",
				Category = "Membership Renew"
			},
			new Items {
				Name = "Fishing Net",
				Type = "Physical",
				Category = "Product"
			}
		};
	}

	public class Items
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Category { get; set; }
	}
}
