using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rep = new AuthRepository<Admin>(".\\docs\\Users\\admins\\Admin");
            var admin = new Admin(1, "ser", "bez", "nik", "123", "456", "1234",
                new IDCard(1, "123", "234", true, "123", "1", "123", "123", new DateTime(123), new DateTime(123), new DateTime(123), "132", "123"));
            rep.AddObjectToRepository(admin);
        }
    }
}
