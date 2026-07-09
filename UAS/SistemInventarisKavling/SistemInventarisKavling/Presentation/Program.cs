using System;
using System.Windows.Forms;
using SistemInventarisKavling.Application.Interfaces;
using SistemInventarisKavling.Repository;
using SistemInventarisKavling.Services;

namespace SistemInventarisKavling
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            IKavlingRepository repository = new KavlingRepository();
            IKavlingService service = new KavlingService(repository);

            System.Windows.Forms.Application.Run(new Form1(service));
        }
    }
}