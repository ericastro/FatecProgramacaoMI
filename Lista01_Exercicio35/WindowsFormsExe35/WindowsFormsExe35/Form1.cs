using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExe35
{
    public partial class FormExe35 : Form
    {
        public FormExe35()
        {
            InitializeComponent();
        }

        private void btnGerarNumeros_Click(object sender, EventArgs e)
        {
            if( rtbPrincipal.Text != "" )
            {
                rtbPrincipal.Clear();
            }
            for(int i = 200; i < 1000; i++)
            {
                if( i % 2 == 0 && i % 8 == 0 )
                {
                    rtbPrincipal.AppendText(i.ToString() + Environment.NewLine);
                }
            }
        }
    }
}
