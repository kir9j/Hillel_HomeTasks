using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask_24
{
    public class Group
    {
        [Required]
        public string Name { get; set; }

        [Range(1, 6)]
        public int Course { get; set; }
    }
}
