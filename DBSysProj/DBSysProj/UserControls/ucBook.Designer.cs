namespace DBSysProj.UserControls
{
    partial class ucBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookNow = new System.Windows.Forms.PictureBox();
            this.btnAddtoCart = new System.Windows.Forms.PictureBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddtoCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 354);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(17, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(337, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Number";
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Location = new System.Drawing.Point(21, 44);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(156, 20);
            this.txtRoomNum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel";
            // 
            // txtHotel
            // 
            this.txtHotel.Location = new System.Drawing.Point(183, 44);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(156, 20);
            this.txtHotel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.btnBookNow);
            this.panel1.Controls.Add(this.btnAddtoCart);
            this.panel1.Controls.Add(this.txtMax);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRoomType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHotel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRoomNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(666, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 354);
            this.panel1.TabIndex = 1;
            // 
            // btnBookNow
            // 
            this.btnBookNow.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_02_190258;
            this.btnBookNow.Location = new System.Drawing.Point(51, 304);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(122, 39);
            this.btnBookNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBookNow.TabIndex = 4;
            this.btnBookNow.TabStop = false;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_02_190237;
            this.btnAddtoCart.Location = new System.Drawing.Point(179, 304);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(122, 39);
            this.btnAddtoCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddtoCart.TabIndex = 5;
            this.btnAddtoCart.TabStop = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(21, 239);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(156, 20);
            this.txtMax.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Maximum Guest";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(21, 200);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(156, 20);
            this.txtMin.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Minimum Guest";
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(21, 161);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(156, 20);
            this.txtBed.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bed";
            // 
            // txtAc
            // 
            this.txtAc.Location = new System.Drawing.Point(21, 122);
            this.txtAc.Name = "txtAc";
            this.txtAc.Size = new System.Drawing.Size(156, 20);
            this.txtAc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "With Aircoin";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(21, 83);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(156, 20);
            this.txtRoomType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Type";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1034, 593);
            this.pnlContainer.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(21, 278);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 20);
            this.txtPrice.TabIndex = 15;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 262);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price";
            // 
            // ucBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlContainer);
            this.Name = "ucBook";
            this.Size = new System.Drawing.Size(1034, 593);
            this.Load += new System.EventHandler(this.ucBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddtoCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBookNow;
        private System.Windows.Forms.PictureBox btnAddtoCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProviderCustom;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}
