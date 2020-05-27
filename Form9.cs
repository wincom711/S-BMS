using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    public partial class Form9 : Form
    {
        private object th;
        String gh;

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vb();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //textBox3.Focus();
        }


        public void vb()
        {
            try
            {
                if (textBox3.Text != String.Empty && textBox2.Text != String.Empty)
                {
                    String xx = @"data source=E:\Stock\Admin_Database.db";
                    String gl = @"Update  RT set [PASS]= '" + textBox2.Text.ToString() + "'  where [Name]='" + textBox3.Text.ToString() + "' ";        //([UI],[PASS],[Name])  VALUES (@ass,@ghhh,@l)"
                    String glx = @"select  [PASS] from rt where  [Name]= '" + textBox3.Text + "'";
                    SQLiteConnection conx = new SQLiteConnection(xx);
                    SQLiteCommand cmd = new SQLiteCommand(gl, conx);
                    SQLiteCommand cmdx = new SQLiteCommand(glx, conx);
                    DataSet da = new DataSet();
                    conx.Open();

                    String gh = cmdx.ExecuteScalar().ToString();


                    MessageBox.Show(gh);



                    if (textBox1.Text == gh)
                    {
                       // BeginInvoke(th);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Changed Password Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Invalid old password");
                        textBox1.BackColor = Color.Red;
                        textBox1.Text = "";

                    }
                    conx.Close();
                }



                else
                {
                    MessageBox.Show("Enter Id And password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid user id");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox3.BackColor = Color.Red;
            }
        }

        private void BeginInvoke(object th)
        {
          //  textBox1.BackColor = Color.LightGreen;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                textBox1.BackColor = Color.White;
                textBox1.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //button1.BackColor = Color.Green;
             button1.Focus();

            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            String xx = @"data source=E:\Stock\Admin_Database.db";
            // String gl = @"Update  RT set [PASS]= '" + textBox2.Text.ToString() + "'  where [Name]='" + textBox3.Text.ToString() + "' ";        //([UI],[PASS],[Name])  VALUES (@ass,@ghhh,@l)"
            String glx = @"select  [PASS] from rt where  [Name]= '" + textBox3.Text + "'";
            SQLiteConnection conx = new SQLiteConnection(xx);
            //SQLiteCommand cmd = new SQLiteCommand(gl, conx);
            SQLiteCommand cmdx = new SQLiteCommand(glx, conx);
            DataSet da = new DataSet();

            conx.Open();
            try
            {
                gh = cmdx.ExecuteScalar().ToString();
            }
            catch (Exception es)
            {
                textBox3.BackColor = Color.Red;
            }

            //  MessageBox.Show(gh);



            if (textBox1.Text == gh)
            {
                textBox1.BackColor = Color.LightGreen;
                // cmd.ExecuteNonQuery();
                // MessageBox.Show("Changed Password Successfully");

            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_ModifiedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            String xx = @"data source=E:\Stock\Admin_Database.db";
            // String gl = @"Update  RT set [PASS]= '" + textBox2.Text.ToString() + "'  where [Name]='" + textBox3.Text.ToString() + "' ";        //([UI],[PASS],[Name])  VALUES (@ass,@ghhh,@l)"
            String glx = @"select  [PASS] from rt where  [Name]= '" + textBox3.Text + "'";
            SQLiteConnection conx = new SQLiteConnection(xx);
            //SQLiteCommand cmd = new SQLiteCommand(gl, conx);
            SQLiteCommand cmdx = new SQLiteCommand(glx, conx);
            DataSet da = new DataSet();

            conx.Open();
            try
            {
                gh = cmdx.ExecuteScalar().ToString();
            }
            catch (Exception es)
            {
                textBox3.BackColor = Color.Red;
            }

            //  MessageBox.Show(gh);



            if (textBox1.Text == gh)
            {
                textBox1.BackColor = Color.LightGreen;
                // cmd.ExecuteNonQuery();
                // MessageBox.Show("Changed Password Successfully");

            }
        }
    }
}
    

