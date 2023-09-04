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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAKMAMHRS
{
    public partial class editAppointment : Form
    {
        int selectedappointmentid;

        public editAppointment(int appointmentid)
        {
            InitializeComponent();
            selectedappointmentid = appointmentid;

            editDataAppointment();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            editAppoData();
            this.Close();

        }

        void editDataAppointment()
        {
            Appointment appointment = new Appointment();
            appointment = appointment.GetEditAppointment(selectedappointmentid);



            textBox1.Text = appointment.A_Date.ToString();
            textBox5.Text = appointment.room;
            textBox3.Text = appointment.doctor_name;
            textBox2.Text = appointment.patient_name;
            textBox4.Text = appointment.status;


        }

        void editAppoData()
        {
            Appointment appointment = new Appointment();

            appointment.AppointmentID = selectedappointmentid;
            appointment.A_Date = Convert.ToDateTime(textBox1.Text);
            appointment.room = textBox5.Text;
            appointment.doctor_name = textBox3.Text;
            appointment.patient_name = textBox2.Text;
            appointment.status = textBox4.Text;

            appointment.editAppo(appointment);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
