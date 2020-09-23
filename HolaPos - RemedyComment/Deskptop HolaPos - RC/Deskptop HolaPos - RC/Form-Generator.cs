using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deskptop_HolaPos___RC
{
    public partial class Form1 : Form
    {
        private string _clipBoardSetterText;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Clipboard_gen_Click(object sender, EventArgs e)
        {
            _clipBoardSetterText = "[SP] " + textBox1.Text + Environment.NewLine + Environment.NewLine;
            _clipBoardSetterText += richTextBox1.Text.Trim() + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            if (textBox2.Text.Trim() != "")
            {
                _clipBoardSetterText += "En base a procedimiento: " + textBox2.Text.Trim();
            }
            Clipboard.SetText(_clipBoardSetterText);
        }
    }
}
