﻿using System;

namespace ExpressiveAttributes
{
	[AttributeUsage(AttributeTargets.All, Inherited = false)]
	public class HandsOffAttribute : Attribute
	{
		public string ByOrderOf { get; set; }
		public Consequence OnPainOf { get; set; }
	}
}
