using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARTIS_manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static ARTISref.ArtisLabInfoServiceSoapClient ARTISLABclient;
        public static string token;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ARTISLABclient = new ARTISref.ArtisLabInfoServiceSoapClient("ArtisLabInfoServiceSoap");
            Application.Run(new Landing());
        }
    }
}
