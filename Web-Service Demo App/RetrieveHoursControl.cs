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
            /*Control activeControl = this.FindForm();
           
            IFirebaseClient firebaseClient = ((Form1)activeControl).GetFirebaseClient();
            var result = await firebaseClient.GetTaskAsync("EmployeeShifts/");

            // populate List of employee Shifts
            shiftList = new List<ShiftData>();
            foreach(var item in result)
            {

            }*/
        }

        private void LoadDataTable()
        {
            // populate data table
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Start Time");
            dataTable.Columns.Add("End Time");

            dataGridView.DataSource = dataTable;
        }
    }
}
