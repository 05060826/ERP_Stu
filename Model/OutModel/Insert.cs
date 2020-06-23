using System;
using System.Collections.Generic;
using System.Text;

namespace Model.OutModel
{
    public class Insert
    {
		
		/// <summary>
		/// 出货单据编号
		/// </summary>
		public string CleaNumber { get; set; }
		/// <summary>
		/// 客户名称
		/// </summary>
		public string CliName { get; set; }
		/// <summary>
		/// 销售人员
		/// </summary>
		public string MName { get; set; }
		/// <summary>
		/// 商品名称
		/// </summary>
		public string SName { get; set; }
		/// <summary>
		/// 数量
		/// </summary>
		public int Number { get; set; }
		/// <summary>
		/// 销售单价
		/// </summary>
		public double SellMoney { get; set; }
		/// <summary>
		/// 折扣率
		/// </summary>
		public double Rate { get; set; }
		/// <summary>
		/// 折扣金额
		/// </summary>
		public double Discount { get; set; }
		/// <summary>
		/// 销售金额
		/// </summary>
		public double SMoney { get; set; }
		/// <summary>
		/// 收货地址
		/// </summary>
		public string Addresses { get; set; }
		/// <summary>
		/// 出货单据日期
		/// </summary>
		public DateTime CTime { get; set; }
		/// <summary>
		/// 结算账户
		/// </summary>
		public int AId { get; set; }
		//仓库Id
		public int WId { get; set; }
		//供应商Id
		public int GId { get; set; }

	}
}
