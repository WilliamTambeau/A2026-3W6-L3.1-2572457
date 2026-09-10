using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }

        [Length(5, 20, ErrorMessage = "{0} must be between {1} and {2} characters long.")]
        public string Name { get; set; }

        [Display(Name = "Zombie Type")]
        [ForeignKey(nameof(ZombieType))]
        public int ZombieTypeId { get; set; }

        [ValidateNever]
        public ZombieType? ZombieType { get; set; }

        [Range(1, 20, ErrorMessage = "{0} must be between {1} and {2}.")]
        public int Point { get; set; }

        [Length(5, 20, ErrorMessage = "{0} must be between {1} and {2} characters long.")]
        public string ShortDesc { get; set; }
    }
}
