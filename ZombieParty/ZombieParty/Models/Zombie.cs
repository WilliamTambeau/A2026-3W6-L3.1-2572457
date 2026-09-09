using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public string Name { get; set; }

        [Display(Name = "Zombie Type")]
        [ForeignKey(nameof(ZombieType))]
        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }

        public int Point { get; set; }
    }
}
