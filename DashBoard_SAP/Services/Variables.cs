using DashBoard_SAP.Models.Entities;

namespace DashBoard_SAP.Services
{
    public static class Variables
    {
        public static Dictionary<string, Production> Prod { get; set; } = new Dictionary<string, Production>();
        public static SortedSet<string> Logs { get; set; } = new SortedSet<string>();
    }
}
