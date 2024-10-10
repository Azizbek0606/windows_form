using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
namespace toolbox__copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            CenterTextInTextBox();
        }

        private void CenterTextInTextBox()
        {
            
        }
    }
}
