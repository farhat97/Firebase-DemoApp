using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Web_Service_Demo_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        #region FirebaseConnection
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "jv77QY23T89MK7GJw0QVHRi4WK1dwZmQyKUVzkri",
            BasePath = "https://se465-webservice.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connection Successful"); // remove later
                EnterHoursControl.Instance.firebaseClient = client;
            }
            else
                MessageBox.Show("Error in connection");
        }
        #endregion

        

        #region GeneratedClicks
        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        // main buttons

        private void enterHrsBtn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(EnterHoursControl.Instance))
            {
                panel.Controls.Add(EnterHoursControl.Instance);
                EnterHoursControl.Instance.Dock = DockStyle.Fill;
                EnterHoursControl.Instance.BringToFront();
            }
            else
                EnterHoursControl.Instance.BringToFront();

            // send client to HoursControl
            //EnterHoursControl.Instance.firebaseClient = client;

            panel.BringToFront();
        }

        public IFirebaseClient GetFirebaseClient()
        {
            if (client != null)
                return client;
            else
                return null;
        }

        private void retrieveHrsBtn_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(RetrieveHoursControl.Instance))
            {
                panel.Controls.Add(RetrieveHoursControl.Instance);
                RetrieveHoursControl.Instance.Dock = DockStyle.Fill;
                RetrieveHoursControl.Instance.BringToFront();
            }
            else
                RetrieveHoursControl.Instance.BringToFront();

            panel.BringToFront();
        }
    }
}
