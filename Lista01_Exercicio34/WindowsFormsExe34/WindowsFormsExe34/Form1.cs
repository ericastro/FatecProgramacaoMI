using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExe34
{
    public partial class FormExe34 : Form
    {
        public FormExe34()
        {
            InitializeComponent();
        }

        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            if( rtbPrincipal.Text != String.Empty )
            {
                rtbPrincipal.Clear();
            }
            for (int i = 100; i < 1001; i++)
            {
                if( i % 7 == 0 )
                    rtbPrincipal.AppendText(i.ToString() + Environment.NewLine);
            }

        }
    }
}
