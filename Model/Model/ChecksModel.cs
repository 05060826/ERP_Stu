using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Model
{
	/// <summary>
	/// �̵��
	/// </summary>
	 public class ChecksModel
	 {
		 public int  Cid { get; set; }
		/// <summary>
		/// �ֿ�Id
		/// </summary>
		 public int  Wid { get; set; }
		/// <summary>
		/// ��ƷId
		/// </summary>
		 public int  Sid { get; set; }
		/// <summary>
		/// ��Ʒ����
		/// </summary>
		 public string  SName { get; set; }
		/// <summary>
		/// ��Ʒ���
		/// </summary>
		 public string  Specification { get; set; }
		/// <summary>
		/// ��Ʒ��λ
		/// </summary>
		 public string  Units { get; set; }
		/// <summary>
		/// ϵͳ����������ɹ�ʱ����������
		/// </summary>
		 public int  SystemNumber { get; set; }
		/// <summary>
		/// �̵����������ɹ�����-��������+�˻�������
		/// </summary>
		 public int  CheckNumber { get; set; }


	 }
}
