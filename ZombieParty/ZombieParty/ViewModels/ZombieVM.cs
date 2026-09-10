using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.Models;

namespace ZombieParty.ViewModels
{
    public class ZombieVM
    {
        public Zombie Zombie { get; set; }

        public SelectList? ZombieTypeSelectList { get; set; }
    }
}
