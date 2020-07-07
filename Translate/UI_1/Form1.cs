using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfija_Click(object sender, EventArgs e)
        {
            panelSelection.Height = btnInfija.Height;
            panelSelection.Top = btnInfija.Top;
        }

        private void btnPostfija_Click(object sender, EventArgs e)
        {
            panelSelection.Height = btnPostfija.Height;
            panelSelection.Top = btnPostfija.Top;
        }

        private void btnPrefija_Click(object sender, EventArgs e)
        {
            panelSelection.Height = btnPrefija.Height;
            panelSelection.Top = btnPrefija.Top;
        }

        private void btnMoveTop_Click(object sender, EventArgs e)
        {
            txtTranslate.Text = txtResult.Text;
        }
        
        private void btnGithub_Click(object sender, EventArgs e)
        {
            _ = System.Diagnostics.Process.Start("https://github.com/NeoTRAN001");
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            new Info().Show();
        }
    }
}
