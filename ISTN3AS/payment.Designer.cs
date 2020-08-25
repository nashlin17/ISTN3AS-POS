namespace ISTN3AS
{
    partial class payment
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
            this.pnlCompany = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCompany = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpItemPayment = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProcessPayment_Payment = new System.Windows.Forms.Button();
            this.btnCancel_Payment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCustomerChange_Payment = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxAmtPaid_Payment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotal_Payment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDiscount_Payment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblSubTotal_Payment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpReturn = new System.Windows.Forms.TabPage();
            this.panel24 = new System.Windows.Forms.Panel();
            this.dtpReturnDate_Returns = new System.Windows.Forms.DateTimePicker();
            this.tbxReason_Return = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCellNo_Return = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.btnProcess_Return = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblTotal_Return = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.globalOrdeNoGrid = new System.Windows.Forms.DataGridView();
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDS = new ISTN3AS.ProductDS();
            this.returnTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnProductTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderLineTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTblTableAdapter = new ISTN3AS.ProductDSTableAdapters.OrderTblTableAdapter();
            this.tableAdapterManager = new ISTN3AS.ProductDSTableAdapters.TableAdapterManager();
            this.orderLineTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderLineTblTableAdapter = new ISTN3AS.ProductDSTableAdapters.OrderLineTblTableAdapter();
            this.updateProduantity1 = new ISTN3AS.ProductDSTableAdapters.updateProduantity();
            this.returnProductTblTableAdapter = new ISTN3AS.ProductDSTableAdapters.ReturnProductTblTableAdapter();
            this.updateProduantity2 = new ISTN3AS.ProductDSTableAdapters.updateProduantity();
            this.returnTblTableAdapter = new ISTN3AS.ProductDSTableAdapters.ReturnTblTableAdapter();
            this.returnProductTblBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCompany.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpItemPayment.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpReturn.SuspendLayout();
            this.panel24.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalOrdeNoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProductTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineTblBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProductTblBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCompany
            // 
            this.pnlCompany.AutoSize = true;
            this.pnlCompany.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlCompany.BackgroundImage = global::ISTN3AS.Properties.Resources.Frost;
            this.pnlCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompany.Controls.Add(this.lblCompany);
            this.pnlCompany.Controls.Add(this.btnExit);
            this.pnlCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCompany.Location = new System.Drawing.Point(0, 0);
            this.pnlCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCompany.Name = "pnlCompany";
            this.pnlCompany.Size = new System.Drawing.Size(531, 80);
            this.pnlCompany.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ISTN3AS.Properties.Resources.Frost;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Castellar", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(478, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompany.Font = new System.Drawing.Font("Castellar", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCompany.Image = global::ISTN3AS.Properties.Resources.Frost;
            this.lblCompany.Location = new System.Drawing.Point(0, 0);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(529, 78);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "TOTOAL SPORTS";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpItemPayment);
            this.tabControl1.Controls.Add(this.tpReturn);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-5, 59);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 565);
            this.tabControl1.TabIndex = 6;
            // 
            // tpItemPayment
            // 
            this.tpItemPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpItemPayment.Controls.Add(this.groupBox4);
            this.tpItemPayment.Location = new System.Drawing.Point(4, 22);
            this.tpItemPayment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpItemPayment.Name = "tpItemPayment";
            this.tpItemPayment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpItemPayment.Size = new System.Drawing.Size(524, 539);
            this.tpItemPayment.TabIndex = 0;
            this.tpItemPayment.Text = "mainPay";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnProcessPayment_Payment);
            this.groupBox4.Controls.Add(this.btnCancel_Payment);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Font = new System.Drawing.Font("Gadugi", 12F);
            this.groupBox4.Location = new System.Drawing.Point(68, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(392, 497);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnProcessPayment_Payment
            // 
            this.btnProcessPayment_Payment.BackColor = System.Drawing.Color.White;
            this.btnProcessPayment_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcessPayment_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessPayment_Payment.Image = global::ISTN3AS.Properties.Resources.process;
            this.btnProcessPayment_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessPayment_Payment.Location = new System.Drawing.Point(220, 436);
            this.btnProcessPayment_Payment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcessPayment_Payment.Name = "btnProcessPayment_Payment";
            this.btnProcessPayment_Payment.Size = new System.Drawing.Size(134, 46);
            this.btnProcessPayment_Payment.TabIndex = 8;
            this.btnProcessPayment_Payment.Text = "Process";
            this.btnProcessPayment_Payment.UseVisualStyleBackColor = false;
            this.btnProcessPayment_Payment.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCancel_Payment
            // 
            this.btnCancel_Payment.BackColor = System.Drawing.Color.White;
            this.btnCancel_Payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel_Payment.Image = global::ISTN3AS.Properties.Resources.cancel__1_;
            this.btnCancel_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel_Payment.Location = new System.Drawing.Point(46, 436);
            this.btnCancel_Payment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel_Payment.Name = "btnCancel_Payment";
            this.btnCancel_Payment.Size = new System.Drawing.Size(134, 46);
            this.btnCancel_Payment.TabIndex = 7;
            this.btnCancel_Payment.Text = "Cancel";
            this.btnCancel_Payment.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::ISTN3AS.Properties.Resources.bank;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(382, 52);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pay With Card";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblCustomerChange_Payment);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(198, 171);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(190, 69);
            this.panel8.TabIndex = 5;
            // 
            // lblCustomerChange_Payment
            // 
            this.lblCustomerChange_Payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerChange_Payment.Location = new System.Drawing.Point(54, 29);
            this.lblCustomerChange_Payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerChange_Payment.Name = "lblCustomerChange_Payment";
            this.lblCustomerChange_Payment.Size = new System.Drawing.Size(82, 28);
            this.lblCustomerChange_Payment.TabIndex = 1;
            this.lblCustomerChange_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(44, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 28);
            this.label16.TabIndex = 0;
            this.label16.Text = "Change";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.tbxAmtPaid_Payment);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Location = new System.Drawing.Point(4, 171);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(190, 69);
            this.panel7.TabIndex = 4;
            // 
            // tbxAmtPaid_Payment
            // 
            this.tbxAmtPaid_Payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAmtPaid_Payment.Location = new System.Drawing.Point(26, 30);
            this.tbxAmtPaid_Payment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAmtPaid_Payment.Name = "tbxAmtPaid_Payment";
            this.tbxAmtPaid_Payment.Size = new System.Drawing.Size(150, 29);
            this.tbxAmtPaid_Payment.TabIndex = 1;
            this.tbxAmtPaid_Payment.TextChanged += new System.EventHandler(this.tbxAmtPaid_Payment_TextChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(43, 1);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "Amount Paid";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblTotal_Payment);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(5, 119);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 45);
            this.panel6.TabIndex = 3;
            // 
            // lblTotal_Payment
            // 
            this.lblTotal_Payment.Location = new System.Drawing.Point(68, 12);
            this.lblTotal_Payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Payment.Name = "lblTotal_Payment";
            this.lblTotal_Payment.Size = new System.Drawing.Size(82, 28);
            this.lblTotal_Payment.TabIndex = 1;
            this.lblTotal_Payment.Text = "350";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(14, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total: R";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblDiscount_Payment);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(5, 68);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(383, 47);
            this.panel5.TabIndex = 2;
            // 
            // lblDiscount_Payment
            // 
            this.lblDiscount_Payment.Location = new System.Drawing.Point(92, 12);
            this.lblDiscount_Payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount_Payment.Name = "lblDiscount_Payment";
            this.lblDiscount_Payment.Size = new System.Drawing.Size(82, 28);
            this.lblDiscount_Payment.TabIndex = 1;
            this.lblDiscount_Payment.Text = "50";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Disocunt: R";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblSubTotal_Payment);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(4, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 49);
            this.panel4.TabIndex = 0;
            // 
            // lblSubTotal_Payment
            // 
            this.lblSubTotal_Payment.Location = new System.Drawing.Point(92, 12);
            this.lblSubTotal_Payment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal_Payment.Name = "lblSubTotal_Payment";
            this.lblSubTotal_Payment.Size = new System.Drawing.Size(82, 28);
            this.lblSubTotal_Payment.TabIndex = 1;
            this.lblSubTotal_Payment.Text = "300";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(14, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subtotal: R";
            // 
            // tpReturn
            // 
            this.tpReturn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpReturn.Controls.Add(this.panel24);
            this.tpReturn.Controls.Add(this.groupBox2);
            this.tpReturn.Location = new System.Drawing.Point(4, 22);
            this.tpReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpReturn.Name = "tpReturn";
            this.tpReturn.Size = new System.Drawing.Size(524, 539);
            this.tpReturn.TabIndex = 2;
            this.tpReturn.Text = "return";
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel24.Controls.Add(this.dtpReturnDate_Returns);
            this.panel24.Controls.Add(this.tbxReason_Return);
            this.panel24.Controls.Add(this.label4);
            this.panel24.Controls.Add(this.tbxCellNo_Return);
            this.panel24.Controls.Add(this.label50);
            this.panel24.Controls.Add(this.label8);
            this.panel24.Location = new System.Drawing.Point(57, 89);
            this.panel24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(404, 168);
            this.panel24.TabIndex = 15;
            // 
            // dtpReturnDate_Returns
            // 
            this.dtpReturnDate_Returns.Enabled = false;
            this.dtpReturnDate_Returns.Location = new System.Drawing.Point(107, 35);
            this.dtpReturnDate_Returns.Name = "dtpReturnDate_Returns";
            this.dtpReturnDate_Returns.Size = new System.Drawing.Size(257, 20);
            this.dtpReturnDate_Returns.TabIndex = 19;
            // 
            // tbxReason_Return
            // 
            this.tbxReason_Return.Location = new System.Drawing.Point(107, 60);
            this.tbxReason_Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxReason_Return.Multiline = true;
            this.tbxReason_Return.Name = "tbxReason_Return";
            this.tbxReason_Return.Size = new System.Drawing.Size(257, 93);
            this.tbxReason_Return.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reasons : ";
            // 
            // tbxCellNo_Return
            // 
            this.tbxCellNo_Return.Location = new System.Drawing.Point(107, 10);
            this.tbxCellNo_Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCellNo_Return.MaxLength = 10;
            this.tbxCellNo_Return.Name = "tbxCellNo_Return";
            this.tbxCellNo_Return.Size = new System.Drawing.Size(257, 20);
            this.tbxCellNo_Return.TabIndex = 15;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(25, 9);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(131, 21);
            this.label50.TabIndex = 1;
            this.label50.Text = "Cell No: ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.btnProcess_Return);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.panel14);
            this.groupBox2.Font = new System.Drawing.Font("Gadugi", 12F);
            this.groupBox2.Location = new System.Drawing.Point(37, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(442, 497);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.Font = new System.Drawing.Font("Gadugi", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(72, 24);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(240, 36);
            this.label48.TabIndex = 9;
            this.label48.Text = "Customer Details";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcess_Return
            // 
            this.btnProcess_Return.BackColor = System.Drawing.Color.White;
            this.btnProcess_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess_Return.Image = global::ISTN3AS.Properties.Resources.process;
            this.btnProcess_Return.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess_Return.Location = new System.Drawing.Point(251, 436);
            this.btnProcess_Return.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcess_Return.Name = "btnProcess_Return";
            this.btnProcess_Return.Size = new System.Drawing.Size(134, 46);
            this.btnProcess_Return.TabIndex = 8;
            this.btnProcess_Return.Text = "Process";
            this.btnProcess_Return.UseVisualStyleBackColor = false;
            this.btnProcess_Return.Click += new System.EventHandler(this.btnProcess_Return_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::ISTN3AS.Properties.Resources.cancel__1_;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(77, 436);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 46);
            this.button8.TabIndex = 7;
            this.button8.Text = "Cancel";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.lblTotal_Return);
            this.panel14.Controls.Add(this.label19);
            this.panel14.Location = new System.Drawing.Point(20, 259);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(404, 45);
            this.panel14.TabIndex = 3;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // lblTotal_Return
            // 
            this.lblTotal_Return.Location = new System.Drawing.Point(84, 12);
            this.lblTotal_Return.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Return.Name = "lblTotal_Return";
            this.lblTotal_Return.Size = new System.Drawing.Size(82, 28);
            this.lblTotal_Return.TabIndex = 1;
            this.lblTotal_Return.Text = "350";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(14, 12);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "Total: R";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.globalOrdeNoGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(524, 539);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // globalOrdeNoGrid
            // 
            this.globalOrdeNoGrid.AutoGenerateColumns = false;
            this.globalOrdeNoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.globalOrdeNoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.cellNumDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.memIDDataGridViewTextBoxColumn});
            this.globalOrdeNoGrid.DataSource = this.orderTblBindingSource;
            this.globalOrdeNoGrid.Location = new System.Drawing.Point(35, 132);
            this.globalOrdeNoGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.globalOrdeNoGrid.Name = "globalOrdeNoGrid";
            this.globalOrdeNoGrid.RowHeadersWidth = 51;
            this.globalOrdeNoGrid.RowTemplate.Height = 24;
            this.globalOrdeNoGrid.Size = new System.Drawing.Size(392, 122);
            this.globalOrdeNoGrid.TabIndex = 0;
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            this.orderTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cellNumDataGridViewTextBoxColumn
            // 
            this.cellNumDataGridViewTextBoxColumn.DataPropertyName = "CellNum";
            this.cellNumDataGridViewTextBoxColumn.HeaderText = "CellNum";
            this.cellNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cellNumDataGridViewTextBoxColumn.Name = "cellNumDataGridViewTextBoxColumn";
            this.cellNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memIDDataGridViewTextBoxColumn
            // 
            this.memIDDataGridViewTextBoxColumn.DataPropertyName = "MemID";
            this.memIDDataGridViewTextBoxColumn.HeaderText = "MemID";
            this.memIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memIDDataGridViewTextBoxColumn.Name = "memIDDataGridViewTextBoxColumn";
            this.memIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTblBindingSource
            // 
            this.orderTblBindingSource.DataMember = "OrderTbl";
            this.orderTblBindingSource.DataSource = this.productDS;
            // 
            // productDS
            // 
            this.productDS.DataSetName = "ProductDS";
            this.productDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnTblBindingSource
            // 
            this.returnTblBindingSource.DataMember = "ReturnTbl";
            this.returnTblBindingSource.DataSource = this.productDS;
            // 
            // returnProductTblBindingSource
            // 
            this.returnProductTblBindingSource.DataSource = this.productDS;
            this.returnProductTblBindingSource.Position = 0;
            // 
            // orderLineTblBindingSource1
            // 
            this.orderLineTblBindingSource1.DataMember = "OrderLineTbl";
            this.orderLineTblBindingSource1.DataSource = this.productDS;
            // 
            // orderTblTableAdapter
            // 
            this.orderTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.getPhoneOrderProductsTableAdapter = null;
            this.tableAdapterManager.OrderLineTblTableAdapter = null;
            this.tableAdapterManager.OrderTblTableAdapter = this.orderTblTableAdapter;
            this.tableAdapterManager.PhoneOrderLineTblTableAdapter = null;
            this.tableAdapterManager.PhoneOrderTableAdapter = null;
            this.tableAdapterManager.ProductTblTableAdapter = null;
            this.tableAdapterManager.ReturnProductTblTableAdapter = null;
            this.tableAdapterManager.ReturnTblTableAdapter = null;
            this.tableAdapterManager.selectProductIDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISTN3AS.ProductDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderLineTblBindingSource
            // 
            this.orderLineTblBindingSource.DataSource = this.productDS;
            this.orderLineTblBindingSource.Position = 0;
            // 
            // orderLineTblTableAdapter
            // 
            this.orderLineTblTableAdapter.ClearBeforeFill = true;
            // 
            // returnProductTblTableAdapter
            // 
            this.returnProductTblTableAdapter.ClearBeforeFill = true;
            // 
            // returnTblTableAdapter
            // 
            this.returnTblTableAdapter.ClearBeforeFill = true;
            // 
            // returnProductTblBindingSource1
            // 
            this.returnProductTblBindingSource1.DataMember = "ReturnProductTbl";
            this.returnProductTblBindingSource1.DataSource = this.productDS;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(531, 683);
            this.Controls.Add(this.pnlCompany);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            this.pnlCompany.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpItemPayment.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tpReturn.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalOrdeNoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProductTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineTblBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderLineTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnProductTblBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCompany;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpItemPayment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnProcessPayment_Payment;
        private System.Windows.Forms.Button btnCancel_Payment;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCustomerChange_Payment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbxAmtPaid_Payment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotal_Payment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDiscount_Payment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSubTotal_Payment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tpReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcess_Return;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblTotal_Return;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox tbxReason_Return;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCellNo_Return;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Button button3;
        private ProductDS productDS;
        private System.Windows.Forms.BindingSource orderTblBindingSource;
        private ProductDSTableAdapters.OrderTblTableAdapter orderTblTableAdapter;
        private ProductDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource orderLineTblBindingSource;
        private ProductDSTableAdapters.OrderLineTblTableAdapter orderLineTblTableAdapter;
        private ProductDSTableAdapters.updateProduantity updateProduantity1;
        private System.Windows.Forms.BindingSource orderLineTblBindingSource1;
        private System.Windows.Forms.BindingSource returnProductTblBindingSource;
        private ProductDSTableAdapters.ReturnProductTblTableAdapter returnProductTblTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpReturnDate_Returns;
        private ProductDSTableAdapters.updateProduantity updateProduantity2;
        private System.Windows.Forms.BindingSource returnTblBindingSource;
        private ProductDSTableAdapters.ReturnTblTableAdapter returnTblTableAdapter;
        private System.Windows.Forms.BindingSource returnProductTblBindingSource1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView globalOrdeNoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memIDDataGridViewTextBoxColumn;
    }
}