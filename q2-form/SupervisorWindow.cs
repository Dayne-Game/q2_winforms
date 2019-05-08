using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using q2_form.Models;
using System.Net;
using Newtonsoft.Json;

namespace q2_form
{
    public partial class SupervisorWindow : Form
    {
        public SupervisorWindow()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                string url = "https://jsonplaceholder.typicode.com/users?_limit=5";
                string json = wc.DownloadString(url);
                Supervisor super1 = new Supervisor();
                List<Supervisor> data = JsonConvert.DeserializeObject<List<Supervisor>>(json);
                SupervisorTitle.Text = super1.Display_Data(data);
            }
        }
    }
}
