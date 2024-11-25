using DashBoard_SAP.Services;

namespace DashBoard_SAP.Models.Exceptions
{
    public class ExceptionSSMS : ApplicationException
    {
        public ExceptionSSMS(string ex) : base(ex)
        {
            Variables.Logs.Add($"={ex} ({DateTime.Now.ToString("hh:mm dd/MM/yy")})");
        }
    }
}
