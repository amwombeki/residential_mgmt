using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace Tenants
{
    public partial class lblRooms : Form
    {
        
        public lblRooms()
        {
            InitializeComponent();
            
            
        }

        private void btn101_Click(object sender, EventArgs e)
        {           
            int ds = 101;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();                 
        }

        private void btn102_Click(object sender, EventArgs e)
        {          
            int ds = 102;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            int ds = 103;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();          
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            int ds = 104;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();         
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            int ds = 105;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();           
        }

        private void btn201_Click(object sender, EventArgs e)
        {
            int ds = 201;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn202_Click(object sender, EventArgs e)
        {
            int ds = 202;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn203_Click(object sender, EventArgs e)
        {
            int ds = 203;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn204_Click(object sender, EventArgs e)
        {
            int ds = 204;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn205_Click(object sender, EventArgs e)
        {
            int ds = 205;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn217_Click(object sender, EventArgs e)
        {
            int ds = 217;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void btn218_Click(object sender, EventArgs e)
        {
            int ds = 218;
            this.Hide();
            var frm = new Form1(ds);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
        }

        private void lblRooms_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-J6KRI77\SQLEXPRESS; Initial Catalog = SELLnBUY; Integrated Security = true";
            string cmdstr = "SELECT Apartment_No FROM Apartment";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand com = new SqlCommand(cmdstr, con);
           
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                int room = int.Parse(r["Apartment_No"].ToString());

                switch (room)
                {
                    case 102:
                        btn102.Enabled = false;
                        break;
                    case 201:
                        btn201.Enabled = false;
                        break;
                    case 202:
                        btn202.Enabled = false;
                        break;
                    case 203:
                        btn203.Enabled = false;
                        break;
                    case 204:
                        btn204.Enabled = false;
                        break;

                }
            }
            con.Close();

        }
    }
}
