namespace HospitalCharges
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudDaysAdmitted = new System.Windows.Forms.NumericUpDown();
            this.txtMedicationFees = new System.Windows.Forms.TextBox();
            this.txtSurgicalFees = new System.Windows.Forms.TextBox();
            this.txtLabFees = new System.Windows.Forms.TextBox();
            this.txtRehabilitation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysAdmitted)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days Admitted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medications:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rehabilitation:";
            // 
            // nudDaysAdmitted
            // 
            this.nudDaysAdmitted.Location = new System.Drawing.Point(108, 40);
            this.nudDaysAdmitted.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDaysAdmitted.Name = "nudDaysAdmitted";
            this.nudDaysAdmitted.Size = new System.Drawing.Size(83, 20);
            this.nudDaysAdmitted.TabIndex = 5;
            this.nudDaysAdmitted.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMedicationFees
            // 
            this.txtMedicationFees.Location = new System.Drawing.Point(108, 65);
            this.txtMedicationFees.Name = "txtMedicationFees";
            this.txtMedicationFees.Size = new System.Drawing.Size(83, 20);
            this.txtMedicationFees.TabIndex = 6;
            // 
            // txtSurgicalFees
            // 
            this.txtSurgicalFees.Location = new System.Drawing.Point(108, 91);
            this.txtSurgicalFees.Name = "txtSurgicalFees";
            this.txtSurgicalFees.Size = new System.Drawing.Size(83, 20);
            this.txtSurgicalFees.TabIndex = 7;
            // 
            // txtLabFees
            // 
            this.txtLabFees.Location = new System.Drawing.Point(108, 117);
            this.txtLabFees.Name = "txtLabFees";
            this.txtLabFees.Size = new System.Drawing.Size(83, 20);
            this.txtLabFees.TabIndex = 8;
            // 
            // txtRehabilitation
            // 
            this.txtRehabilitation.Location = new System.Drawing.Point(108, 143);
            this.txtRehabilitation.Name = "txtRehabilitation";
            this.txtRehabilitation.Size = new System.Drawing.Size(83, 20);
            this.txtRehabilitation.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(108, 227);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(83, 23);
            this.lblTotalCost.TabIndex = 11;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Bill:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 294);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRehabilitation);
            this.Controls.Add(this.txtLabFees);
            this.Controls.Add(this.txtSurgicalFees);
            this.Controls.Add(this.txtMedicationFees);
            this.Controls.Add(this.nudDaysAdmitted);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysAdmitted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDaysAdmitted;
        private System.Windows.Forms.TextBox txtMedicationFees;
        private System.Windows.Forms.TextBox txtSurgicalFees;
        private System.Windows.Forms.TextBox txtLabFees;
        private System.Windows.Forms.TextBox txtRehabilitation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label6;
    }
}

