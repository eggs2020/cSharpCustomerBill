using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace CustomerData
{
    public static class CustomerDB
    {
        const string PATH = "Customers.txt"; // File in .../bin/Debug/netcoreapp3.1

        public static List<Customer> GetCustomers()
        {
            string line;
            string[] lineParts;
            List<Customer> customerList = new List<Customer>(); // create an empty list (to be populated further down in the code)
            Customer cust;

            using (FileStream fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None) )
            {
                using (StreamReader sr = new StreamReader(fs) )
                {
                    while (!sr.EndOfStream)
                    {
                        // Read each line in the .txt file and break the strings deliminated with ',' into its substrings
                        line = sr.ReadLine();
                        lineParts = line.Split(',', StringSplitOptions.None);
                        
                        // Create a new customer object and populate its properties with retrieved data from the .txt file
                        cust = new Customer();
                        cust.AccountNo = Convert.ToInt32(lineParts[0]);
                        cust.CustomerName = lineParts[1];
                        cust.CustomerType = lineParts[2];
                        cust.ChargeAmount = Convert.ToDouble(lineParts[3]);

                        // add the newly created/populated customer to the "customerList" List 
                        customerList.Add(cust);
                    }
                    sr.Close();
                } // StreamReader

                fs.Close();
            } // FileStream

            return customerList;
        } // method GetCustomers          

        public static void SaveCustomers(List<Customer> customerList)
        {
            using (FileStream fs = new FileStream(PATH, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    //string line;
                    foreach (Customer cust in customerList)
                    {
                        //line = cust.AccountNo + cust.CustomerName + cust.CustomerType + cust.ChargeAmount;
                        sw.WriteLine(cust.ToFile());
                    }
                    sw.Close();
                } // StreamWriter

                fs.Close();
            } // FileStream

        } // method SaveCustomers

    } // class CustomerDB

} // namespace
