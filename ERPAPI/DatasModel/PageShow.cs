using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using Model.PuchasesInfoModel;

namespace ERPAPI.DatasModel
{
    public class PageShow
    {

        public List<PurchModel> ShowList { get; set; }
        /// <summary>
        /// 总条数
        /// </summary>
        public int ToTalCount { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageTotal { get; set; }
    }
}
