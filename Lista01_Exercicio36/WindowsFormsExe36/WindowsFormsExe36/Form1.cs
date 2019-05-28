using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExe36
{
    public partial class FormExe36 : Form
    {
        public FormExe36()
        {
            InitializeComponent();
        }

        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            if( rtbPrincipal.Text != String.Empty )
            {
                rtbPrincipal.Clear();
            }
            for(int i = 999; i < 2001; i++)
            {
                if( i % 2 == 1 && i % 15 == 0)
                {
                    rtbPrincipal.AppendText(i.ToString() + Environment.NewLine);
                }
            }
        }
    }
}
