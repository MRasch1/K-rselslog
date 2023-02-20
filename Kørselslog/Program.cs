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

        ///For at slutte sig til den lokale database i SSMS så skal man skrive et stykke fra datasource ind som er server navnet.
        ///Server navn = (LocalDB)\MSSQLLocalDB. I mit tilfælde...



    }
}
