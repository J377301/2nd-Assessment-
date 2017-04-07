using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
// This program was written by Shermayne Lee Ziqing
// It forms the base of a converter program for the OS-Assessment Two for Cert IV
// Date : April 2017
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double[] dbl_UofM = new double[5];
        double[] dbl_Convert = new double[5];
        int cnt = 0;


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
