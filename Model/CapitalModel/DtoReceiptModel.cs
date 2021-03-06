﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.CapitalModel
{
    public class DtoReceiptModel
    {
		public int ReceiptId { get; set; }
		public string ReceiptCode { get; set; }
		public int ClientId { get; set; }
		public int ClearId { get; set; }
		public string CNumber { get; set; }
		public int Aid { get; set; }
		public string RTime { get; set; }
		public string Remark { get; set; }
		public int IsState { get; set; }
		public double SMoney { get; set; }
		public string ClientName { get; set; }
	}
}
