using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// 收款单
	/// </summary>
	 public class ReceiptModel
	 {
		 public int  ReceiptId { get; set; }
		/// <summary>
		/// 收款单据编号
		/// </summary>
		 public string  ReceiptCode { get; set; }
		/// <summary>
		/// 客户Id
		/// </summary>
		 public int  ClientId { get; set; }
		/// <summary>
		/// 出货单Id
		/// </summary>
		 public int  ClearId { get; set; }
		/// <summary>
		/// 收款金额
		/// </summary>
		 public double  CNumber { get; set; }
		/// <summary>
		/// 结算账户
		/// </summary>
		 public int  Aid { get; set; }
		/// <summary>
		/// 录单时间
		/// </summary>
		 public DateTime  RTime { get; set; }
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
