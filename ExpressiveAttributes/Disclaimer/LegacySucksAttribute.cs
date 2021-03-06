﻿using System;

namespace ExpressiveAttributes
{
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	public class LegacySucksAttribute : Attribute
	{
		public string Comment { get; set; }

		public LegacySucksAttribute(string comment = "")
		{
			Comment = comment;
		}
	}
}
