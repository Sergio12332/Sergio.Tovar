using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_unit
{
    public partial class Cerveceria : Form
    {
        public Cerveceria()
        {
            InitializeComponent();
        }

        private void Cerveceria_Load(object sender, EventArgs e)
        {

        }

        private void Cerveceria_FormClosed(object sender, FormClosedEventArgs e)
        {
            log ir = new log();
            ir.Show();
            this.Hide();
        }
    }
}
