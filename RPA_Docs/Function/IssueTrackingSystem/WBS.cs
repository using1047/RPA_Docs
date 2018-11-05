using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA_Docs.Function.IssueTrackingSystem
{
    public class wbsData
    {
        public string Classify { get; set; }
        public string userName { get; set; }
        public string Todo { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public Color Importance { get; set; }
        //public int State { get; set; }
        //public string Memo { get; set; }
    }
}
