using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DataAccess
{
    public class ClsSqlServer
    {
        public DataSet getCustomers(string txtapartiment)
        {
            string constr = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            string comstr = "SELECT * FROM Apartment WHERE Apartment_No = '" + txtapartiment +"'";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            SqlCommand com = new SqlCommand(comstr, con);

            DataSet dset = new DataSet();
            SqlDataAdapter objadapter = new SqlDataAdapter(com);
            objadapter.Fill(dset);

            //dataGridView1.DataSource = dset.Tables[0];
            con.Close();

            return dset;
        }

        public void InsertCustomer(string Apartiment, string Fname, string Lname, string Gender, string Phone, string Payment, DateTime EntryDate)
        {


            string constr = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            string cmdstr = "INSERT INTO Apartment VALUES(@aptno, @fname, @lname, @gender, @phone, @payperiod, @doe)";
            SqlConnection con = new SqlConnection(constr);

            con.Open();
    //SqlCommand cmd = new SqlCommand("select count(*) from Apartment where  Apartment_No= @aptno",con);

            //try
            //{
      // string cmdstr = "INSERT INTO Apartment VALUES(@aptno, @fname, @lname, @gender, @phone, @payperiod, @doe)";
       SqlCommand com = new SqlCommand(cmdstr, con);
       //com.CommandType = CommandType.StoredProcedure;
       com.Parameters.AddWithValue("@aptno", Apartiment);
       com.Parameters.AddWithValue("@fname", Fname);
       com.Parameters.AddWithValue("@lname", Lname);


       com.Parameters.AddWithValue("@gender", Gender);
       com.Parameters.AddWithValue("@phone", Phone);
       com.Parameters.AddWithValue("@payperiod", Payment);
       com.Parameters.AddWithValue("@doe", EntryDate);
       com.ExecuteNonQuery();
       
           //}



       // return true;


       //}

       //catch
       //{
       //   // return false;
       //    MessageBox.Show("Record already exists", "Error");
       //}

       //finally
       //{
       //    con.Close();
       //}
       con.Close();
   }



        public bool UpdateCustomer(string Apartiment, string Fname, string Lname, string Sex, string Phone, string Payment, DateTime EntryDate)
        {

            string constr = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            string cmdstr = "UPDATE Apartment SET Apartment_No = '"
                + Apartiment +"', First_Name = '"
                + Fname +"', Last_Name= '"
                + Lname +"', Gender='"
                + Sex +"', Telephone='"
                + Phone +"', Payment_Period='"
                + Payment +"', Date_Of_Entry='"
                + EntryDate +"' WHERE Apartment_No = '" + Apartiment +"'";
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand(cmdstr, con);

                com.ExecuteNonQuery();

                return true;
               

            }

            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                con.Close();
            }
        }

        public bool DeleteCustomer(string Apartment)
         {
             string constr = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
             SqlConnection con = new SqlConnection(constr);

             string cmdstr = "DELETE FROM Apartment WHERE Apartment_No = '" + Apartment + "'";
             con.Open();
             

            //if (MessageBox.Show("Are you sure you want to delete " + Apartment + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
               

                try
                {
                SqlCommand com = new SqlCommand(cmdstr, con);
                com.ExecuteNonQuery();

                    return true;
                }

                catch (Exception ed)
                {
                    return false;
                }


                finally
                {
                    con.Close();
                
                
            }
           
        }
    }
}
