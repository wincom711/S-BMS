using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;
namespace WindowsFormsApplication24
{
    public partial class Form6 : Form
    {
        PK g = new PK();
        
        public Form6()
        {
            InitializeComponent();
         /*   this.Controls.Add(g.idk());
            g.idk().Location = new System.Drawing.Point(36, 6);
            // this.textBox1.Name = "textBox1";
            g.idk().Size = new System.Drawing.Size(100, 20);
            //  Form1 ui = new Form1();

            //this.textBox1.TabIndex = 1;

            this.Controls.Add(g.passk());

            g.passk().Location = new System.Drawing.Point(200, 6);
            // this.textBox1.Name = "textBox1";
            g.passk().Size = new System.Drawing.Size(100, 20);*/
    this.Controls.Add(g.di());
         g.di().Location = new System.Drawing.Point(549, 537);
            this.Controls.Add(g.dtagrid());
            g.dtagrid().AllowUserToAddRows = false;
            // g.di().Click += Form6_Click;
       g.Dis();
           // g.cc();
           // g.Function();
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

    }
}
