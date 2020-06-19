using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// 出货列表
	/// </summary>
	 public class ClearModel
	 {
		 public int  ClearId { get; set; }
		/// <summary>
		/// 出货单据编号
		/// </summary>
		 public string  CleaNumber { get; set; }
		/// <summary>
		/// 客户Id
		/// </summary>
		 public int  ClientId { get; set; }
		/// <summary>
		/// 销售人员Id
		/// </summary>
		 public int  MId { get; set; }
		/// <summary>
		/// 商品Id
		/// </summary>
		 public int  SId { get; set; }
		/// <summary>
		/// 数量
		/// </summary>
		 public int  Number { get; set; }
		/// <summary>
		/// 销售单价
		/// </summary>
		 public double  SellMoney { get; set; }
		/// <summary>
		/// 折扣率
		/// </summary>
		 public double  Rate { get; set; }
		/// <summary>
		/// 折扣金额
		/// </summary>
		 public double  Discount { get; set; }
		/// <summary>
		/// 销售金额
		/// </summary>
		 public double  SMoney { get; set; }
		/// <summary>
		/// 收货地址
		/// </summary>
		 public string  Addresses { get; set; }
		/// <summary>
		/// 出货单据日期
		/// </summary>
		 public DateTime  CTime { get; set; }
		/// <summary>
		/// 结算账户
		/// </summary>
		 public int  AId { get; set; }
		/// <summary>
		/// 出货状态（0：未付款1：已付款，2未退款，3：已退款）
		/// </summary>
		 public int  CState { get; set; }
		/// <summary>
		/// 操作指令
		/// </summary>
		 public int  IsState { get; set; }
	 }
}
