using System;
using System.Windows.Forms;

namespace scramblemirror
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox2.Text = "";
            else
            {
                if (textBox1.Text[0] == '\'' || textBox1.Text[0] == ')' || textBox1.Text[0] == '2') MessageBox.Show("scramble can't start with ' or ) or 2");
                {
                    textBox2.Text = "";
                    string scri = textBox1.Text.Replace(" ", "");
                    int r = 0;
                    do
                    {
                        if (scri[r] == '(')
                        {
                            textBox2.Text += "(";
                            r++;
                        }
                        else if (scri[r] == ')')
                        {
                            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                            textBox2.Text += ") ";
                            r++;
                        }
                        else
                        {
                            if (scri[r] == 'R')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton1.Checked == true) textBox2.Text += "L' ";
                                    else textBox2.Text += "R' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "L ";
                                        else textBox2.Text += "R ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "L2 ";
                                        else textBox2.Text += "R2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "L' ";
                                        else textBox2.Text += "R' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'L')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton1.Checked == true) textBox2.Text += "R' ";
                                    else textBox2.Text += "L' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "R ";
                                        else textBox2.Text += "L ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "R2 ";
                                        else textBox2.Text += "L2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "R' ";
                                        else textBox2.Text += "L' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'r')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton1.Checked == true) textBox2.Text += "l' ";
                                    else textBox2.Text += "r' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "l ";
                                        else textBox2.Text += "r ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "l2 ";
                                        else textBox2.Text += "r2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "l' ";
                                        else textBox2.Text += "r' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'l')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton1.Checked == true) textBox2.Text += "r' ";
                                    else textBox2.Text += "l' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "r ";
                                        else textBox2.Text += "l ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "r2 ";
                                        else textBox2.Text += "l2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "r' ";
                                        else textBox2.Text += "l' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'U')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton2.Checked == true) textBox2.Text += "D' ";
                                    else textBox2.Text += "U' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "D ";
                                        else textBox2.Text += "U ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "D2 ";
                                        else textBox2.Text += "U2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "D' ";
                                        else textBox2.Text += "U' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'u')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton2.Checked == true) textBox2.Text += "d' ";
                                    else textBox2.Text += "u' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "d ";
                                        else textBox2.Text += "u ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "d2 ";
                                        else textBox2.Text += "u2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "d' ";
                                        else textBox2.Text += "u' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'D')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton2.Checked == true) textBox2.Text += "U' ";
                                    else textBox2.Text += "D' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "U ";
                                        else textBox2.Text += "D ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "U2 ";
                                        else textBox2.Text += "D2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "U' ";
                                        else textBox2.Text += "D' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'd')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton2.Checked == true) textBox2.Text += "u' ";
                                    else textBox2.Text += "d' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "u ";
                                        else textBox2.Text += "d ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "u2 ";
                                        else textBox2.Text += "d2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "u' ";
                                        else textBox2.Text += "d' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'F')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton3.Checked == true) textBox2.Text += "B' ";
                                    else textBox2.Text += "F' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "B ";
                                        else textBox2.Text += "F ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "B2 ";
                                        else textBox2.Text += "F2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "B' ";
                                        else textBox2.Text += "F' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'f')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton3.Checked == true) textBox2.Text += "b' ";
                                    else textBox2.Text += "f' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "b ";
                                        else textBox2.Text += "f ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "b2 ";
                                        else textBox2.Text += "f2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "b' ";
                                        else textBox2.Text += "f' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'B')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton3.Checked == true) textBox2.Text += "F' ";
                                    else textBox2.Text += "B' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "F ";
                                        else textBox2.Text += "B ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "F2 ";
                                        else textBox2.Text += "B2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "F' ";
                                        else textBox2.Text += "B' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'b')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton3.Checked == true) textBox2.Text += "f' ";
                                    else textBox2.Text += "b' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "f ";
                                        else textBox2.Text += "b ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "f2 ";
                                        else textBox2.Text += "b2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "f' ";
                                        else textBox2.Text += "b' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'M')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton1.Checked == true) textBox2.Text += "M ";
                                    else textBox2.Text += "M' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "M' ";
                                        else textBox2.Text += "M ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        textBox2.Text += "M2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "M ";
                                        else textBox2.Text += "M' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'E')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton2.Checked == true) textBox2.Text += "E ";
                                    else textBox2.Text += "E' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "E' ";
                                        else textBox2.Text += "E ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        textBox2.Text += "E2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "E ";
                                        else textBox2.Text += "E' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'S')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton3.Checked == true) textBox2.Text += "S ";
                                    else textBox2.Text += "S' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "S' ";
                                        else textBox2.Text += "S ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        textBox2.Text += "S2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "S ";
                                        else textBox2.Text += "S' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'x')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton1.Checked == true) textBox2.Text += "x ";
                                    else textBox2.Text += "x' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "x' ";
                                        else textBox2.Text += "x ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        textBox2.Text += "x2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton1.Checked == true) textBox2.Text += "x ";
                                        else textBox2.Text += "x' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'y')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton2.Checked == true) textBox2.Text += "y ";
                                    else textBox2.Text += "y' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "y' ";
                                        else textBox2.Text += "y ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        textBox2.Text += "y2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton2.Checked == true) textBox2.Text += "y ";
                                        else textBox2.Text += "y' ";
                                        r++;
                                    }
                                }
                            }
                            //---------------------------------
                            else if (scri[r] == 'z')
                            {
                                if (r == scri.Length - 1)
                                {
                                    if (radioButton3.Checked == true) textBox2.Text += "z ";
                                    else textBox2.Text += "z' ";
                                    r++;
                                }
                                else
                                {
                                    if (scri[r + 1] == '\'')
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "z' ";
                                        else textBox2.Text += "z ";
                                        r += 2;
                                    }
                                    else if (scri[r + 1] == '2')
                                    {
                                        textBox2.Text += "z2 ";
                                        r += 2;
                                    }
                                    else
                                    {
                                        if (radioButton3.Checked == true) textBox2.Text += "z ";
                                        else textBox2.Text += "z' ";
                                        r++;
                                    }
                                }
                            }
                            else
                            {
                                textBox2.Text = "";
                                MessageBox.Show("somethin wrong, i can feel it");
                                break;
                            }
                        }
                    } while (r < scri.Length);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox2.Text = "";
            else
            {
                if (textBox1.Text[0] == '\'' || textBox1.Text[0] == ')' || textBox1.Text[0] == '2') MessageBox.Show("scramble can't start with ' or ) or 2");
                {
                    textBox2.Text = "";
                    string scr = textBox1.Text.Replace(" ", "");
                    int y = scr.Length - 1;
                    do
                    {
                        if (scr[y] == '\'')
                        {
                            textBox2.Text += scr[y - 1] + " ";
                            y -= 2;
                        }
                        else if (scr[y] == '2')
                        {
                            textBox2.Text += scr[y - 1] + "2 ";
                            y -= 2;
                        }
                        else if (scr[y] == ')')
                        {
                            textBox2.Text += "(";
                            y--;
                        }
                        else if (scr[y] == '(')
                        {
                            textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                            textBox2.Text += ") ";
                            y--;
                        }
                        else
                        {
                            textBox2.Text += scr[y] + "' ";
                            y--;
                        }
                    } while (y >= 0);
                }
            }
        }
    }
}
