using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_SAP.Models.Exceptons
{
    public class ExceptionLogic : ApplicationException
    {
        public ExceptionLogic(string ex) : base(ex)
        {

        }
    }
}
