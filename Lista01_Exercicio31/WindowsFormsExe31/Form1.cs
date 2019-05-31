using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExe31
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rtbExibir.Clear();
        }

        private void btnGerarWhile_Click(object sender, EventArgs e)
        {
            if( rtbExibir.Text != String.Empty)
            {
                rtbExibir.Clear();
            }
            int i = 53;
            while( i < 251 )
            {
                if (i % 2 == 0)
                {
                    rtbExibir.AppendText(i.ToString() + Environment.NewLine);
                }
                i++;     
            }
        }

        private void btnGerarFor_Click(object sender, EventArgs e)
        {
            if (rtbExibir.Text != String.Empty)
            {
                rtbExibir.Clear();
            }
            for (int i = 53; i < 251;i++)
            {
                if( i % 2 == 0)
                {
                    rtbExibir.AppendText(i.ToString() + Environment.NewLine);
                }
            }
        }
    }
}
