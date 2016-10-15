using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess;

namespace Tenants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1( int ts)
        {
            InitializeComponent();
            txtapartiment.Text = ts.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClsSqlServer searchcommand = new ClsSqlServer();
                DataSet dset = searchcommand.getCustomers(txtapartiment.Text);
                int room = Convert.ToInt32(txtapartiment.Text);

                if (string.IsNullOrEmpty(txtapartiment.Text))
                {
                    MessageBox.Show("Sorry, Make sure you fill the Apartment field", "Error");
                }
                //if (room < 200 || room > 250)
                //{
                //    MessageBox.Show("Make sure you choose the room between 200 and 250.", "Error");
                //    txtapartiment.Focus();
                //}

                else
                {
                    txtfname.Text = dset.Tables[0].Rows[0][1].ToString();
                    txtlname.Text = dset.Tables[0].Rows[0][2].ToString();
                    cmbgender.Text = dset.Tables[0].Rows[0][3].ToString();
                    txtphone.Text = dset.Tables[0].Rows[0][4].ToString();
                    cmbpayment.Text = dset.Tables[0].Rows[0][5].ToString();
                    dTPicker1.Text = dset.Tables[0].Rows[0][6].ToString();
                }

            }
            catch(Exception m)
            {
                MessageBox.Show("Sorry, Record doesn't exist.", "Error");
            }
        }
        

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            ClsSqlServer objinsert = new ClsSqlServer();

            if (txtapartiment.Text == "" || txtfname.Text == "" || txtlname.Text == "" || cmbgender.Text == "" || txtphone.Text == "" || cmbpayment.Text == "")
            {
                MessageBox.Show("Make sure you fill every field!");
            }

            else
            {
                try
                {
                    objinsert.InsertCustomer(txtapartiment.Text, txtfname.Text, txtlname.Text, cmbgender.Text, txtphone.Text, cmbpayment.Text, dTPicker1.Value);
                    MessageBox.Show("Data Inserted Successfully");

                    txtapartiment.Text = "";
                    txtfname.Text = "";
                    txtlname.Text = "";
                    cmbgender.Text = "";
                    txtphone.Text = "";
                    cmbpayment.Text = "";
                    dTPicker1.Value = DateTime.Today;
                    //}
                }

                catch
                {
                    // return false;
                    MessageBox.Show("This unit is currently in use, choose another one", "Error");
                    txtapartiment.Focus();
                }
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ClsSqlServer objupdate = new ClsSqlServer();
            objupdate.UpdateCustomer(txtapartiment.Text, txtfname.Text, txtlname.Text, cmbgender.Text, txtphone.Text, cmbpayment.Text, dTPicker1.Value);
            MessageBox.Show("Data Updated Successfully");

            txtapartiment.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            cmbgender.Text = "";
            txtphone.Text = "";
            cmbpayment.Text = "";
            dTPicker1.Value = DateTime.Today;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the resident in " + txtapartiment.Text + "?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClsSqlServer DeleteCommand = new ClsSqlServer();
                DeleteCommand.DeleteCustomer(txtapartiment.Text);

                MessageBox.Show("Data Deleted Successfully", "Information");
                txtapartiment.Text = "";
                txtfname.Text = "";
                txtlname.Text = "";
                cmbgender.Text = "";
                txtphone.Text = "";
                cmbpayment.Text = "";
                dTPicker1.Value = DateTime.Today;
            }
            else
            {
                txtapartiment.Focus();
            }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            //string x = txtphone.Text;

            //double y = Double.Parse(x);

            //txtphone.Text = String.Format("{0:###-###-####}", y);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtapartiment.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            cmbgender.Text = "";
            txtphone.Text = "";
            cmbpayment.Text = "";
            dTPicker1.Value = DateTime.Today;
        }

        private void txtapartiment_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtapartiment.Text))
            {
                erpapt.SetError(txtapartiment, "Please enter the apartment number");
            }

            else
            {
                erpapt.Clear();
            }
        }

        private void txtfname_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtfname.Text))
            {
                erpfname.SetError(txtfname, "Enter your first name");
            }

            else
            {
                erpfname.Dispose();
            }
        }

        private void txtlname_Leave(object sender, EventArgs e)
        {
            if(txtlname.Text=="")
            {
                erplname.SetError(txtlname, "Please enter your last name");
            }

            else
            {
                erplname.Dispose();
            }
        }

        private void cmbgender_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbgender.Text))
            {
                erpgender.SetError(cmbgender, "Select gender");
            }

            else
            {
                erpgender.Clear();
            }
        }

        private void txtphone_Leave(object sender, EventArgs e)
        {
            //string x = txtphone.Text;

            //double y = Double.Parse(x);

            //txtphone.Text = String.Format("{0:(###) ###-####}", y);

            ulong num;

            if (txtphone.Text.Length == 10 && ulong.TryParse(txtphone.Text, out num))
            {

                string pn = txtphone.Text;

                txtphone.Text = String.Format("({0}) {1}-{2}", pn.Substring(0, 3), pn.Substring(3, 3), pn.Substring(6));

            }

            else
            {

                MessageBox.Show("Invalid phone number, please change");

                txtphone.Focus();

            }

            //if(string.IsNullOrEmpty(txtphone.Text))
            //{
            //    erpphone.SetError(txtphone,"Please enter your phone number");
            //}
            //else
            //{
            //    erpphone.Clear();
            //}
        }

        private void cmbpayment_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbpayment.Text))
            {
                erppay.SetError(cmbpayment, "Select the payment period");
            }
            else
            {
                erppay.Clear();
            }
        }

        private void dTPicker1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(dTPicker1.Text))
            {
                erpentrance.SetError(dTPicker1, "Please enter the entry date");
            }

            else
            {
                erpentrance.Clear();
            }
        }

        private void btnchooseapartment_Click(object sender, EventArgs e)
        {
            this.Hide();
            var obj = new lblRooms();
            obj.FormClosed += (s, args) => this.Close();
            obj.Show();
            
        }

       
    }
}
