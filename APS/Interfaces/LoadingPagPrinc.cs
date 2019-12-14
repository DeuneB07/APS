using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS.Interfaces
{
    public partial class LoadingPagPrinc : Form
    {
        public LoadingPagPrinc()
        {
            InitializeComponent();
        }

        private void LoadingPagPrinc_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = global::APS.Properties.Resources.Loading_2; 
        }
    }

}
