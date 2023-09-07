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
    public partial class datestable : Form
    {


        public datestable()
        {
            InitializeComponent();
            FillGridViewDate();
            AdjustGridDate();


        }

        void AdjustGridDate()
        {
            double width = (dataGridViewDateTAble.Width - (3 * (dataGridViewDateTAble.Width / 18))) / 7.85;


            dataGridViewDateTAble.Columns[0].Width = dataGridViewDateTAble.Width / 18;
            dataGridViewDateTAble.Columns[1].Width = dataGridViewDateTAble.Width / 18;
            dataGridViewDateTAble.Columns[2].Width = dataGridViewDateTAble.Width / 18;
            dataGridViewDateTAble.Columns[3].Width = dataGridViewDateTAble.Width / 18;
            dataGridViewDateTAble.Columns[4].Width = (int)width;
            dataGridViewDateTAble.Columns[5].Width = (int)width;
            dataGridViewDateTAble.Columns[6].Width = (int)width;
            dataGridViewDateTAble.Columns[7].Width = (int)width;
            dataGridViewDateTAble.Columns[8].Width = (int)width;
            dataGridViewDateTAble.Columns[9].Width = (int)width;
            dataGridViewDateTAble.Columns[10].Width = (int)width;
        }

        private void datestable_Load(object sender, EventArgs e)
        {

        }

        void FillGridViewDate()
        {
            List<datetableclass> daatablelist = new List<datetableclass>();

            datetableclass daa = new datetableclass();

            daatablelist = daa.GetDataTable();


            dataGridViewDateTAble.DataSource = daatablelist;

        }

        public string? datetime()
        {
            string? year;
            string? month;
            string? day;
            string? hour;
            string? sdatetime;
            int indexofcolumn = dataGridViewDateTAble.CurrentCell.ColumnIndex;
            int indexofrow = dataGridViewDateTAble.CurrentCell.RowIndex;
            hour = (indexofcolumn + 5).ToString();
            year = dataGridViewDateTAble.Rows[indexofrow].Cells[1].Value.ToString();
            month = dataGridViewDateTAble.Rows[indexofrow].Cells[2].Value.ToString();
            day = dataGridViewDateTAble.Rows[indexofrow].Cells[3].Value.ToString();
            sdatetime = year + "-" + month + "-" + day + " " + hour + ":" + "00";

            return sdatetime;

        }

        void textboxeditor()
        {

            textBox1.Text = datetime();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textboxeditor();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            newtableappointment newpage = new newtableappointment(textBox1.Text);
            newpage.ShowDialog();


        }

        private void dataGridViewDateTAble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
