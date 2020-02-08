using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALARME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = string.Concat(textBox1.Text.Where(char.IsDigit));

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(textBox2.Text.Where(char.IsDigit));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movel = " -- MÓVEL -- ";
            string gvt = " -- VIVO 2 - GVT -- ";
            string fixa = " -- VIVO 1 -- ";
            string fixaa = " -- VIVO 3 -- ";
            string cli = "CPF: ";
            string clip = "Linha: ";
            string end = "Endereço: ";

            if (textBox4.Text == "") {
                //movel
                if (radioButton1.Checked)
                {
                  
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text + Environment.NewLine
                        + clip + textBox2.Text + Environment.NewLine + movel );
                    
                }


                //fixa
                else if (radioButton2.Checked)
                {
                    Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text + Environment.NewLine
                        + clip + textBox2.Text + Environment.NewLine + fixa );
                }


                //gvt
                else if (radioButton3.Checked)
                {
                    Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text + Environment.NewLine
                        + clip + textBox2.Text + Environment.NewLine + gvt );
                }


                //fixa 3 
                else if (radioButton4.Checked)
                {
                    Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text + Environment.NewLine
                        + clip + textBox2.Text + Environment.NewLine + fixaa );
                }

                else
                {
                    Clipboard.SetText(textBox3.Text +
                  Environment.NewLine + cli + textBox1.Text + Environment.NewLine +
                  clip + textBox2.Text );
                }
            }
            //SEGUNDA PARTE
            else {
                if (radioButton1.Checked)
                {
                    if (textBox2.Text == "")
                    {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                            cli + textBox1.Text + Environment.NewLine + end + textBox4.Text 
                            + Environment.NewLine + movel);
                    }
                    else
                    {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                            cli + textBox1.Text + Environment.NewLine
                            + clip + textBox2.Text + Environment.NewLine + end + textBox4.Text 
                            + Environment.NewLine + movel);
                    }



                }
                //fixa
                else if (radioButton2.Checked)
                {
                    if (textBox2.Text == "") {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                            cli + textBox1.Text + Environment.NewLine + end + textBox4.Text + Environment.NewLine + fixa );
                    }
                    else {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                           cli + textBox1.Text + 
                           Environment.NewLine + clip + textBox2.Text + Environment.NewLine + end + textBox4.Text + Environment.NewLine + fixa );
                    }
                    
                }


                //gvt
                else if (radioButton3.Checked)
                {
                    if (textBox2.Text == "")
                    {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text + Environment.NewLine + end + textBox4.Text + Environment.NewLine + gvt );
                    }
                    else
                    {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text + Environment.NewLine
                        + clip + textBox2.Text + Environment.NewLine + end + textBox4.Text + Environment.NewLine + gvt );

                    }

                }


                //fixa 3 
                else if (radioButton4.Checked)
                {
                    if (textBox2.Text == "")
                    {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                        cli + textBox1.Text  + Environment.NewLine + end + textBox4.Text + Environment.NewLine + fixaa);
                    }
                    else
                    {
                        Clipboard.SetText(textBox3.Text + Environment.NewLine +
                       cli + textBox1.Text + Environment.NewLine
                       + clip + textBox2.Text + Environment.NewLine + end + textBox4.Text + Environment.NewLine + fixaa );
                    }
                }

                else
                {
                    Clipboard.SetText(textBox3.Text +
                  Environment.NewLine + cli + textBox1.Text + Environment.NewLine +
                  clip + textBox2.Text + Environment.NewLine + end + textBox4.Text );
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }
    }
}
