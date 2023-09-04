using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAKMAMHRS.Classes
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime A_Date { get; set; }

        public string? room { get; set; }

        public string? doctor_name { get; set; }

        public string? patient_name { get; set; }
        public string? status { get; set; }

        //string connectionString = "Server=DESKTOP-JH0VPAC; Database=testdb;Integrated Security=True;TrustServerCertificate=True";
        public string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


        public List<Appointment> GetAppointment()
        {
            List<Appointment> AppointmentList = new List<Appointment>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "SELECT AppointmentID, A_Date, room, doctor_name, patient_name, status from GetAppointmentData";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Appointment appointment = new Appointment();

                    appointment.AppointmentID = Convert.ToInt32(dr["AppointmentID"]);
                    appointment.A_Date = Convert.ToDateTime(dr["A_Date"]);
                    appointment.room = dr["room"].ToString();
                    appointment.doctor_name = dr["doctor_name"].ToString();
                    appointment.patient_name = dr["patient_name"].ToString();
                    appointment.status = dr["status"].ToString();

                    AppointmentList.Add(appointment);


                }

            }
            return AppointmentList;
        }





        public void CreateNewAppointment(Appointment appointment)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("ADDAPPOINTMENT", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@A_Date", appointment.A_Date));
            cmd.Parameters.Add(new SqlParameter("@room", appointment.room));
            cmd.Parameters.Add(new SqlParameter("@doctorName", appointment.doctor_name));
            cmd.Parameters.Add(new SqlParameter("@patientName", appointment.patient_name));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public Appointment GetEditAppointment(int appointmentid)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select AppointmentID, A_Date, room, doctor_name, patient_name, status from GetAppointmentData where appointmentID = " + appointmentid;
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            Appointment appointment = new Appointment();

            if (dr != null)
            {
                while (dr.Read())
                {


                    appointment.AppointmentID = Convert.ToInt32(dr["AppointmentID"]);
                    appointment.A_Date = Convert.ToDateTime(dr["A_Date"]);
                    appointment.room = dr["room"].ToString();
                    appointment.doctor_name = dr["doctor_name"].ToString();
                    appointment.patient_name = dr["patient_name"].ToString();
                    appointment.status = dr["status"].ToString();
                }

            }

            return appointment;


        }

        public void editAppo(Appointment appointment)
        {

            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("UPDATEAPPOINTMENT", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@AppointmentID", appointment.AppointmentID));
            cmd.Parameters.Add(new SqlParameter("@A_Date", appointment.A_Date));
            cmd.Parameters.Add(new SqlParameter("@room", appointment.room));
            cmd.Parameters.Add(new SqlParameter("@doctorName", appointment.doctor_name));
            cmd.Parameters.Add(new SqlParameter("@patientName", appointment.patient_name));
            cmd.Parameters.Add(new SqlParameter("@status", appointment.status));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeleteAppo(int appoID)
        {
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("DELETEAPPO", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@APPOID", appoID));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

