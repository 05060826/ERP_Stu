using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// 采购表
	/// </summary>
	 public class PurchaseModel
	 {
		 public int  ReceIptsId { get; set; }
		/// <summary>
		/// 采购单据编号
		/// </summary>
		 public string  ReceIptsCode { get; set; }
		/// <summary>
		/// 商品Id
		/// </summary>
		 public int  SId { get; set; }
		/// <summary>
		/// 供应商Id
		/// </summary>
		 public int  GId { get; set; }
		public string Gname { get; set; }
		/// <summary>
		/// 采购数量
		/// </summary>
		public int  Number { get; set; }
		/// <summary>
		/// 折扣率
		/// </summary>
		 public double  Rate { get; set; }
		/// <summary>
		/// 折扣额
		/// </summary>
		 public double  Discount { get; set; }
		/// <summary>
		/// 采购金额
		/// </summary>
		 public double  CMoney { get; set; }
		/// <summary>
		/// 结算账户
		/// </summary>
		 public int  AId { get; set; }
		/// <summary>
		/// 采购录单时间
		/// </summary>
		 public DateTime  Datetime { get; set; }
		/// <summary>
		/// 付款状态（）
		/// </summary>
		 public int  PayMent { get; set; }
		/// <summary>
		/// 备注
		/// </summary>
		 public string  Remark { get; set; }
		/// <summary>
		/// 是否操作执行到数据库
		/// </summary>
		 public int  IsState { get; set; }
	 }
}
