namespace PixisAirProjectTeam3
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnCountries = new System.Windows.Forms.Button();
            this.btnSeats = new System.Windows.Forms.Button();
            this.btnReshist = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(80, 26);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(76, 41);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(140, 109);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(76, 41);
            this.btnReservations.TabIndex = 1;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnCountries
            // 
            this.btnCountries.Location = new System.Drawing.Point(12, 109);
            this.btnCountries.Margin = new System.Windows.Forms.Padding(2);
            this.btnCountries.Name = "btnCountries";
            this.btnCountries.Size = new System.Drawing.Size(76, 41);
            this.btnCountries.TabIndex = 2;
            this.btnCountries.Text = "Countries";
            this.btnCountries.UseVisualStyleBackColor = true;
            // 
            // btnSeats
            // 
            this.btnSeats.Location = new System.Drawing.Point(140, 204);
            this.btnSeats.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeats.Name = "btnSeats";
            this.btnSeats.Size = new System.Drawing.Size(76, 41);
            this.btnSeats.TabIndex = 3;
            this.btnSeats.Text = "Seats";
            this.btnSeats.UseVisualStyleBackColor = true;
            // 
            // btnReshist
            // 
            this.btnReshist.Location = new System.Drawing.Point(12, 204);
            this.btnReshist.Margin = new System.Windows.Forms.Padding(2);
            this.btnReshist.Name = "btnReshist";
            this.btnReshist.Size = new System.Drawing.Size(76, 41);
            this.btnReshist.TabIndex = 4;
            this.btnReshist.Text = "RESHIST";
            this.btnReshist.UseVisualStyleBackColor = true;
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(140, 294);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(2);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(76, 41);
            this.btnInformation.TabIndex = 5;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(12, 294);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(76, 41);
            this.btnPassword.TabIndex = 6;
            this.btnPassword.Text = "Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(552, 336);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 20);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(264, 109);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 41);
            this.btnAddCar.TabIndex = 8;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnReshist);
            this.Controls.Add(this.btnSeats);
            this.Controls.Add(this.btnCountries);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnCustomers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnCountries;
        private System.Windows.Forms.Button btnSeats;
        private System.Windows.Forms.Button btnReshist;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddCar;
    }
}

