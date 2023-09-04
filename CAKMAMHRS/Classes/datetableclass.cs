using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAKMAMHRS.Classes
{
    public class datetableclass
    {
        public int ID { get; set; }
        public string? YIL { get; set; }

        public string? AY { get; set; }

        public string? GUN { get; set; }

        public string? NINE { get; set; }
        public string? TEN { get; set; }

        public string? ELEVEN { get; set; }

        public string? TWELVE { get; set; }

        public string? ONE { get; set; }

        public string? TWO { get; set; }

        public string? THREE { get; set; }


        public List<datetableclass> GetDataTable()
        {
            List<datetableclass> daatableList = new List<datetableclass>();

            Appointment appolink = new Appointment();

            SqlConnection con = new SqlConnection(appolink.connectionString);

            string selectSQL = "SELECT ID, YIL, AY, GUN, [09.00], [10.00], [11.00], [12.00], [13.00], [14.00], [15.00] from DATETABLE";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    datetableclass data = new datetableclass();

                    data.ID = Convert.ToInt32(dr["ID"]);
                    data.YIL = dr["YIL"].ToString();
                    data.AY = dr["AY"].ToString();
                    data.GUN = dr["GUN"].ToString();
                    data.NINE = dr["09.00"].ToString();
                    data.TEN = dr["10.00"].ToString();
                    data.ELEVEN = dr["11.00"].ToString();
                    data.TWELVE = dr["12.00"].ToString();
                    data.ONE = dr["13.00"].ToString();
                    data.TWO = dr["14.00"].ToString();
                    data.THREE = dr["15.00"].ToString();

                    daatableList.Add(data);


                }

            }
            return daatableList;
        } //datatable view 


    }
}
