using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication24
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
           progressBar1.Hide();
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
                workerResult[0] =  "Loading...";

                backgroundWorker1.ReportProgress(j,workerResult);
            
             // backgroundWorker1.
            }
            //backgroundWorker1.ReportProgress(0,workerResult);
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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           backgroundWorker1.RunWorkerAsync();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
