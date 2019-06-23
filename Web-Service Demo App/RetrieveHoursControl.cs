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
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Web_Service_Demo_App
{
    public partial class RetrieveHoursControl : UserControl
    {
        // initialize as singleton
        private static RetrieveHoursControl instance;

        private List<ShiftData> shiftList;
        public DataTable dataTable = new DataTable();

        public static RetrieveHoursControl Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RetrieveHoursControl();
                }

                return instance;
            }
        }

        public RetrieveHoursControl()
        {
            InitializeComponent();

            LoadDataTable();
        }

        // function to retrieve data
        public async Task Get()
        {
            Control activeControl = this.FindForm();
            IFirebaseClient firebaseClient = ((Form1)activeControl).GetFirebaseClient();

            //var result = await firebaseClient.GetTaskAsync("EmployeeShifts/");
            FirebaseResponse response = await firebaseClient.GetTaskAsync("EmployeeShifts/");
            ShiftData shiftData = response.ResultAs<ShiftData>();

            /*while (shiftData != null)
            {
                DataRow row = dataTable.NewRow();

                row["ID"] = shiftData.Id;
                row["Name"] = shiftData.Name;
                row["Date"] = shiftData.Date;
                row["Start Time"] = shiftData.startTime;
                row["End Time"] = shiftData.endTime;

                Console.WriteLine("Debug: " + shiftData.Id);
            }*/
        }

        public void GetTest()
        {
            using (var webClient = new WebClient())
            {
                // get string representation of JSON data
                string rawJSON = webClient.DownloadString("https://se465-webservice.firebaseio.com/.json");

                // convert to a list of shift objects
                //ShiftCollection shiftCollection = JsonConvert.DeserializeObject<ShiftCollection>(rawJSON);

                // convert rawJSON into JSON object
                JObject json = JObject.Parse(rawJSON);

                Console.WriteLine("Shift JSON: ");
                Console.WriteLine(rawJSON);

            }
        }

        private void LoadDataTable()
        {
            // populate data rows
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Start Time");
            dataTable.Columns.Add("End Time");

            dataGridView.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get();
            GetTest();
        }
    }
}
