using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore
{
    public class Tour
    {
        public int Id { get; set; } // primary Key  Id or TourId

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Duration { get; set; } = string.Empty;

        public int Price { get; set; }

    }
}
