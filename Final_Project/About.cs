
/* Authors : Hongju Shin & Eisha Aqeel
 * Date: 27 Mar 2022
 * Description: About form
 */


using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
