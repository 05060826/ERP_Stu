using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// ��Ʒ��
	/// </summary>
	 public class CommodityModel
	 {
		 public int  Sid { get; set; }
		 public string  SName { get; set; }
		/// <summary>
		/// ��Ʒ��λ
		/// </summary>
		 public string  Units { get; set; }
		/// <summary>
		/// �ֿ�Id
		/// </summary>
		 public int  WId { get; set; }
		public string WName { get; set; }
		/// <summary>
		/// ��Ʒ����
		/// </summary>
		public double  Price { get; set; }
		/// <summary>
		/// ��Ӧ��Id
		/// </summary>
		 public int  GId { get; set; }
	 }
}
