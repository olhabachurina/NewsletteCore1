using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsletteCore.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Promotion> Promotions { get; set; }
    }
}
