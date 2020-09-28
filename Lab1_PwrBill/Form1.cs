/* Application to calculate power bills for difference custormer types
 * Edwin GonoSantosa
 * Aug 18, 2020 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CustomerData; // custom-made class library project
using System.Runtime.InteropServices;

namespace Lab1_PwrBill
{
    public partial class Form1 : Form
    {
        // global variable declaration
        List<Customer> customerList = new List<Customer>();
        //int customerCount = 0;
        double totalResidential = 0.0d, totalCommercial = 0.0d, totalIndustrial = 0.0d;
        double totalAllCharges = 0.0d;

        public Form1()
        {
            InitializeComponent();

            // Populate items to show in the combo box (drop-down menu)
            string [] customerTypeArray = { "Commercial", "Industrial", "Residential" };
            foreach (string customerType in customerTypeArray)
            {
                cboCustomerType.Items.Add(customerType);
            }
            cboCustomerType.SelectedIndex = 2;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            customerList = CustomerDB.GetCustomers();
            //totalAllCharges = CalculateTotal();
            CalculateTotal();
            DisplayCustomers();

        } // Form1_load


        // Calculate various totals
        private void CalculateTotal()
        {
            //double total = 0d;
            foreach (Customer cust in customerList)
            {
                if (cust.CustomerType == "R")
                    totalResidential += cust.ChargeAmount;
                if (cust.CustomerType == "C")
                    totalCommercial += cust.ChargeAmount;
                if (cust.CustomerType == "I")
                    totalIndustrial += cust.ChargeAmount;
            }
            totalAllCharges = totalResidential + totalCommercial + totalIndustrial;
            //return total;
        } 


        // Display customers in file and various totals to the form
        private void DisplayCustomers()
        {
            // Clear listbox upon first load
            lstCustData.Items.Clear();

            // Display customers existing in file to the listbox
            foreach (Customer cust in customerList)
                lstCustData.Items.Add(cust);

            // Display customer count and various totals
            txtCustCount.Text = customerList.Count.ToString();
            txtTotalResidential.Text = totalResidential.ToString("C");
            txtTotalCommercial.Text = totalCommercial.ToString("C");
            txtTotalIndustrial.Text = totalIndustrial.ToString("C");
            txtTotalAllCharges.Text = totalAllCharges.ToString("C");
        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear all text boxes when a new customer type is selected
            txtOverallUsage.Text = "";
            txtOffPeakUsage.Text = "";
            txtBill.Text = "";

            // Setup textbox visibility and labelbox text
            if (cboCustomerType.SelectedIndex == 0)
            {
                lblOverallUsage.Text = "Overall kWh:";
                lblOverallUsage.Visible = true;
                txtOverallUsage.Visible = true;
                txtOverallUsage.Tag = "Overall kWh";

                lblOffPeakUsage.Visible = false;
                txtOffPeakUsage.Visible = false;

                pictureBox1.ImageLocation = "../../../images/commercial.bmp";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (cboCustomerType.SelectedIndex == 1)
            {
                lblOverallUsage.Text = "Peak kWh:";
                lblOverallUsage.Visible = true;
                txtOverallUsage.Visible = true;
                txtOverallUsage.Tag = "Peak kWh";

                lblOffPeakUsage.Visible = true;
                txtOffPeakUsage.Visible = true;

                pictureBox1.ImageLocation = "../../../images/industrial.bmp";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                lblOverallUsage.Text = "Overall kWh:";
                lblOverallUsage.Visible = true;
                txtOverallUsage.Visible = true;
                txtOverallUsage.Tag = "Overall kWh";

                lblOffPeakUsage.Visible = false;
                txtOffPeakUsage.Visible = false;

                pictureBox1.ImageLocation = "../../../images/residential.bmp";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        } // cboCustomerType_SelectedIndexChanged


        // Exit application when the exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Clear all textboxes when the reset button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOverallUsage.Text = "";
            txtOffPeakUsage.Text = "";
            txtAccNo.Text = "";
            txtCustName.Text = "";
            txtBill.Text = "";
        }


        // Save data just before form closes (ie. data in listbox to file)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveCustomers(customerList);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            double pwrBill = 0.0d, pwrUsage1 = 0.0d, pwrUsage2 = 0.0d;
            int selectedCustomerIndex = cboCustomerType.SelectedIndex;
            int accountNo = 0;
            string cName = "";
            Customer newCust;

            if ( IsPresent(txtAccNo) && IsPresent(txtCustName) )
            {
                accountNo = Convert.ToInt32(txtAccNo.Text);
                cName = txtCustName.Text;

                if (selectedCustomerIndex == 0) // Commercial customer
                {
                    if (IsPresent(txtOverallUsage))
                    {
                        // Create a new customer object
                        pwrUsage1 = Convert.ToDouble(txtOverallUsage.Text);

                        // Create a new customer object
                        newCust = new Customer(accountNo, cName, "C", 0);

                        // Calculate charge amount for the object
                        pwrBill = newCust.CalculateCharge("C", pwrUsage1, 0);
                        newCust.ChargeAmount = pwrBill;

                        // Dispaly charge amount to window form
                        txtBill.Text = pwrBill.ToString("C");

                        // Add newly-created customer to customerList
                        customerList.Add(newCust);

                        // Re-calculate relevant totals
                        totalCommercial += pwrBill;
                        totalAllCharges += pwrBill;

                        // Display newly added customer to listbox
                        DisplayCustomers();
                    }
                } // if statement
                else if (selectedCustomerIndex == 1)
                {
                    if (IsPresent(txtOverallUsage) && IsPresent(txtOffPeakUsage))
                    {
                        pwrUsage1 = Convert.ToDouble(txtOverallUsage.Text);
                        pwrUsage2 = Convert.ToDouble(txtOffPeakUsage.Text);

                        newCust = new Customer(accountNo, cName, "I", 0);

                        pwrBill = newCust.CalculateCharge("I", pwrUsage1, pwrUsage2);
                        newCust.ChargeAmount = pwrBill;

                        txtBill.Text = pwrBill.ToString("C");

                        customerList.Add(newCust);

                        totalIndustrial += pwrBill;
                        totalAllCharges += pwrBill;

                        DisplayCustomers();
                    }
                } // else if
                else
                {
                    if (IsPresent(txtOverallUsage))
                    {
                        pwrUsage1 = Convert.ToDouble(txtOverallUsage.Text);

                        newCust = new Customer(accountNo, cName, "R", 0);

                        pwrBill = newCust.CalculateCharge("R", pwrUsage1, 0);
                        newCust.ChargeAmount = pwrBill;

                        txtBill.Text = pwrBill.ToString("C");

                        customerList.Add(newCust);

                        totalResidential += pwrBill;
                        totalAllCharges += pwrBill;

                        DisplayCustomers();
                    }
                } // else



                // Save revised customerList back to file
                //CustomerDB.SaveCustomers(customerList);

            } // validate textbox not empty



        } // btnAdd_Click


        // Calculate power bills when the calculate button is clicked
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double pwrUsage1, pwrUsage2, totalBill = 0.0;
            int selectedCustomerIndex = cboCustomerType.SelectedIndex;
            Customer newCust;

            if (selectedCustomerIndex == 0) // Commercial customer
            {
                if ( IsPresent(txtOverallUsage) && IsDouble(txtOverallUsage) && 
                     IsNonNegativeDouble(txtOverallUsage) ) // Validate user input
                {
                    pwrUsage1 = Convert.ToDouble(txtOverallUsage.Text);
                    newCust = new Customer();
                    totalBill = newCust.CalculateCharge("C", pwrUsage1, 0);
                    txtBill.Text = totalBill.ToString("C"); // Display bill amount to a read-only textbox
                }
            }
            else if (selectedCustomerIndex == 1) // Industrial customer
            {
                if ( IsPresent(txtOverallUsage) && IsPresent(txtOffPeakUsage) &&
                     IsDouble(txtOverallUsage) && IsDouble(txtOffPeakUsage) && 
                     IsNonNegativeDouble(txtOverallUsage) && IsNonNegativeDouble(txtOffPeakUsage) ) // Validate user input
                {
                    pwrUsage1 = Convert.ToDouble(txtOverallUsage.Text);
                    pwrUsage2 = Convert.ToDouble(txtOffPeakUsage.Text);
                    newCust = new Customer();
                    totalBill = newCust.CalculateCharge("I", pwrUsage1, pwrUsage2);
                    txtBill.Text = totalBill.ToString("C");
                }
            }
            else // Residential customer
            {
                if ( IsPresent(txtOverallUsage) && IsDouble(txtOverallUsage) && 
                     IsNonNegativeDouble(txtOverallUsage) ) // Validate user input
                {
                    pwrUsage1 = Convert.ToDouble(txtOverallUsage.Text);
                    newCust = new Customer();
                    totalBill = newCust.CalculateCharge("R", pwrUsage1, 0);
                    txtBill.Text = totalBill.ToString("C");
                }
            }
        } // btnCalculate_Click


        // Check if a textbox has a content
        public static bool IsPresent(TextBox tb)
        {
            bool result = true; // Assume textbox as a content
            if (tb.Text == "")
            {
                MessageBox.Show(tb.Tag + " has to be provided",
                    "Input Error");
                result = false; // Textbox has no content
                tb.Focus();
            }
            return result;
        }

        // Check if textbox content is a number
        public static bool IsDouble(TextBox tb)
        {
            bool result = true;
            double parsedValue;
            if (!Double.TryParse(tb.Text, out parsedValue))// bad!
            {
                MessageBox.Show(tb.Tag + " has to be a number (can have decimal part)",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        // Check if a textbox has a negative value
        public static bool IsNonNegativeDouble(TextBox tb)
        {
            bool result = true;
            double parsedValue = Double.Parse(tb.Text);
            if (parsedValue < 0)// Bad! Input textbox contains negative value.
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                    "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        /* Legacy functions from Lab 1. Not used anymore.
        // Calculate bill amount for residential customer
        public double calculateBillResidential(double pwrUsage1)
        {
            double pwrBill= 0.0;
            const int residentialFee = 6;
            const double residentialRate = 0.052;

            // Calculate total power bill amount
            pwrBill = residentialFee + (pwrUsage1 * residentialRate);
            return pwrBill;
        }

        // Calculate bill amount for commercial customer
        public double calculateBillCommercial(double pwrUsage1)
        {
            double pwrBill= 0.0;
            const int commercialFee = 60;
            const double commercialRate = 0.045;

            // Calculate total power bill amount
            if ( (pwrUsage1 - 1000) > 0 )
                pwrBill = (pwrUsage1 - 1000) * commercialRate;

            pwrBill += commercialFee;
            return pwrBill;
        }

        // Calculate bill amount for industrial customer
        public double calculateBillIndustrial(double pwrUsage1, double pwrUsage2)
        {
            double pwrBill= 0.0, peakBill= 0.0, offPeakBill= 0.0;

            const int industrialPeakFee = 76;
            const double industrialPeakRate = 0.065;
            const int industrialOffPeakFee = 40;
            const double industrialOffPeakRate = 0.028;

            // Calculate total power bill amount
            if ( (pwrUsage1 - 1000) > 0 )
                peakBill = (pwrUsage1 - 1000) * industrialPeakRate;
            
            if ( (pwrUsage2 - 1000) > 0 )
                offPeakBill = (pwrUsage2 - 1000) * industrialOffPeakRate;

            peakBill += industrialPeakFee;
            offPeakBill += industrialOffPeakFee;

            pwrBill = peakBill + offPeakBill;

            return pwrBill;
        }*/


    } // Form1

} // Namespace
