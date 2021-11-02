
namespace calculator
{
    partial class frmLogin
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
            this.grpForename = new System.Windows.Forms.GroupBox();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.grpSurname = new System.Windows.Forms.GroupBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpForename.SuspendLayout();
            this.grpSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpForename
            // 
            this.grpForename.Controls.Add(this.tbxForename);
            this.grpForename.Location = new System.Drawing.Point(13, 13);
            this.grpForename.Name = "grpForename";
            this.grpForename.Size = new System.Drawing.Size(200, 49);
            this.grpForename.TabIndex = 0;
            this.grpForename.TabStop = false;
            this.grpForename.Text = "Forename";
            // 
            // tbxForename
            // 
            this.tbxForename.Location = new System.Drawing.Point(7, 20);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(187, 20);
            this.tbxForename.TabIndex = 0;
            // 
            // grpSurname
            // 
            this.grpSurname.Controls.Add(this.tbxSurname);
            this.grpSurname.Location = new System.Drawing.Point(13, 68);
            this.grpSurname.Name = "grpSurname";
            this.grpSurname.Size = new System.Drawing.Size(200, 49);
            this.grpSurname.TabIndex = 1;
            this.grpSurname.TabStop = false;
            this.grpSurname.Text = "Surname";
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(7, 20);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(187, 20);
            this.tbxSurname.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(94, 124);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 258);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpSurname);
            this.Controls.Add(this.grpForename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.grpForename.ResumeLayout(false);
            this.grpForename.PerformLayout();
            this.grpSurname.ResumeLayout(false);
            this.grpSurname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForename;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.GroupBox grpSurname;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;
    }
}

