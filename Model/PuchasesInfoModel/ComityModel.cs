using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PuchasesInfoModel
{
   public class ComityModel
    {

		public int Sid { get; set; }
		public string SName { get; set; }
		/// <summary>
		/// 商品单位
		/// </summary>
		public string Units { get; set; }
		/// <summary>
		/// 仓库Id
		/// </summary>
		public int WId { get; set; }
		public string WName { get; set; }
		/// <summary>
		/// 商品单价
		/// </summary>
		public double Price { get; set; }
		/// <summary>
		/// 供应商Id
		/// </summary>
		public int GId { get; set; }

	}
}
