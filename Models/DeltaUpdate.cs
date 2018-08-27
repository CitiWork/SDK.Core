﻿using System;

namespace NFive.SDK.Core.Models
{
	public class DeltaUpdate<T>
	{
		public Type Type => typeof(T);
		public Guid Id { get; set; }
		public string Property { get; set; }
		public dynamic Value;
	}
}