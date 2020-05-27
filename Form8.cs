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
    public partial class Form8 : Form
    {
       // Form7 t2 = new Form7();
        PK g = new PK();
        public Form8()
        {
            InitializeComponent();

            this.Controls.Add(g.dtagrid());
            g.cc();
           // this.Controls.Add(t2.)
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

        private void Form8_Load(object sender, EventArgs e)
        {
            g.dtagrid().DataSource = null;
            g.dtagrid().Columns.Clear();
            g.zx();
            g.dtagrid().Columns.Add(g.chkk());
            g.dtagrid().AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.dtagrid().DataSource = null;
            g.dtagrid().Columns.Clear();
            g.zx();
            g.dtagrid().Columns.Add(g.chkk());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Edits();
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
