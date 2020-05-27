using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {
        

        Label chp = new Label();
        PK g = new PK();
        private string pxv;

        //  private string selectedPath;

        // private Keys keyData;
        // string selectedPath;

        public Form1()
        {
            //Thread.Sleep(100);
           
            // progressBar1.Maximum = 100;
            // progressBar1.Step = 1;
            // progressBar1.Value = 0;
            //  progressBar1.Focus();


            InitializeComponent();
            chp.Click += Chp_Click;
            chp.MouseHover += Chp_MouseHover;
            chp.MouseLeave += Chp_MouseLeave;
            //   Form1 uo = new Form1();

            //  this.ActiveControl = g.datak();
            //
            //  this.AcceptButton = button1;
            g.Function();
            //  this.Controls.Add(g.idk());
            //g.save();
            //  this.Controls.Add(g.idk());
            // g.idk().Text = "pop";
            // Form5 tt = new Form5();
            // textBox3.Text = tt.p;

            /*   if (!rk.Join(TimeSpan.FromSeconds(100)))
                     {
                         rk.Abort();



                     }*/
            //  this.Controls.Add(g.idk());
            //  g.idk().Text = textBox1.Text;
            g.cvv();
            g.Stock().Click += Form1_Click2;
            //  this.components = new System.ComponentModel.Cont
          //  this.Controls.Add(g.f());
            g.xc().Click += Form1_Click;
            g.bb().Click += Form2_Click;
            g.Display().Click += Form1_Click3;
            MenuStrip x = new MenuStrip();
            g.drop();
            // x.ContextMenu.
            //g.vb();

            g.EditProduct().Click += Form1_Click4;
            g.ft().Click += Form1_Click1;

            g.xcc().Click += Form1_Click5;

        }

        private void Chp_MouseLeave(object sender, EventArgs e)
        {
            chp.ForeColor = Color.DarkKhaki;
            chp.Cursor = Cursors.Hand;
        }

        private void Chp_MouseHover(object sender, EventArgs e)
        {
            chp.ForeColor = Color.AliceBlue;
        }

        private void Form1_Click5(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form8))
                {
                    form.Activate();

                    return;
                }
                // button2.Visible = false;
            }
            //button2.Visible = true;
            Form newForm = new Form8();
            newForm.BackColor = Color.Wheat;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void Form1_Click4(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form7))
                {
                    form.Activate();

                    return;
                }
                // button2.Visible = false;
            }
            //button2.Visible = true;
            Form newForm = new Form7();
            newForm.BackColor = Color.Wheat;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void Form1_Click3(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form6))
                {
                    form.Activate();

                    return;
                }
                // button2.Visible = false;
            }
            //button2.Visible = true;
            Form newForm = new Form6();
            newForm.BackColor = Color.Wheat;
            newForm.MdiParent = this;
            newForm.Show();

        }

        public Control kk
        {
            get
            {
                return g.idk();

            }
           
        }
        private void Form1_Click2(object sender, EventArgs e)
        {
    
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Form2))
                    {
                        form.Activate();

                        return;
                    }
                    // button2.Visible = false;
                }
                //button2.Visible = true;
                Form newForm = new Form2();
                newForm.BackColor = Color.Wheat;
                newForm.MdiParent = this;
                newForm.Show();
          //  g.datax().Controls.Add(g.er());


        }
        

       

        private void Form1_Click1(object sender, EventArgs e)
        {
          
            
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";


                this.Controls.RemoveAt(2);
                chp.Hide();
                g.ft().Hide();
                
                g.uoo().Text = textBox1.Text;

                g.ft().Text = textBox1.Text + "\nLogin";
               
                while(ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
                // pane.Focus();
               // textBox1.Focus().ToString();
               
                groupBox1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           // g.menu().Dispose();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
          
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form3))
                {
                    form.Activate();

                    return;
                }
                // button2.Visible = false;
            }
            //button2.Visible = true;
            Form newForm = new Form3();
            newForm.BackColor = Color.DarkGray;
            newForm.MdiParent = this;
            newForm.Show();
        
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form3))
                {
                    form.Activate();

                    return;
                }
                // button2.Visible = false;
            }
            //button2.Visible = true;
            Form newForm = new Form2();
           newForm.BackColor = Color.Black;
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();





           
        
         /*   if (!rk.Join(TimeSpan.FromSeconds(100)))
            {
                rk.Abort();
               // Application.Run(new Form1());


            }*/
            

        /*    var t = new Thread((ThreadStart)(() => {
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
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
               
                    client.BackColor = Color.White;
                    client.BackgroundImage = global::WindowsFormsApplication24.Resource1.pawanc;
                    // 4#
                    break;
                }
            }
        }


       


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape) && this.ActiveMdiChild != null)
            {






                ActiveMdiChild.Close();
            

                   
                    
                    // button2.Visible = false;
               


                // button2.Visible = false;




                // button2.Visible = false;
            }
            if (keyData== Keys.Control|keyData==Keys.Space && textBox1.Focused==true && textBox2.Focused==true)
            {



                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(Form2))
                    {
                        form.Activate();

                        return true;
                    }
                    // button2.Visible = false;
                }
                //button2.Visible = true;
                Form newForm = new Form2();
                newForm.BackColor = Color.Wheat;
                newForm.MdiParent = this;
                newForm.Show();





                // button2.Visible = false;
            }



            // button2.Visible = false;



            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void call()
        {
            chp.Show();
            chp.Location = new System.Drawing.Point(1050, 10);
            // chp.Name = "button3";
            chp.Size = new System.Drawing.Size(200, 32);
            // chp.TabIndex = 8;
         chp.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chp.ForeColor = Color.DarkKhaki;
           // chp.UseVisualStyleBackColor = true;
            chp.Text = "Change Password";
            g.f().Controls.Add(chp);
           
            g.idk().Text = textBox1.Text;
            // this.Controls.Add(g.idk());
            // g.ui.Text = textBox1.Text;
            if (textBox2.Focus() == true)
            {
                int c = 0, b = 0; ;

                String xx = @"data source=E:\Stock\Admin_Database.db";
                String gl = @"SELECT * FROM  RT";        //([UI],[PASS],[Name])  VALUES (@ass,@ghhh,@l)"
                SQLiteConnection conx = new SQLiteConnection(xx);
                conx.Open();
                //  MessageBox.Show("jklj");
                SQLiteDataAdapter da = new SQLiteDataAdapter(gl, conx);
                DataSet ds = new DataSet();
                da.Fill(ds, "RT");
                //  String m = th.Text;
                int ui = ds.Tables["RT"].Rows.Count;

                String ghy = "";
                String nm = "";
                for (int i = 0; i <= ui - 1; i++)
                {
                    if (textBox1.Text == ds.Tables["RT"].Rows[i].ItemArray[2].ToString() && textBox2.Text == ds.Tables["RT"].Rows[i].ItemArray[1].ToString())
                    {


                       ghy = ds.Tables["RT"].Rows[i].ItemArray[2].ToString();
                    nm = ds.Tables["RT"].Rows[i].ItemArray[1].ToString();

                    }
                }
                //  g.Menu();
                // g.f.BackColor = Color.Black;
                //   g.f.Click += new EventHandler(uc);
                //  g.f.MouseHover += new EventHandler(yu);
                //this.Container.Add(g.f);
                if (textBox1.Text != String.Empty )
                {
                    if (textBox1.Text == ghy && textBox2.Text == nm)
                    {
                        g.ft().Show();
                        this.Controls.Add(g.f());

                        g.xmn();

                        this.Controls.Add(g.menu());

                        // this.Controls.Add(g.bb());
                        // this.AcceptButton = g.bb();
                        g.uoo().Text = textBox1.Text;

                        g.ft().Text = textBox1.Text + "\nLogout";
                        groupBox1.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid userid or password");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Input userid or password");
                }
            }
            }

        private void Chp_Click(object sender, EventArgs e)
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Form9))
                {
                    form.Activate();

              return ;
                }
                // button2.Visible = false;
            }
            //button2.Visible = true;
            Form newForm = new Form9();
            newForm.BackColor = Color.Wheat;
            newForm.MdiParent = this;
            newForm.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            call();
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter)
                {

                call();
            }
             
            
        }

        public String gh
        {
            get
            {
                return g.uoo().Text = textBox1.Text;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
           // Form2 tr = new Form2();

           // tr.Controls.Remove(g.idk());
          //  Form1 gh = new Form1();
          //  MessageBox.Show(gh);
            //  Form2 t = new Form2();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                textBox2.Focus();
            }

        }
    }
} 
    

