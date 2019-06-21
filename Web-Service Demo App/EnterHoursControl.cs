using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;

namespace Web_Service_Demo_App
{
    public partial class EnterHoursControl : UserControl
    {
        // initialize as singleton
        private static EnterHoursControl instance;

        // retrieve client connection to Firebase
        public IFirebaseClient firebaseClient { get; set; }

        public static EnterHoursControl Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new EnterHoursControl();
                }

                return instance;
            }
        }

        public EnterHoursControl()
        {
            InitializeComponent();
        }

        // insert button function
        private async void insertButton_Click_1(object sender, EventArgs e)
        {
            var shiftData = new ShiftData
            {
                Id = idText.Text,
                Name = nameText.Text,
                Date = dateText.Text,
                startTime = startTimeText.Text,
                endTime = endTimeText.Text
            };

            if (firebaseClient != null)
            {
                SetResponse response = await firebaseClient.SetTaskAsync("EmployeeShifts/" + idText.Text, shiftData);
                ShiftData result = response.ResultAs<ShiftData>();

                MessageBox.Show("Shift inserted for " + result.Name);
            }
            else
                Console.WriteLine("Error inserting data");
        }

        // clear button function
        // there is probably a better way to do this but in the mean time
        private void clearButton_Click(object sender, EventArgs e)
        {
            idText.Text = "";
            nameText.Text = "";
            dateText.Text = "";
            startTimeText.Text = "";
            endTimeText.Text = "";
        }
    }
}
