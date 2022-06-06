using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; }
        public object Par2{ get; set; }
        public object Par3 { get; set; }
        public object Par4 { get; set; }

    }
}
