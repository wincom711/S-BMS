using System;
using Test;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication24
{
    public partial class Form7 : Form
    {
        PK g = new PK();
        public Form7()
        {
            InitializeComponent();
            //  this.Controls.Add(g.di());

           // label2.Visible = false;
           this.Controls.Add(g.dtagrid());
            g.cc();
           // g.Dis();
            // g.di().Click += Form6_Click;

            // g.df();
            //g.deletep();

        }

        private void Form7_Click(object sender, EventArgs e)
        {
        
        }

        protected override void OnLoad(EventArgs e)
        {

            PlaceLowerRight();
            base.OnLoad(e);

        }

        private void PlaceLowerRight()
        {

            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - 1350;
            this.Top = rightmost.WorkingArea.Bottom - 670;
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        public void d()
        {
           // g.dtagrid().Cursor = Cursors.WaitCursor;
        }

        public void ghc()
        {
            Thread.Sleep(10);
            g.deletep();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          /*  var t = new Thread((ThreadStart)(() => {

                Form10 f = new Form10();
                f.ShowDialog();

            }));*/
            //  t.SetApartmentState(ApartmentState.STA);

            //t.Join();
           // t.Start();
         
          //  g.deletep();
           // t.Abort();
            /*if (!t.Join(TimeSpan.FromSeconds(5)))
            {
                t.Abort();
               



            }*/

            // label2.Visible = true;
            // Thread.Sleep(12);
            // Thread vn = new Thread(ghc);
            //Thread.Sleep(10);
            //  vn.Start();

           g.deletep();
           

        }
        public void nm()
        {
            g.deletep();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
          
            g.dtagrid().DataSource = null;
            g.dtagrid().Columns.Clear();
            g.zx();
            g.dtagrid().Columns.Add(g.chkk());
            g.dtagrid().AllowUserToAddRows = false;
            // backgroundWorker1.RunWorkerAsync();

            //  g.df();
            //progressBar1.BackColor = System.Drawing.Color.Green;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.dtagrid().DataSource = null;
            g.dtagrid().Columns.Clear();
            g.zx();
           g.dtagrid().Columns.Add(g.chkk());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Apple();
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.Applex();
        }

     
    }
}
