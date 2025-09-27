using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Квартальная сеть
    /// </summary>
    public class QuartalNetwork : IEntity
    {
        public int ID { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Важность")]
        public string? Importance { get; set; }
        [Display(Name = "Примечание")]
        public string? Description { get; set; }

        public List<Inspection> Inspections { get; set; } = [];
        public List<Dacha> Dachas { get; set; } = [];
        public List<Mapping> Mappings { get; set; } = [];
    }
}
