using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principile
{
    abstract class Report
    {
       
        public int ReportId { get; set; }
        public string ReportName { get; set; }

        public abstract void CreateReport();   
        
    }
}
