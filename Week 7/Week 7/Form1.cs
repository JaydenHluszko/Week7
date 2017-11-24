using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //capture x and y as variables
            Int32 x = Convert.ToInt32(txtX.Text);
            Int32 y = Convert.ToInt32(txtY.Text);
            //send x and y to the AddNumbers method & display the result
            Int32 result = AddNumbers(x,y);
            lblSum.Text = Convert.ToString(result);
        }

        private Int32 AddNumbers(Int32 x, Int32 y)
        {
            //add the 2 input parameter values together
            int sum = x + y;

            //send back the result
            return sum;
        }
    }
}
