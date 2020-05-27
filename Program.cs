using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    static class Program
    {
        private static string selectedPath;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main(string[] args )
        {
          Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         /*   var t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.Cancel)
                    return;

                selectedPath = fbd.SelectedPath;
            }));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            MessageBox.Show(selectedPath);*/
            Thread rk = new Thread(mss);


            Thread r = new Thread(ms);
            r.SetApartmentState(ApartmentState.STA);
            r.Start();
            // r.Join();

            if (!r.Join(TimeSpan.FromSeconds(2)))
            {
                r.Abort();
               // rk.SetApartmentState(ApartmentState.STA);

               // rk.Start();

               // rk.Join();
                //  Form1 y = new Form1();
                //  y.WindowState = FormWindowState.Maximized;

            }
         

        Application.Run(new Form1());
          //  Form1 tt = new Form1();
        }

        private static void ms()
        {
            Application.Run(new Form4());
        }

        private static void mss()
        {
           // Application.Run(new Form5());
        }
    }
}
