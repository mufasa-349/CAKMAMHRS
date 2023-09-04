using CAKMAMHRS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAKMAMHRS
{
    public partial class newtableappointment : Form
    {

        public newtableappointment(string datee)
        {
            InitializeComponent();
            textBox1.Text = datee;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void newtableappointment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            newAppointment dateappo = new newAppointment();
            dateappo.saveAppointment();
        }
    }
}
