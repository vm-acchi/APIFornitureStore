﻿using System;
namespace API.Forniture.Shared
{
	public class Order{
		public int Id { get; set; }
		public int OrderNumber { get; set; }
		public int ClientId { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DeliveryDate { get; set; }
	}
}