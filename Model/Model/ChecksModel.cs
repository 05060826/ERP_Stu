using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// 盘点表
	/// </summary>
	 public class ChecksModel
	 {
		 public int  Cid { get; set; }
		/// <summary>
		/// 仓库Id
		/// </summary>
		 public int  Wid { get; set; }
		/// <summary>
		/// 商品Id
		/// </summary>
		 public int  Sid { get; set; }
		/// <summary>
		/// 商品名称
		/// </summary>
		 public string  SName { get; set; }
		/// <summary>
		/// 商品规格
		/// </summary>
		 public string  Specification { get; set; }
		/// <summary>
		/// 商品单位
		/// </summary>
		 public string  Units { get; set; }
		/// <summary>
		/// 系统库存数量（采购时所进数量）
		/// </summary>
		 public int  SystemNumber { get; set; }
		/// <summary>
		/// 盘点库存数量（采购数量-出货数量+退货数量）
		/// </summary>
		 public int  CheckNumber { get; set; }


	 }
}
