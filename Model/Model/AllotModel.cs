using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// ������
	/// </summary>
	 public class AllotModel
	 {
		/// <summary>
		/// ����Id
		/// </summary>
		 public int  AllotId { get; set; }
		/// <summary>
		/// ���ݱ��
		/// </summary>
		 public string  AllotCode { get; set; }
		/// <summary>
		/// ��ƷId
		/// </summary>
		 public int  Sid { get; set; }
		/// <summary>
		/// ��������
		/// </summary>
		 public int  Number { get; set; }
		/// <summary>
		/// ������λ
		/// </summary>
		 public string  Units { get; set; }
		/// <summary>
		/// �����ֿ�
		/// </summary>
		 public int  Wid { get; set; }
		/// <summary>
		/// ����ֿ�
		/// </summary>
		public int Eid { get; set; }
		/// <summary>
		/// ¼��ʱ��
		/// </summary>
		public DateTime  ATime { get; set; }
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
