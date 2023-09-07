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
            Appointment appointment = new Appointment();
            /*textBox1.Text.Substring(0, 4) + "-" + textBox1.Text.Substring(5, 2) + "-"
            +textBox1.Text.Substring(8, 2) + " " + textBox1.Text.Substring(11, 2) + ":" + textBox1.Text.Substring(14, 2)*/
            appointment.A_Date = Convert.ToDateTime(textBox1.Text);
            appointment.room = textBox5.Text;
            appointment.doctor_name = textBox3.Text;
            appointment.patient_name = textBox2.Text;

            //appointment.UNAVALIABLE(appointment);
            appointment.CreateNewAppointment(appointment);
        }
    }
}
