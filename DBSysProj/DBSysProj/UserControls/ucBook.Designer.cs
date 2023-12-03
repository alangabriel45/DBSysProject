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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.PictureBox();
            this.btnAddtoCart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(666, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 354);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 2;
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
            // btnBookNow
            // 
            this.btnBookNow.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_02_190258;
            this.btnBookNow.Location = new System.Drawing.Point(19, 497);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(122, 39);
            this.btnBookNow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBookNow.TabIndex = 4;
            this.btnBookNow.TabStop = false;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_02_190237;
            this.btnAddtoCart.Location = new System.Drawing.Point(147, 497);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(122, 39);
            this.btnAddtoCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddtoCart.TabIndex = 5;
            this.btnAddtoCart.TabStop = false;
            // 
            // ucBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucBook";
            this.Size = new System.Drawing.Size(1034, 593);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBookNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddtoCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnBookNow;
        private System.Windows.Forms.PictureBox btnAddtoCart;
    }
}
