using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// ���
	/// </summary>
	 public class PaymentModel
	 {
		/// <summary>
		/// ���Id
		/// </summary>
		 public int  PaymentId { get; set; }
		/// <summary>
		/// ����ݱ��
		/// </summary>
		 public string  PaymentCode { get; set; }
		/// <summary>
		/// �ͻ�Id
		/// </summary>
		 public int  ClientId { get; set; }
		/// <summary>
		/// �ɹ���Id
		/// </summary>
		 public int  ReceIptsId { get; set; }
		/// <summary>
		/// ������
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
		/// �Ƿ�ִ�в��������ݿ�
		/// </summary>
		 public int  IsState { get; set; }
	 }
}
