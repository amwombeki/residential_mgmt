namespace Tenants
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblaptmt = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblpayment = new System.Windows.Forms.Label();
            this.txtapartiment = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.cmbpayment = new System.Windows.Forms.ComboBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbldoentry = new System.Windows.Forms.Label();
            this.dTPicker1 = new System.Windows.Forms.DateTimePicker();
            this.erpapt = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpfname = new System.Windows.Forms.ErrorProvider(this.components);
            this.erplname = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpgender = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpphone = new System.Windows.Forms.ErrorProvider(this.components);
            this.erppay = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpentrance = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnchooseapartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpapt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpfname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erplname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpgender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erppay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpentrance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblaptmt
            // 
            this.lblaptmt.AutoSize = true;
            this.lblaptmt.Location = new System.Drawing.Point(12, 20);
            this.lblaptmt.Name = "lblaptmt";
            this.lblaptmt.Size = new System.Drawing.Size(57, 13);
            this.lblaptmt.TabIndex = 0;
            this.lblaptmt.Text = "Apartiment";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(12, 46);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(57, 13);
            this.lblfname.TabIndex = 1;
            this.lblfname.Text = "First Name";
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(12, 74);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(58, 13);
            this.lbllname.TabIndex = 2;
            this.lbllname.Text = "Last Name";
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Location = new System.Drawing.Point(9, 179);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(58, 13);
            this.lblpayment.TabIndex = 4;
            this.lblpayment.Text = "Pay Period";
            // 
            // txtapartiment
            // 
            this.txtapartiment.Location = new System.Drawing.Point(73, 17);
            this.txtapartiment.Name = "txtapartiment";
            this.txtapartiment.Size = new System.Drawing.Size(100, 20);
            this.txtapartiment.TabIndex = 5;
            this.txtapartiment.Leave += new System.EventHandler(this.txtapartiment_Leave);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(73, 48);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 6;
            this.txtfname.Leave += new System.EventHandler(this.txtfname_Leave);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(73, 79);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 20);
            this.txtlname.TabIndex = 7;
            this.txtlname.Leave += new System.EventHandler(this.txtlname_Leave);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(13, 151);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(38, 13);
            this.lblphone.TabIndex = 3;
            this.lblphone.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(73, 148);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 20);
            this.txtphone.TabIndex = 9;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(189, 16);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 11;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(189, 64);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(189, 119);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(189, 169);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cmbpayment
            // 
            this.cmbpayment.FormattingEnabled = true;
            this.cmbpayment.Items.AddRange(new object[] {
            "Monthly",
            "Yearly"});
            this.cmbpayment.Location = new System.Drawing.Point(73, 179);
            this.cmbpayment.Name = "cmbpayment";
            this.cmbpayment.Size = new System.Drawing.Size(100, 21);
            this.cmbpayment.TabIndex = 10;
            this.cmbpayment.Leave += new System.EventHandler(this.cmbpayment_Leave);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(12, 119);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(42, 13);
            this.lblgender.TabIndex = 17;
            this.lblgender.Text = "Gender";
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(73, 111);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(100, 21);
            this.cmbgender.TabIndex = 8;
            this.cmbgender.Leave += new System.EventHandler(this.cmbgender_Leave);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(189, 217);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbldoentry
            // 
            this.lbldoentry.AutoSize = true;
            this.lbldoentry.Location = new System.Drawing.Point(13, 216);
            this.lbldoentry.Name = "lbldoentry";
            this.lbldoentry.Size = new System.Drawing.Size(50, 13);
            this.lbldoentry.TabIndex = 19;
            this.lbldoentry.Text = "Entrance";
            // 
            // dTPicker1
            // 
            this.dTPicker1.CustomFormat = "yyyy-MM-dd";
            this.dTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPicker1.Location = new System.Drawing.Point(73, 216);
            this.dTPicker1.Name = "dTPicker1";
            this.dTPicker1.Size = new System.Drawing.Size(100, 20);
            this.dTPicker1.TabIndex = 20;
            this.dTPicker1.Leave += new System.EventHandler(this.dTPicker1_Leave);
            // 
            // erpapt
            // 
            this.erpapt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpapt.ContainerControl = this;
            // 
            // erpfname
            // 
            this.erpfname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpfname.ContainerControl = this;
            // 
            // erplname
            // 
            this.erplname.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erplname.ContainerControl = this;
            // 
            // erpgender
            // 
            this.erpgender.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpgender.ContainerControl = this;
            // 
            // erpphone
            // 
            this.erpphone.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpphone.ContainerControl = this;
            // 
            // erppay
            // 
            this.erppay.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erppay.ContainerControl = this;
            // 
            // erpentrance
            // 
            this.erpentrance.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpentrance.ContainerControl = this;
            // 
            // btnchooseapartment
            // 
            this.btnchooseapartment.Location = new System.Drawing.Point(299, 15);
            this.btnchooseapartment.Name = "btnchooseapartment";
            this.btnchooseapartment.Size = new System.Drawing.Size(122, 23);
            this.btnchooseapartment.TabIndex = 21;
            this.btnchooseapartment.Text = "Choose Apartment";
            this.btnchooseapartment.UseVisualStyleBackColor = true;
            this.btnchooseapartment.Click += new System.EventHandler(this.btnchooseapartment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 314);
            this.Controls.Add(this.btnchooseapartment);
            this.Controls.Add(this.dTPicker1);
            this.Controls.Add(this.lbldoentry);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.cmbgender);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.cmbpayment);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtapartiment);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.lblaptmt);
            this.Name = "Form1";
            this.Text = "Residential Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpapt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpfname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erplname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpgender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erppay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpentrance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblaptmt;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.TextBox txtapartiment;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox cmbpayment;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbldoentry;
        private System.Windows.Forms.DateTimePicker dTPicker1;
        private System.Windows.Forms.ErrorProvider erpapt;
        private System.Windows.Forms.ErrorProvider erpfname;
        private System.Windows.Forms.ErrorProvider erplname;
        private System.Windows.Forms.ErrorProvider erpgender;
        private System.Windows.Forms.ErrorProvider erpphone;
        private System.Windows.Forms.ErrorProvider erppay;
        private System.Windows.Forms.ErrorProvider erpentrance;
        private System.Windows.Forms.Button btnchooseapartment;
    }
}

