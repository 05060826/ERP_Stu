using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// �����б�
	/// </summary>
	 public class ClearModel
	 {
		 public int  ClearId { get; set; }
		/// <summary>
		/// �������ݱ��
		/// </summary>
		 public string  CleaNumber { get; set; }
		/// <summary>
		/// �ͻ�Id
		/// </summary>
		 public int  ClientId { get; set; }
		/// <summary>
		/// ������ԱId
		/// </summary>
		 public int  MId { get; set; }
		/// <summary>
		/// ��ƷId
		/// </summary>
		 public int  SId { get; set; }
		/// <summary>
		/// ����
		/// </summary>
		 public int  Number { get; set; }
		/// <summary>
		/// ���۵���
		/// </summary>
		 public double  SellMoney { get; set; }
		/// <summary>
		/// �ۿ���
		/// </summary>
		 public double  Rate { get; set; }
		/// <summary>
		/// �ۿ۽��
		/// </summary>
		 public double  Discount { get; set; }
		/// <summary>
		/// ���۽��
		/// </summary>
		 public double  SMoney { get; set; }
		/// <summary>
		/// �ջ���ַ
		/// </summary>
		 public string  Addresses { get; set; }
		/// <summary>
		/// ������������
		/// </summary>
		 public DateTime  CTime { get; set; }
		/// <summary>
		/// �����˻�
		/// </summary>
		 public int  AId { get; set; }
		/// <summary>
		/// ����״̬��0��δ����1���Ѹ��2δ�˿3�����˿
		/// </summary>
		 public int  CState { get; set; }
		/// <summary>
		/// ����ָ��
		/// </summary>
		 public int  IsState { get; set; }
	 }
}
