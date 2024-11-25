using DashBoard_SAP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_SAP.Models.Exceptions
{
    public class ExceptionLogic : ApplicationException
    {
        public ExceptionLogic(string ex) : base(ex)
        {
            Variables.Logs.Add($"={ex} ({DateTime.Now.ToString("hh:mm dd/MM/yy")})");
        }
    }
}
