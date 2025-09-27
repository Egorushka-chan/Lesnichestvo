using System.ComponentModel.DataAnnotations;
using Lesnichestvo.DAL.Interfaces;

namespace Lesnichestvo.DAL.Entities
{
    /// <summary>
    /// Тип деревьев
    /// </summary>
    public class WoodType : IEntity
    {
        public int ID {get;set;}
        [Display(Name = "Тип древесины")]
        public string Name {get;set;} = string.Empty;

        public List<UnsoldWood> UnsoldWoods {get;set;} = [];
        public List<SoldWood> SoldWoods {get; set;} = [];
    }
}
