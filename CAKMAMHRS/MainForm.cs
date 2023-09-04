using CAKMAMHRS.Classes;

namespace CAKMAMHRS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
        }

        void FillGridView()
        {
            List<Appointment> AppointmentList = new List<Appointment>();

            Appointment appointment = new Appointment();

            AppointmentList = appointment.GetAppointment();


            dataGridView1.DataSource = AppointmentList;

        }


        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void MainForm_Activated()
        {
            FillGridView();

        }





        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            newAppointment newform = new newAppointment();
            newform.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
            AdjustGrid();

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            editAppointment();
        }

        void editAppointment()
        {
            int appointmentid;

            appointmentid = (int)dataGridView1.CurrentRow.Cells[0].Value;

            editAppointment editapp = new editAppointment(appointmentid);
            editapp.ShowDialog();




        }

        void deleteAppo()
        {

            int appoid;

            appoid = (int)dataGridView1.CurrentRow.Cells[0].Value;


            string? appoDate = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            string message = "Sure to delete your appo in the date " + appoDate + "?";
            DialogResult dr = MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Appointment appointment = new Appointment();
                appointment.DeleteAppo(appoid);

            }


        }

        void AdjustGrid()
        {
            dataGridView1.Columns[0].HeaderText = "ID";

            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 275;
            dataGridView1.Columns[3].Width = 275;
            dataGridView1.Columns[4].Width = 250;
            dataGridView1.Columns[5].Width = 150;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteAppo();
            FillGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datestable dateform = new datestable();
            dateform.ShowDialog();

        }
    }
}