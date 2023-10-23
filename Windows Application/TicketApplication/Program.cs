using Ninject;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace TicketApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //StandardKernel _Kernal = new StandardKernel();
            //_Kernal.Load(Assembly.GetExecutingAssembly());
            //IUnitOfWork _unitOfWork = _Kernal.Get<IUnitOfWork>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
