namespace DBSysProj.Forms
{
    partial class FrmUser
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCheckOut = new System.Windows.Forms.PictureBox();
            this.btnYourCart = new System.Windows.Forms.PictureBox();
            this.btnBook = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYourCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.DarkGray;
            this.pnlContainer.Location = new System.Drawing.Point(12, 75);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1034, 593);
            this.pnlContainer.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_13_221958;
            this.btnCheckOut.Location = new System.Drawing.Point(266, 29);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(121, 40);
            this.btnCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.TabStop = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnYourCart
            // 
            this.btnYourCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYourCart.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_02_183252;
            this.btnYourCart.Location = new System.Drawing.Point(139, 29);
            this.btnYourCart.Name = "btnYourCart";
            this.btnYourCart.Size = new System.Drawing.Size(121, 40);
            this.btnYourCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYourCart.TabIndex = 6;
            this.btnYourCart.TabStop = false;
            this.btnYourCart.Click += new System.EventHandler(this.btnYourCart_Click);
            this.btnYourCart.MouseHover += new System.EventHandler(this.btnYourCart_MouseHover);
            // 
            // btnBook
            // 
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Image = global::DBSysProj.Properties.Resources.Screenshot_2023_12_02_183240;
            this.btnBook.Location = new System.Drawing.Point(12, 29);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(121, 40);
            this.btnBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBook.TabIndex = 5;
            this.btnBook.TabStop = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            this.btnBook.MouseHover += new System.EventHandler(this.btnBook_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::DBSysProj.Properties.Resources.minimize_FILL0_wght400_GRAD0_opsz24;
            this.btnMinimize.Location = new System.Drawing.Point(986, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 23);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::DBSysProj.Properties.Resources.close_FILL0_wght400_GRAD0_opsz24;
            this.btnClose.Location = new System.Drawing.Point(1017, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1058, 680);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnYourCart);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            ((System.ComponentModel.ISupportInitialize)(this.btnCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYourCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox btnBook;
        private System.Windows.Forms.PictureBox btnYourCart;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.PictureBox btnCheckOut;
    }
}