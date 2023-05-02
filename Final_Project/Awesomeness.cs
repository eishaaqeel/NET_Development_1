#region Info
/* Authors : Hongju Shin & Eisha Aqeel
 * Date: 17 Apr 2022
 * Description: Awesome form
 */
#endregion

using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Awesomeness : Form
    {
        public Awesomeness()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes they are :)");
            this.Close();
        }

        private void mouse_hover(object sender, EventArgs e)
        {

            var mousecursor = this.PointToClient(Cursor.Position);  // get the mouse position in the app

            if (mousecursor.X > 100 && mousecursor.X < 175)  // if the mouse is the original location of the button
            {
                btnNo.Left = btnNo.Left + 100;  // move the button

            }
            else                                // if the button is not there
            {
                btnNo.Left = btnNo.Left - 100;  // back to original location

            }

        }

    }
}
