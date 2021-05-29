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

	private static new Rules[] rulesToProcess = new[]
	{
		new Rules
		{
			RuleId=1,
			RuleName="Generate packing slip for",
			Rule= new Rule[]
			{
				new Rule {
				PropertyName = "Type",
				Operation = ExpressionType.Equal,
				Value = "Physical"
				}
			}
		},
		new Rules
		{
			RuleId=1,
			RuleName="Generate duplicate packing slip for",
			Rule= new Rule[]
			{
				new Rule {
					PropertyName = "Type",
					Operation = ExpressionType.Equal,
					Value = "Physical"
				},
				new Rule {
					PropertyName = "Category",
					Operation = ExpressionType.Equal,
					Value = "Book"
				}
			}
		},
		new Rules
		{
			RuleId=1,
			RuleName="Generate commission to agent for",
			Rule= new Rule[]
			{
				new Rule {
					PropertyName = "Type",
					Operation = ExpressionType.Equal,
					Value = "Physical"
				},
				new Rule {
					PropertyName = "Category",
					Operation = ExpressionType.Equal,
					Value = "Book"
				}
			}
		},
		new Rules
		{
			RuleId=1,
			RuleName="Activate membership for",
			Rule= new Rule[]
			{
				new Rule {
					PropertyName = "Type",
					Operation = ExpressionType.Equal,
					Value = "Virtual"
				},
				new Rule {
					PropertyName = "Category",
					Operation = ExpressionType.Equal,
					Value = "Membership"
				}
			}
		},
		new Rules
		{
			RuleId=1,
			RuleName="Renew membership for",
			Rule= new Rule[]
			{
				new Rule {
					PropertyName = "Type",
					Operation = ExpressionType.Equal,
					Value = "Virtual"
				},
				new Rule {
					PropertyName = "Category",
					Operation = ExpressionType.Equal,
					Value = "Membership Renew"
				}
			}
		},
		new Rules
		{
			RuleId=1,
			RuleName="Add video \"first aid\" with",
			Rule= new Rule[]
			{
				new Rule {
					PropertyName = "Type",
					Operation = ExpressionType.Equal,
					Value = "Virtual"
				},
				new Rule {
					PropertyName = "Category",
					Operation = ExpressionType.Equal,
					Value = "Video"
				},
				new Rule {
					PropertyName = "Name",
					Operation = ExpressionType.Equal,
					Value = "Learning to ski"
				}
			}
		}
	};

	public class Items
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string Category { get; set; }
	}

	public class Rule
	{
		public string PropertyName { get; set; }
		public ExpressionType Operation { get; set; }
		public object Value { get; set; }
		public string Action { get; set; }
	}

	public class Rules
	{
		public int RuleId { get; set; }
		public string RuleName { get; set; }
		public Rule[] Rule { get; set; }

	}
}
