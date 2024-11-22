using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_SAP.Models.Exceptons
{
    public class ExceptionFiles : ApplicationException
    {
        public ExceptionFiles(string ex) : base(ex)
        { 

        }
    }
}
