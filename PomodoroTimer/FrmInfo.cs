using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            picTomato.Image = Image.FromFile(Application.StartupPath + @"\images\icons8-tomato-64.png");

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(linkLabel1, "https://github.com/ErickMaia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(linkLabel2, "https://icons8.com/icons/set/tomato--v2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.", Application.ProductName);
            }
        }

        private void VisitLink(LinkLabel LLbl, string link)
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            LLbl.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start(link);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(linkLabel3, "https://github.com/ErickMaia/winforms-pomodoro-timer/blob/master/LICENSE");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.", Application.ProductName);
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink(linkLabel4, "https://github.com/ErickMaia/winforms-pomodoro-timer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.", Application.ProductName);
            }
        }
    }
}
