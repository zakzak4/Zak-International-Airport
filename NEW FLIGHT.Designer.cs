namespace Zak_International_Airport
{
    partial class FORM_NEW_FLIGHT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_NEW_FLIGHT));
            this.GROUPBOX_NEW_FLIGHT = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BUTTON_ADD_FLIGHT = new System.Windows.Forms.Button();
            this.TEXTBOX_TO_AIRPORT = new System.Windows.Forms.TextBox();
            this.TEXTBOX_SEAT = new System.Windows.Forms.TextBox();
            this.TEXTBOX_FCOMP = new System.Windows.Forms.TextBox();
            this.TEXTBOX_FROM_AIRPORT = new System.Windows.Forms.TextBox();
            this.BUTTON_EXIT = new System.Windows.Forms.Button();
            this.GROUPBOX_NEW_FLIGHT.SuspendLayout();
            this.SuspendLayout();
            // 
            // GROUPBOX_NEW_FLIGHT
            // 
            this.GROUPBOX_NEW_FLIGHT.BackColor = System.Drawing.Color.Transparent;
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.label4);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.label3);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.label1);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.label2);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.BUTTON_ADD_FLIGHT);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.TEXTBOX_TO_AIRPORT);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.TEXTBOX_SEAT);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.TEXTBOX_FCOMP);
            this.GROUPBOX_NEW_FLIGHT.Controls.Add(this.TEXTBOX_FROM_AIRPORT);
            this.GROUPBOX_NEW_FLIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GROUPBOX_NEW_FLIGHT.ForeColor = System.Drawing.Color.White;
            this.GROUPBOX_NEW_FLIGHT.Location = new System.Drawing.Point(49, 48);
            this.GROUPBOX_NEW_FLIGHT.Name = "GROUPBOX_NEW_FLIGHT";
            this.GROUPBOX_NEW_FLIGHT.Size = new System.Drawing.Size(210, 361);
            this.GROUPBOX_NEW_FLIGHT.TabIndex = 5;
            this.GROUPBOX_NEW_FLIGHT.TabStop = false;
            this.GROUPBOX_NEW_FLIGHT.Text = "New Flight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(34, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "To Airport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "From Airport:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plane Seat Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plane Company:";
            // 
            // BUTTON_ADD_FLIGHT
            // 
            this.BUTTON_ADD_FLIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BUTTON_ADD_FLIGHT.Location = new System.Drawing.Point(65, 319);
            this.BUTTON_ADD_FLIGHT.Name = "BUTTON_ADD_FLIGHT";
            this.BUTTON_ADD_FLIGHT.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_ADD_FLIGHT.TabIndex = 4;
            this.BUTTON_ADD_FLIGHT.Text = "BOOK!";
            this.BUTTON_ADD_FLIGHT.UseVisualStyleBackColor = false;
            this.BUTTON_ADD_FLIGHT.Click += new System.EventHandler(this.BUTTON_ADD_FLIGHT_Click);
            // 
            // TEXTBOX_TO_AIRPORT
            // 
            this.TEXTBOX_TO_AIRPORT.BackColor = System.Drawing.Color.DimGray;
            this.TEXTBOX_TO_AIRPORT.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_TO_AIRPORT.Location = new System.Drawing.Point(37, 277);
            this.TEXTBOX_TO_AIRPORT.Name = "TEXTBOX_TO_AIRPORT";
            this.TEXTBOX_TO_AIRPORT.Size = new System.Drawing.Size(135, 22);
            this.TEXTBOX_TO_AIRPORT.TabIndex = 7;
            // 
            // TEXTBOX_SEAT
            // 
            this.TEXTBOX_SEAT.BackColor = System.Drawing.Color.DimGray;
            this.TEXTBOX_SEAT.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_SEAT.Location = new System.Drawing.Point(37, 133);
            this.TEXTBOX_SEAT.Name = "TEXTBOX_SEAT";
            this.TEXTBOX_SEAT.Size = new System.Drawing.Size(135, 22);
            this.TEXTBOX_SEAT.TabIndex = 5;
            // 
            // TEXTBOX_FCOMP
            // 
            this.TEXTBOX_FCOMP.BackColor = System.Drawing.Color.DimGray;
            this.TEXTBOX_FCOMP.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_FCOMP.Location = new System.Drawing.Point(37, 63);
            this.TEXTBOX_FCOMP.Name = "TEXTBOX_FCOMP";
            this.TEXTBOX_FCOMP.Size = new System.Drawing.Size(135, 22);
            this.TEXTBOX_FCOMP.TabIndex = 0;
            // 
            // TEXTBOX_FROM_AIRPORT
            // 
            this.TEXTBOX_FROM_AIRPORT.BackColor = System.Drawing.Color.DimGray;
            this.TEXTBOX_FROM_AIRPORT.ForeColor = System.Drawing.Color.White;
            this.TEXTBOX_FROM_AIRPORT.Location = new System.Drawing.Point(37, 205);
            this.TEXTBOX_FROM_AIRPORT.Name = "TEXTBOX_FROM_AIRPORT";
            this.TEXTBOX_FROM_AIRPORT.Size = new System.Drawing.Size(135, 22);
            this.TEXTBOX_FROM_AIRPORT.TabIndex = 1;
            // 
            // BUTTON_EXIT
            // 
            this.BUTTON_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BUTTON_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_EXIT.ForeColor = System.Drawing.Color.White;
            this.BUTTON_EXIT.Location = new System.Drawing.Point(114, 415);
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_EXIT.TabIndex = 16;
            this.BUTTON_EXIT.Text = "EXIT";
            this.BUTTON_EXIT.UseVisualStyleBackColor = false;
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // FORM_NEW_FLIGHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.BUTTON_EXIT);
            this.Controls.Add(this.GROUPBOX_NEW_FLIGHT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FORM_NEW_FLIGHT";
            this.Text = "Book A Flight";
            this.GROUPBOX_NEW_FLIGHT.ResumeLayout(false);
            this.GROUPBOX_NEW_FLIGHT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GROUPBOX_NEW_FLIGHT;
        private System.Windows.Forms.TextBox TEXTBOX_SEAT;
        private System.Windows.Forms.Button BUTTON_ADD_FLIGHT;
        private System.Windows.Forms.TextBox TEXTBOX_FCOMP;
        private System.Windows.Forms.TextBox TEXTBOX_FROM_AIRPORT;
        private System.Windows.Forms.TextBox TEXTBOX_TO_AIRPORT;
        private System.Windows.Forms.Button BUTTON_EXIT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}