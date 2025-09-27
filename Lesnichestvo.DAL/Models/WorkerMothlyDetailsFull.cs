using Microsoft.EntityFrameworkCore;

namespace Lesnichestvo.DAL.Models
{
    [Keyless]
    public class WorkerMothlyDetailsFull
    {
        public int WorkerID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string YearMonth { get; set; } = string.Empty;
        public int TotalHours { get; set; }
        public int WorksCount { get; set; }
        public decimal CurrentPayment { get; set; }
        public decimal MonthlyCalculatedPayment { get; set; }
    }
}
