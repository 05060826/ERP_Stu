using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// �ɹ���
	/// </summary>
	 public class PurchaseModel
	 {
		 public int  ReceIptsId { get; set; }
		/// <summary>
		/// �ɹ����ݱ��
		/// </summary>
		 public string  ReceIptsCode { get; set; }
		/// <summary>
		/// ��ƷId
		/// </summary>
		 public int  SId { get; set; }
		/// <summary>
		/// ��Ӧ��Id
		/// </summary>
		 public int  GId { get; set; }
		public string Gname { get; set; }
		/// <summary>
		/// �ɹ�����
		/// </summary>
		public int  Number { get; set; }
		/// <summary>
		/// �ۿ���
		/// </summary>
		 public double  Rate { get; set; }
		/// <summary>
		/// �ۿ۶�
		/// </summary>
		 public double  Discount { get; set; }
		/// <summary>
		/// �ɹ����
		/// </summary>
		 public double  CMoney { get; set; }
		/// <summary>
		/// �����˻�
		/// </summary>
		 public int  AId { get; set; }
		/// <summary>
		/// �ɹ�¼��ʱ��
		/// </summary>
		 public DateTime  Datetime { get; set; }
		/// <summary>
		/// ����״̬����
		/// </summary>
		 public int  PayMent { get; set; }
		/// <summary>
		/// ��ע
		/// </summary>
		 public string  Remark { get; set; }
		/// <summary>
		/// �Ƿ����ִ�е����ݿ�
		/// </summary>
		 public int  IsState { get; set; }
	 }
}
