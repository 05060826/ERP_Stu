using System;
using System.Collections.Generic;
using System.Text;

namespace Model.OutModel
{
    public class OutStock
    {
        //OutStock（出货表显示）
        public int ClearId { get; set; } 
        public string CleaNumber { get; set; }
        public int CliId { get; set; }
        public int MId { get; set; }
        public int SId { get; set; }
        public int Number { get; set; }
        public double SellMoney { get; set; }
        public double Rate { get; set; }
        public double Discount { get; set; }
        public double SMoney { get; set; }
        public string Addresses { get; set; }
        public DateTime CTime { get; set; }
        public int AId { get; set; }
        public int CState { get; set; }
        public int IsState { get; set; }


        public int CLientId { get; set; }
        public string ClientName { get; set; }

        public int SeId { get; set; }
        public string SeName { get; set; }
     
    }
}
