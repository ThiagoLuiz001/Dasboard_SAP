using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashBoard_SAP.Services;
namespace DashBoard_SAP.Models.Exceptions
{
    public class ExceptionFiles : ApplicationException
    {
        public ExceptionFiles(string ex) : base(ex)
        { 
            Variables.Logs.Add($"={ex} ({DateTime.Now.ToString("hh:mm dd/MM/yy")})");
        }
    }
}
