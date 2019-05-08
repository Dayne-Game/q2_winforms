using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q2_form.Models;

namespace q2_form.Interfaces
{
        interface ISupervisor
        {
            string Name { get; set; }
            string Phone { get; set; }
            string Email { get; set; }
            Address Address { get; set; }
            string Display_Data(List<Supervisor> Data);
        }
}
