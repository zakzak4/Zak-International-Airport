namespace Zak_International_Airport
{
    partial class FORM_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_LOGIN));
            this.TEXTBOX_USERNAME = new System.Windows.Forms.TextBox();
            this.TEXTBOX_PASSWORD = new System.Windows.Forms.TextBox();
            this.GROUPBOX_STAFF = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BUTTON_LOGIN = new System.Windows.Forms.Button();
            this.LABEL_USERNAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BUTTON_EXIT = new System.Windows.Forms.Button();
            this.GROUPBOX_CUST = new System.Windows.Forms.GroupBox();
            this.LABEL_CUST = new System.Windows.Forms.Label();
            this.BUTTON_GU_LOGIN = new System.Windows.Forms.Button();
            this.GROUPBOX_STAFF.SuspendLayout();
            this.GROUPBOX_CUST.SuspendLayout();
            this.SuspendLayout();
            // 
            // TEXTBOX_USERNAME
            // 
            this.TEXTBOX_USERNAME.BackColor = System.Drawing.Color.DimGray;
            this.TEXTBOX_USERNAME.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_USERNAME.Location = new System.Drawing.Point(37, 91);
            this.TEXTBOX_USERNAME.Name = "TEXTBOX_USERNAME";
            this.TEXTBOX_USERNAME.Size = new System.Drawing.Size(135, 22);
            this.TEXTBOX_USERNAME.TabIndex = 0;
            // 
            // TEXTBOX_PASSWORD
            // 
            this.TEXTBOX_PASSWORD.BackColor = System.Drawing.Color.DimGray;
            this.TEXTBOX_PASSWORD.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_PASSWORD.Location = new System.Drawing.Point(37, 187);
            this.TEXTBOX_PASSWORD.Name = "TEXTBOX_PASSWORD";
            this.TEXTBOX_PASSWORD.Size = new System.Drawing.Size(135, 22);
            this.TEXTBOX_PASSWORD.TabIndex = 1;
            this.TEXTBOX_PASSWORD.TextChanged += new System.EventHandler(this.TEXTBOX_PASSWORD_TextChanged);
            // 
            // GROUPBOX_STAFF
            // 
            this.GROUPBOX_STAFF.BackColor = System.Drawing.Color.Transparent;
            this.GROUPBOX_STAFF.Controls.Add(this.label2);
            this.GROUPBOX_STAFF.Controls.Add(this.BUTTON_LOGIN);
            this.GROUPBOX_STAFF.Controls.Add(this.LABEL_USERNAME);
            this.GROUPBOX_STAFF.Controls.Add(this.TEXTBOX_USERNAME);
            this.GROUPBOX_STAFF.Controls.Add(this.TEXTBOX_PASSWORD);
            this.GROUPBOX_STAFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_STAFF.ForeColor = System.Drawing.Color.White;
            this.GROUPBOX_STAFF.Location = new System.Drawing.Point(53, 109);
            this.GROUPBOX_STAFF.Name = "GROUPBOX_STAFF";
            this.GROUPBOX_STAFF.Size = new System.Drawing.Size(210, 291);
            this.GROUPBOX_STAFF.TabIndex = 2;
            this.GROUPBOX_STAFF.TabStop = false;
            this.GROUPBOX_STAFF.Text = "Staff Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // BUTTON_LOGIN
            // 
            this.BUTTON_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BUTTON_LOGIN.Location = new System.Drawing.Point(66, 239);
            this.BUTTON_LOGIN.Name = "BUTTON_LOGIN";
            this.BUTTON_LOGIN.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_LOGIN.TabIndex = 4;
            this.BUTTON_LOGIN.Text = "LOGIN";
            this.BUTTON_LOGIN.UseVisualStyleBackColor = false;
            this.BUTTON_LOGIN.Click += new System.EventHandler(this.BUTTON_LOGIN_Click);
            // 
            // LABEL_USERNAME
            // 
            this.LABEL_USERNAME.AutoSize = true;
            this.LABEL_USERNAME.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_USERNAME.Location = new System.Drawing.Point(34, 57);
            this.LABEL_USERNAME.Name = "LABEL_USERNAME";
            this.LABEL_USERNAME.Size = new System.Drawing.Size(82, 16);
            this.LABEL_USERNAME.TabIndex = 2;
            this.LABEL_USERNAME.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(117, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To Zak International Airport!";
            // 
            // BUTTON_EXIT
            // 
            this.BUTTON_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BUTTON_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_EXIT.ForeColor = System.Drawing.Color.White;
            this.BUTTON_EXIT.Location = new System.Drawing.Point(535, 404);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(73, 34);
            this.BUTTON_EXIT.TabIndex = 4;
            this.BUTTON_EXIT.Text = "EXIT";
            this.BUTTON_EXIT.UseVisualStyleBackColor = false;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // GROUPBOX_CUST
            // 
            this.GROUPBOX_CUST.BackColor = System.Drawing.Color.Transparent;
            this.GROUPBOX_CUST.Controls.Add(this.LABEL_CUST);
            this.GROUPBOX_CUST.Controls.Add(this.BUTTON_GU_LOGIN);
            this.GROUPBOX_CUST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_CUST.ForeColor = System.Drawing.Color.White;
            this.GROUPBOX_CUST.Location = new System.Drawing.Point(334, 139);
            this.GROUPBOX_CUST.Name = "GROUPBOX_CUST";
            this.GROUPBOX_CUST.Size = new System.Drawing.Size(237, 208);
            this.GROUPBOX_CUST.TabIndex = 5;
            this.GROUPBOX_CUST.TabStop = false;
            this.GROUPBOX_CUST.Text = "Customers:";
            // 
            // LABEL_CUST
            // 
            this.LABEL_CUST.AutoSize = true;
            this.LABEL_CUST.BackColor = System.Drawing.Color.Transparent;
            this.LABEL_CUST.Location = new System.Drawing.Point(45, 67);
            this.LABEL_CUST.Name = "LABEL_CUST";
            this.LABEL_CUST.Size = new System.Drawing.Size(148, 16);
            this.LABEL_CUST.TabIndex = 5;
            this.LABEL_CUST.Text = "Are you a customer?";
            // 
            // BUTTON_GU_LOGIN
            // 
            this.BUTTON_GU_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BUTTON_GU_LOGIN.Location = new System.Drawing.Point(64, 115);
            this.BUTTON_GU_LOGIN.Name = "BUTTON_GU_LOGIN";
            this.BUTTON_GU_LOGIN.Size = new System.Drawing.Size(110, 23);
            this.BUTTON_GU_LOGIN.TabIndex = 5;
            this.BUTTON_GU_LOGIN.Text = "CONTINUE";
            this.BUTTON_GU_LOGIN.UseVisualStyleBackColor = false;
            this.BUTTON_GU_LOGIN.Click += new System.EventHandler(this.BUTTON_GU_LOGIN_Click);
            // 
            // FORM_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.GROUPBOX_CUST);
            this.Controls.Add(this.BUTTON_EXIT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GROUPBOX_STAFF);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_LOGIN";
            this.Text = "Zak International Airport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GROUPBOX_STAFF.ResumeLayout(false);
            this.GROUPBOX_STAFF.PerformLayout();
            this.GROUPBOX_CUST.ResumeLayout(false);
            this.GROUPBOX_CUST.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_USERNAME;
        private System.Windows.Forms.TextBox TEXTBOX_PASSWORD;
        private System.Windows.Forms.GroupBox GROUPBOX_STAFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BUTTON_EXIT;
        private System.Windows.Forms.Button BUTTON_LOGIN;
        private System.Windows.Forms.GroupBox GROUPBOX_CUST;
        private System.Windows.Forms.Button BUTTON_GU_LOGIN;
        private System.Windows.Forms.Label LABEL_CUST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LABEL_USERNAME;
    }
}

