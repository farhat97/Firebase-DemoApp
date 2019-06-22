using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Service_Demo_App
{
    public partial class RetrieveHoursControl : UserControl
    {
        // initialize as singleton
        private static RetrieveHoursControl instance;

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
        }
    }
}
