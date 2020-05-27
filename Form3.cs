using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    
    public partial class Form3 : Form
    {
        DateTimePicker c = new DateTimePicker();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form3()
        {
            InitializeComponent();

          
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

            this.Left = rightmost.WorkingArea.Right - 1200;
            this.Top = rightmost.WorkingArea.Bottom - 650;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void domainUpDown1_Enter(object sender, EventArgs e)
        {
            DateTimePicker p = new DateTimePicker();
            this.Controls.Add(p);
            
            //Adding DateTimePicker control into DataGridView   
         

            // Setting the format (i.e. 2014-10-10)  
        

            // It returns the retangular area that represents the Display area for a cell  
    

            //Setting area for DateTimePicker Control  
           // c.Size = new Size(oRectangle.Width, oRectangle.Height);

            // Setting Location  
      

            // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
           // c.CloseUp += C_CloseUp;

            // An event attached to dateTimePicker Control which is fired when any date is selected  
          //  c.TextChanged += C_TextChanged;

            // Now make it visible  
        
        }
    }
}
