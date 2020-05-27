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
using Test;
namespace WindowsFormsApplication24
{
    public partial class Form2 : Form
    {
       // public new  Form1 tc;
       PK g = new PK();
       Form1 uo = new Form1();
        private object[] dataGridViewRow;

        public Form2()
        {
            InitializeComponent();
          //  backgroundWorker1.RunWorkerAsync();
            // this.Controls.Add(uo.kk);
            /*  this.Controls.Add(g.idk());
                 g.idk().Location = new System.Drawing.Point(36, 6);
                 // this.textBox1.Name = "textBox1";
                 g.idk().Size = new System.Drawing.Size(100, 20);
               //  Form1 ui = new Form1();

                 //this.textBox1.TabIndex = 1;

                 this.Controls.Add(g.passk());

                 g.passk().Location = new System.Drawing.Point(200, 6);
                 // this.textBox1.Name = "textBox1";
                 g.passk().Size = new System.Drawing.Size(100, 20);
                // g.passk().UseSystemPasswordChar = true;
                 // this.textBox1.TabIndex = 3;*/

           g.er().Show();
            this.Controls.Add(g.dtagrid());
            this.Controls.Add(g.datak());
            g.dtagrid().AllowUserToAddRows = false;

            g.dtagrid().KeyDown += Form2_KeyDown1;
           // g.datak().AllowUserToAddRows = false;
          this.Controls.Add(g.button());
            g.button().Click += Form2_Click;
            //  this.ActiveControl = g.datak();

         //   g.dtagrid().Controls.Add(g.er());
            //
            //  this.AcceptButton = button1;
            g.datax().Controls.Add(label2);
            g.er().MouseClick += Form2_MouseClick;
            //  this.Controls.Add(g.di());
            // g.Dis();
            g.dtagrid().RowsAdded += Form2_RowsAdded;
        g.Function();
     // g.focusx();

        }
        public void nn()
        {
           // Thread.Sleep(5);

           
          //  g.dtagrid().Focus();
        }
        private void Form2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void Form2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          //  g.er().Hide();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
           
       g.er().Hide();

            if (g.dtagrid().Columns["Godown"] != null)
            {

                g.dtagrid().Rows.Add(textBox1.Text);
               // if(textBox1.Text!=nu)
                //  g.dtagrid().AllowUserToAddRows = false;
               // label2.Hide();
                // g.er().Hide();

            }
        }

        private void Form2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           // g.er().Hide();
        }

       private void  dxz()
        {
           
            MessageBox.Show("Press Enter to Input Data");
         //label2.
        }

        private void BeginInvoke(object v)
        {
            throw new NotImplementedException();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
           // g.Function();
         
    //  Thread st = new Thread(dxz);
           // Thread.Sleep(3);
  // st.SetApartmentState(ApartmentState.MTA);

          //  Thread.Sleep(9);
           // st.Start();
            
        }

        private void Form2_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (g.dtagrid().Columns["Godown"] != null)
                {
                   // label2.Show();
                    g.dtagrid().Rows.Add(textBox1.Text);
                    //  g.dtagrid().AllowUserToAddRows = false;
                    label2.Hide();
                  g.er().Hide();

                }



            }
            
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

        private void Form2_Load(object sender, EventArgs e)
        {
            // g.datak().AllowUserToAddRows = true;

            g.dtagrid().CellEnter += Form2_CellEnter;

        }

        private void Form2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //g.dtagrid().Rows.Add(1);
        }

        private void Form2_RowEnter1(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form2_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Escape)
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }


    
        private void button1_Click_1(object sender, EventArgs e)
        {

            

       // Form1 gh = new Form1();
          //  g.idk().Text = gh.te
           // STAThreadAttribute y = new STAThreadAttribute();



            //  t.Hide();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

             if (g.dtagrid().Columns["Godown"] != null)
            {
                   
                g.dtagrid().Rows.Add(textBox1.Text);
                  g.er().Hide();
                }
                if (g.dtagrid().Columns["Product_Name"] == null)
                {

                    g.dtagrid().AllowUserToAddRows = false;
                    label2.Show();
                }

            }

        }

      
    }
}
