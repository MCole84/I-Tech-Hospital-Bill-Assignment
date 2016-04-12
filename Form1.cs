using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        private PatientBill newBill;

        public Form1()
        {
            InitializeComponent();
            newBill = new PatientBill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal surgery;
            decimal lab;
            decimal rehab;
            decimal medicine;
            string baseErrorMessage = "Invalid data in ";
            if (decimal.TryParse(txtMedicationFees.Text, out medicine))
            {
                if (decimal.TryParse(txtSurgicalFees.Text, out surgery))
                {
                    if (decimal.TryParse(txtLabFees.Text, out lab))
                    {
                        if (decimal.TryParse(txtRehabilitation.Text, out rehab))
                        {
                            lblTotalCost.Text = newBill.CalcTotalCharges((int)nudDaysAdmitted.Value, surgery, lab, rehab, medicine).ToString("C2");
                        }
                        else
                        {
                            MessageBox.Show(baseErrorMessage + " Rehabilitation fees");
                            txtRehabilitation.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(baseErrorMessage + " lab fees");
                        txtLabFees.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(baseErrorMessage + " surgical fees");
                    txtSurgicalFees.Focus();
                }
            }
            else
            {
                MessageBox.Show(baseErrorMessage + " medication fees");
                txtMedicationFees.Focus();
            }
        }
    }
}