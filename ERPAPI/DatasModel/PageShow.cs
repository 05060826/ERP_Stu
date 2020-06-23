using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPAPI.DatasModel
{
    public class PageShow
    {

        public List<PurchaseInfos> ShowList { get; set; }
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
