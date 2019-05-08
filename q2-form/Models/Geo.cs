using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q2_form.Interfaces;

namespace q2_form.Models
{
    class Geo : IGeo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
