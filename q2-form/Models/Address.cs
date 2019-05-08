using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q2_form.Interfaces;

namespace q2_form.Models
{
    public class Address : IAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}
