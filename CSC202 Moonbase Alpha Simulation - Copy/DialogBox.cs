using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC202_Moonbase_Alpha_Simulation
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void BTNclose_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the DialogBox form

        }
    }
}
