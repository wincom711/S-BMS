using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
namespace WindowsFormsApplication24
{
    public partial class Form10 : Form
    {
        PK g = new PK();
        public Form10()
        {
            InitializeComponent();

           // this.Controls.Add(g.dtagrid());
            g.cc();
            //g.datak();
            //  g.datax();
            // g.dtagrid();
            g.dtagrid().Columns.Add(g.chkk());
            // this.Controls.Add(g.datak());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] workerResult = new string[2];
            // var backgroundWorker = sender as BackgroundWorker;
            // workerResult[0] = "this string";
            // workerResult[1] = "some other string";
            for (int j = 1; j <= 100; j++)
            {
                // Calculate(j);

               Thread.Sleep(12);
                workerResult[0] = "Loading...";

                backgroundWorker1.ReportProgress(j, workerResult);

                // backgroundWorker1.
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           
            string[] results = (string[])e.UserState;
            // label2.Text = "";
            // label2.Text=(results[0]); // line of error
            // MessageBox.Show(results[1]); // line of error
            progressBar1.Value = e.ProgressPercentage;
            //  this.Text = "mlkk";

            // progressBar1.Value= e.
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            g.deletep();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            g.cc();
            x.Show();
            backgroundWorker1.RunWorkerAsync();
            //x.nm();
            
        }
    }
}
