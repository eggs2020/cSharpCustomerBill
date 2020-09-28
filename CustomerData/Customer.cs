using System;
using System.ComponentModel;
using System.Dynamic;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        // Private Variables
        private int accountNo;
        private string customerName;
        private string customerType;
        private double chargeAmount;

        // Public Property
        public int AccountNo 
        {
            get
            {
                return accountNo;
            }
            set
            {
                if (value < 0)
                    accountNo = Math.Abs(value);
                else
                {
                    accountNo = value;
                }
            }
        }

        public string CustomerName 
        {
            get
            {
                return customerName;
            }
            set
            {   
                customerName = value;
            }
        }

        public string CustomerType
        {
            get 
            {
                return customerType;
            }
            set
            {
                customerType = value.ToUpper();
            }
        }

        public double ChargeAmount 
        {
            get
            {
                return chargeAmount;
            }
            set
            {
                chargeAmount = value;
            }
            
        }// not sure yet what to do if input is a string representation of a double number


        // Constructor
        public Customer(int accNo = 0, string custName = "unknown", string custType = "XX", double bill = 0.0d) 
        {
            accountNo = accNo;
            customerName = custName;
            customerType = custType.ToUpper();
            chargeAmount = bill;
        }

        public double CalculateCharge(string cType, double pwrUsage1, double pwrUsage2) 
        {
            double pwrBill = 0.0d, peakBill = 0.0d, offPeakBill = 0.0d;
            const int residentialFee = 6;
            const double residentialRate = 0.052;

            const int commercialFee = 60;
            const double commercialRate = 0.045;

            const int industrialPeakFee = 76;
            const double industrialPeakRate = 0.065;
            const int industrialOffPeakFee = 40;
            const double industrialOffPeakRate = 0.028;

            if ( cType == "C") // Commercial customer
            {
                if ((pwrUsage1 - 1000) > 0)
                    pwrBill = (pwrUsage1 - 1000) * commercialRate;

                pwrBill += commercialFee;
            }
            else if ( cType == "I") // Industrial customer
            {
                if ((pwrUsage1 - 1000) > 0)
                    peakBill = (pwrUsage1 - 1000) * industrialPeakRate;

                if ((pwrUsage2 - 1000) > 0)
                    offPeakBill = (pwrUsage2 - 1000) * industrialOffPeakRate;

                peakBill += industrialPeakFee;
                offPeakBill += industrialOffPeakFee;

                pwrBill = peakBill + offPeakBill;
            }
            else // Residential customer
            {
                if (pwrUsage1 > 0)
                    pwrBill = pwrUsage1 * residentialRate;

                pwrBill += residentialFee;
            }

            return pwrBill; 
        }


        public override string ToString()
        {
            return accountNo.ToString() + ", " + customerName + ", " + customerType + ", " + chargeAmount.ToString("C");

            /*private int accountNo;
            private string customerName;
            private string customerType;
            private double chargeAmount;*/
        }

        public string ToFile() // not sure about this 
        {
            return accountNo.ToString() + "," + customerName + "," + customerType + "," + chargeAmount.ToString();
        }
    }
}
