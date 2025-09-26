using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Осмотр
    /// </summary>
    public class Inspection : IEntity
    {
        public int ID { get; set; }
        public int QuartalNetworkID { get; set; }
        public int WorkID { get; set; }
        public Work? Work { get; set; }
        public List<Report> Reports { get; set; } = [];
        public QuartalNetwork? QuartalNetwork { get; set; }
    }
}
