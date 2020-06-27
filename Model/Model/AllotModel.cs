using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// 调拨表
	/// </summary>
	 public class AllotModel
	 {
		/// <summary>
		/// 调拨Id
		/// </summary>
		 public int  AllotId { get; set; }
		/// <summary>
		/// 单据编号
		/// </summary>
		 public string  AllotCode { get; set; }
		/// <summary>
		/// 商品Id
		/// </summary>
		 public int  Sid { get; set; }
		/// <summary>
		/// 调拨数量
		/// </summary>
		 public int  Number { get; set; }
		/// <summary>
		/// 数量单位
		/// </summary>
		 public string  Units { get; set; }
		/// <summary>
		/// 调出仓库
		/// </summary>
		 public int  Wid { get; set; }
		/// <summary>
		/// 调入仓库
		/// </summary>
		public int Eid { get; set; }
		/// <summary>
		/// 录单时间
		/// </summary>
		public DateTime  ATime { get; set; }
		/// <summary>
		/// 备注
		/// </summary>
		 public string  Remark { get; set; }
		/// <summary>
		/// 是否执行操作到数据库
		/// </summary>
		 public int  IsState { get; set; }
	 }
}
