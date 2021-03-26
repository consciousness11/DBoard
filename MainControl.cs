using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBoard
{
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductEntry pe = new ProductEntry();
            MainControlClass.showControl(pe, content);
        }
    }
}
