using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Тип работы
    /// </summary>
    public class WorkType : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Work> Works { get; set; } = [];
    }
}
