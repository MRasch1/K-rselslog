using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kørselslog
{
    internal class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }

        private void AddNewCustomers(DataSet1 currentCustomer)
        {
            DataSet1TableAdapters.stamdataTableAdapter DataSetAdapter = new DataSet1TableAdapters.stamdataTableAdapter();

            
            
        }

    }
}
