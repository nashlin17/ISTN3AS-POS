namespace ISTN3AS
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.tbxPassword_Login = new System.Windows.Forms.TextBox();
            this.tbxUsername_Login = new System.Windows.Forms.TextBox();
            this.btnExit2Home = new System.Windows.Forms.Button();
            this.btnStaffSign = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.getLoginDS = new ISTN3AS.group6DataSet();
            this.getLoginDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getLoginDetailsTableAdapter = new ISTN3AS.group6DataSetTableAdapters.GetLoginDetailsTableAdapter();
            this.tableAdapterManager = new ISTN3AS.group6DataSetTableAdapters.TableAdapterManager();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLoginDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLoginDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.tbxPassword_Login);
            this.pnlLogin.Controls.Add(this.tbxUsername_Login);
            this.pnlLogin.Controls.Add(this.btnExit2Home);
            this.pnlLogin.Controls.Add(this.btnStaffSign);
            this.pnlLogin.Controls.Add(this.label5);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.pictureBox4);
            this.pnlLogin.Controls.Add(this.pictureBox3);
            this.pnlLogin.Controls.Add(this.pictureBox2);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Location = new System.Drawing.Point(235, 153);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(350, 434);
            this.pnlLogin.TabIndex = 0;
            // 
            // tbxPassword_Login
            // 
            this.tbxPassword_Login.Location = new System.Drawing.Point(92, 252);
            this.tbxPassword_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPassword_Login.Name = "tbxPassword_Login";
            this.tbxPassword_Login.Size = new System.Drawing.Size(197, 22);
            this.tbxPassword_Login.TabIndex = 14;
            this.tbxPassword_Login.Text = "Chill";
            this.tbxPassword_Login.UseSystemPasswordChar = true;
            // 
            // tbxUsername_Login
            // 
            this.tbxUsername_Login.Location = new System.Drawing.Point(92, 192);
            this.tbxUsername_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxUsername_Login.Name = "tbxUsername_Login";
            this.tbxUsername_Login.Size = new System.Drawing.Size(197, 22);
            this.tbxUsername_Login.TabIndex = 13;
            this.tbxUsername_Login.Text = "netflix";
            // 
            // btnExit2Home
            // 
            this.btnExit2Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnExit2Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit2Home.FlatAppearance.BorderSize = 0;
            this.btnExit2Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit2Home.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2Home.Location = new System.Drawing.Point(48, 321);
            this.btnExit2Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit2Home.Name = "btnExit2Home";
            this.btnExit2Home.Size = new System.Drawing.Size(84, 30);
            this.btnExit2Home.TabIndex = 12;
            this.btnExit2Home.Text = "Exit";
            this.btnExit2Home.UseVisualStyleBackColor = false;
            this.btnExit2Home.Click += new System.EventHandler(this.btnExit2Home_Click);
            // 
            // btnStaffSign
            // 
            this.btnStaffSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(230)))), ((int)(((byte)(175)))));
            this.btnStaffSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaffSign.FlatAppearance.BorderSize = 0;
            this.btnStaffSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffSign.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffSign.Location = new System.Drawing.Point(200, 321);
            this.btnStaffSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStaffSign.Name = "btnStaffSign";
            this.btnStaffSign.Size = new System.Drawing.Size(99, 30);
            this.btnStaffSign.TabIndex = 11;
            this.btnStaffSign.Text = "Sign In";
            this.btnStaffSign.UseVisualStyleBackColor = false;
            this.btnStaffSign.Click += new System.EventHandler(this.btnStaffSign_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Castellar", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "login";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Castellar", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "TOTAL SPORTS";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Castellar", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "welcome to ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ISTN3AS.Properties.Resources.exit1;
            this.pictureBox4.Location = new System.Drawing.Point(23, 309);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(136, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ISTN3AS.Properties.Resources.signIn;
            this.pictureBox3.Location = new System.Drawing.Point(184, 309);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(136, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ISTN3AS.Properties.Resources.pass2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(23, 236);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // getLoginDS
            // 
            this.getLoginDS.DataSetName = "getLoginDS";
            this.getLoginDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getLoginDetailsBindingSource
            // 
            this.getLoginDetailsBindingSource.DataMember = "GetLoginDetails";
            this.getLoginDetailsBindingSource.DataSource = this.getLoginDS;
            // 
            // getLoginDetailsTableAdapter
            // 
            this.getLoginDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandTblTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MemberTblTableAdapter = null;
            this.tableAdapterManager.OrderLineTblTableAdapter = null;
            this.tableAdapterManager.OrderTblTableAdapter = null;
            this.tableAdapterManager.ProductTblTableAdapter = null;
            this.tableAdapterManager.ReturnProductTblTableAdapter = null;
            this.tableAdapterManager.ReturnTblTableAdapter = null;
            this.tableAdapterManager.StaffTblTableAdapter = null;
            this.tableAdapterManager.SupplierOrderTblTableAdapter = null;
            this.tableAdapterManager.SupplierProductLineTableAdapter = null;
            this.tableAdapterManager.SupplierTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISTN3AS.group6DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ISTN3AS.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 703);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLoginDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getLoginDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStaffSign;
        private System.Windows.Forms.Button btnExit2Home;
        private group6DataSet getLoginDS;
        private System.Windows.Forms.BindingSource getLoginDetailsBindingSource;
        private group6DataSetTableAdapters.GetLoginDetailsTableAdapter getLoginDetailsTableAdapter;
        private group6DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbxUsername_Login;
        private System.Windows.Forms.TextBox tbxPassword_Login;
    }
}