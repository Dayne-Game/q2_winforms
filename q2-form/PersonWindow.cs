using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using q2_form.Models;

namespace q2_form
{
    public partial class PersonWindow : Form
    {
        public PersonWindow()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                string url = "https://jsonplaceholder.typicode.com/users?_limit=5";
                string json = wc.DownloadString(url);
                Person person1 = new Person();
                List<Person> data = JsonConvert.DeserializeObject<List<Person>>(json);
                PersonTitle.Text = person1.Display_Data(data);
            }
        }
    }
}
