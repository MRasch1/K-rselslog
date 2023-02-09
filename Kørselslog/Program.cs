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
            Application.Run(new KørselslogForside());
            

        }

        private void AddNewCustomers(DatabaseKørselslogDataSet currentCustomer)
        {
            DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter DataSetAdapter = new DatabaseKørselslogDataSetTableAdapters.stamdataTableAdapter();

            
            
        }

    }
}
