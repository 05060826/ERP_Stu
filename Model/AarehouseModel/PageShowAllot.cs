using System;
using System.Collections.Generic;
using System.Text;

namespace Model.AarehouseModel
{
    public class PageShowAllot
    {

        public List<AllotShowModel> ShowList { get; set; }
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
