﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AarehouseModel
{
	//调拨显示模型
  public  class AllotShowModel
	{
		public int AllotId { get; set; }
		public string AllotCode { get; set; }
		public int Sid { get; set; }
		public int Number { get; set; }
		public string Units { get; set; }
		public int Wid { get; set; }
		public DateTime ATime { get; set; }
		public string Remark { get; set; }
		public int IsState { get; set; }

		public string SName { get; set; }
		public string Price { get; set; }
		public int GId { get; set; }

		
		public string WName { get; set; }

		public int TotalCount { get; set; }

		public int EId { get; set; }
		public string Ename { get; set; }
	}
}
