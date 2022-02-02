using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorZal
{
    public class HistoryElement
    {
        public string equation { get; set; }
        public string result { get; set; }
        public HistoryElement(string equation, string result)
        {
            this.equation = equation;
            this.result = result;
        }


    }
}
