using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// �տ
	/// </summary>
	 public class ReceiptModel
	 {
		 public int  ReceiptId { get; set; }
		/// <summary>
		/// �տ�ݱ��
		/// </summary>
		 public string  ReceiptCode { get; set; }
		/// <summary>
		/// �ͻ�Id
		/// </summary>
		 public int  ClientId { get; set; }
		/// <summary>
		/// ������Id
		/// </summary>
		 public int  ClearId { get; set; }
		/// <summary>
		/// �տ���
		/// </summary>
		 public double  CNumber { get; set; }
		/// <summary>
		/// �����˻�
		/// </summary>
		 public int  Aid { get; set; }
		/// <summary>
		/// ¼��ʱ��
		/// </summary>
		 public DateTime  RTime { get; set; }
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
