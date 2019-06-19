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
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "jv77QY23T89MK7GJw0QVHRi4WK1dwZmQyKUVzkri",
            BasePath = "https://se465-webservice.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            /*if(client != null)
            {
                MessageBox.Show("Connection Successful"); // remove later
            }*/
        }

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

        private async void insertButton_Click(object sender, EventArgs e)
        {
            var shiftData = new ShiftData
            {
                Id = idText.Text,
                Name = nameText.Text,
                Date = dateText.Text,
                startTime = startTimeText.Text,
                endTime = endTimeText.Text
            };

            SetResponse response = await client.SetTaskAsync("EmployeeShifts/" + idText.Text, shiftData);
            ShiftData result = response.ResultAs<ShiftData>();

            MessageBox.Show("Shift inserted for " + result.Name);
        }
    }
}
