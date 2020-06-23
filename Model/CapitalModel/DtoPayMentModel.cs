using System;
using System.Collections.Generic;
using System.Text;

namespace Model.CapitalModel
{
    public class DtoPayMentModel
    {
		/// <summary>
		/// 付款单Id
		/// </summary>
		public int PaymentId { get; set; }
		/// <summary>
		/// 付款单据编号
		/// </summary>
		public string PaymentCode { get; set; }
		/// <summary>
		/// 客户Id
		/// </summary>
		public int ClientId { get; set; }
		/// <summary>
		/// 采购单Id
		/// </summary>
		public int ReceIptsId { get; set; }
		/// <summary>
		/// 付款金额
		/// </summary>
		public double CNumber { get; set; }
		/// <summary>
		/// 结算账户
		/// </summary>
		public int Aid { get; set; }
		/// <summary>
		/// 录单时间
		/// </summary>
		public DateTime RTime { get; set; }
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }
		/// <summary>
		/// 是否执行操作到数据库
		/// </summary>
		public int IsState { get; set; }
		public double CMoney { get; set; }
		public string ClientName { get; set; }
	}
}
