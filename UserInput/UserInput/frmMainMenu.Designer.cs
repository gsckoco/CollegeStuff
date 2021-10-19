
namespace UserInput
{
    partial class frmMainMenu
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
            System.Windows.Forms.Button btnExit;
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.grbForname = new System.Windows.Forms.GroupBox();
            this.grbSurname = new System.Windows.Forms.GroupBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbAge = new System.Windows.Forms.GroupBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            btnExit = new System.Windows.Forms.Button();
            this.grbForname.SuspendLayout();
            this.grbSurname.SuspendLayout();
            this.grbAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(18, 254);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(150, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(59, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Input";
            // 
            // tbxForename
            // 
            this.tbxForename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxForename.Location = new System.Drawing.Point(6, 21);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(150, 22);
            this.tbxForename.TabIndex = 1;
            this.tbxForename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // grbForname
            // 
            this.grbForname.Controls.Add(this.tbxForename);
            this.grbForname.Location = new System.Drawing.Point(12, 28);
            this.grbForname.Name = "grbForname";
            this.grbForname.Size = new System.Drawing.Size(162, 50);
            this.grbForname.TabIndex = 2;
            this.grbForname.TabStop = false;
            this.grbForname.Text = "Forename";
            // 
            // grbSurname
            // 
            this.grbSurname.Controls.Add(this.tbxSurname);
            this.grbSurname.Location = new System.Drawing.Point(12, 84);
            this.grbSurname.Name = "grbSurname";
            this.grbSurname.Size = new System.Drawing.Size(162, 50);
            this.grbSurname.TabIndex = 3;
            this.grbSurname.TabStop = false;
            this.grbSurname.Text = "Surname";
            // 
            // tbxSurname
            // 
            this.tbxSurname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxSurname.Location = new System.Drawing.Point(6, 21);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(150, 22);
            this.tbxSurname.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(18, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbAge
            // 
            this.grbAge.Controls.Add(this.tbxAge);
            this.grbAge.Location = new System.Drawing.Point(12, 140);
            this.grbAge.Name = "grbAge";
            this.grbAge.Size = new System.Drawing.Size(162, 50);
            this.grbAge.TabIndex = 4;
            this.grbAge.TabStop = false;
            this.grbAge.Text = "Age";
            // 
            // tbxAge
            // 
            this.tbxAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxAge.Location = new System.Drawing.Point(6, 21);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(65, 22);
            this.tbxAge.TabIndex = 3;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 289);
            this.Controls.Add(btnExit);
            this.Controls.Add(this.grbAge);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbSurname);
            this.Controls.Add(this.grbForname);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.grbForname.ResumeLayout(false);
            this.grbForname.PerformLayout();
            this.grbSurname.ResumeLayout(false);
            this.grbSurname.PerformLayout();
            this.grbAge.ResumeLayout(false);
            this.grbAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbForname;
        private System.Windows.Forms.GroupBox grbSurname;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.GroupBox grbAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxAge;
    }
}

