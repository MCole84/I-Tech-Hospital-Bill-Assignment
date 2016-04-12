using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalCharges
{
    internal class PatientBill
    {
        private const decimal DAILY_FEE = 350;

        public decimal CalcStayCharges(int daysAdmitted)
        {
            decimal baseCharge = 0m;
            baseCharge = daysAdmitted * DAILY_FEE;
            return baseCharge;
        }

        /// <summary>
        /// Accepts the input of the Medication, Surgery, Lab, and Rehab fees and returns the total
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">if text input is not a numeric amount this exeception is thrown</exception>
        public decimal CalcMiscCharges(decimal surgeryBill, decimal labBill, decimal rehabBill, decimal medicationBill)
        {
            return surgeryBill + labBill + rehabBill + medicationBill;
        }

        /// <summary>
        /// returns the total of the base and additional medical fees. returns 0 if any of the input values are not numeric format.
        /// </summary>
        /// <returns></returns>
        public decimal CalcTotalCharges(int daysAdmitted, decimal surgery, decimal lab, decimal rehab,
            decimal medication)
        {
            return CalcStayCharges(daysAdmitted) + CalcMiscCharges(surgery, lab, rehab, medication);
        }
    }
}