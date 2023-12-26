using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gryfo_GCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 1;
        }

        private void textBoxAdicionarNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out _))
            {
                textBoxAdicionarNumero.Text = string.Empty;
                e.Handled = true;
                return;
            }
        }

        // tela Cadastrar ocorrencia
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out _))
            {
                textBox19.Text = string.Empty;
                e.Handled = true;
                return;
            }

            if (textBox19.Text.Length > 9)
            {
                e.Handled = true;
                return;
            }

            if (textBox19.Text.Length == 1)
            {
                if(int.TryParse(textBox19.Text + e.KeyChar, out _)){
                    if (int.Parse(textBox19.Text + e.KeyChar) > 31)
                    {
                        textBox19.Text = string.Empty;
                        e.Handled = true;
                        return;
                    }
                }
            }

            if (textBox19.Text.Length == 4)
            {
                if (int.TryParse(textBox19.Text.Substring(3, 1) + e.KeyChar.ToString(), out _))
                {
                    if (int.Parse(textBox19.Text.Substring(3, 1) + e.KeyChar.ToString()) > 12)
                    {
                        textBox19.Text = string.Empty;
                        e.Handled = true;
                        return;
                    }
                }
            }

            if (textBox19.Text.Length == 9)
            {
                if (int.TryParse(textBox19.Text.Substring(6, 3) + e.KeyChar.ToString(), out _))
                {
                    if (int.Parse(textBox19.Text.Substring(6, 3) + e.KeyChar.ToString()) < 2022)
                    {
                        textBox19.Text = string.Empty;
                        e.Handled = true;
                        return;
                    }
                }
            }

            if (textBox19.Text.Length == 1)
            {
                textBox19.Text = textBox19.Text + e.KeyChar.ToString();
                textBox19.Text = textBox19.Text + "/";
                textBox19.SelectionStart = textBox19.Text.Length;
                e.Handled = true;
                return;
            }

            if (textBox19.Text.Length == 4)
            {
                textBox19.Text = textBox19.Text + e.KeyChar.ToString();
                textBox19.Text = textBox19.Text + "/";
                textBox19.SelectionStart = textBox19.Text.Length;
                e.Handled = true;
                return;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out _))
            {
                textBox20.Text = string.Empty;
                e.Handled = true;
                return;
            }

            if (textBox20.Text.Length > 7)
            {
                e.Handled = true;
                return;
            }

            if (textBox20.Text.Length == 1)
            {
                if (int.TryParse(textBox20.Text + e.KeyChar, out _))
                {
                    if (int.Parse(textBox20.Text + e.KeyChar) >= 24)
                    {
                        textBox20.Text = string.Empty;
                        e.Handled = true;
                        return;
                    }
                }
            }

            if (textBox20.Text.Length == 4)
            {
                if (int.TryParse(textBox20.Text.Substring(3, 1) + e.KeyChar.ToString(), out _))
                {
                    if (int.Parse(textBox20.Text.Substring(3, 1) + e.KeyChar.ToString()) >= 60)
                    {
                        textBox20.Text = string.Empty;
                        e.Handled = true;
                        return;
                    }
                }
            }

            if (textBox20.Text.Length == 1)
            {
                textBox20.Text = textBox20.Text + e.KeyChar.ToString();
                textBox20.Text = textBox20.Text + ":";
                textBox20.SelectionStart = textBox20.Text.Length;
                e.Handled = true;
                return;
            }

            if (textBox20.Text.Length == 4)
            {
                textBox20.Text = textBox20.Text + e.KeyChar.ToString();
                textBox20.Text = textBox20.Text + ":";
                textBox20.SelectionStart = textBox20.Text.Length;
                e.Handled = true;
                return;
            }
        }
    }
}
