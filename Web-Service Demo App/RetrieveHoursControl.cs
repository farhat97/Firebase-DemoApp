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

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Web;

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

            PassComplexData();
        }

        //public void GetTest()
        //{
        //    string rawJSON;
        //    using (var webClient = new WebClient())
        //    {
        //        // get string representation of JSON data
        //        rawJSON = webClient.DownloadString("https://se465-webservice.firebaseio.com/.json");

        //        // convert to a list of shift objects
        //        //ShiftCollection shiftCollection = JsonConvert.DeserializeObject<ShiftCollection>(rawJSON);

        //        // convert rawJSON into JSON object
        //        JObject json = JObject.Parse(rawJSON);

        //        // pass json object to web service


        //        Console.WriteLine("Shift JSON: ");
        //        Console.WriteLine(rawJSON);

        //    }
        //}

        /*public async Task<string> GetTest()
        {
            Console.WriteLine("In function");
            string response = "";

            var webClient = new WebClient();

            // get string representation of JSON data
            string rawJSON = webClient.DownloadString("https://se465-webservice.firebaseio.com/.json");

            // convert rawJSON into JSON object
            JObject json = JObject.Parse(rawJSON);

            try
            {
                HttpResponseMessage httpResponseMessage = null;

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var httpContent = new StringContent(rawJSON, Encoding.UTF8, "application/json");

                    httpResponseMessage = await httpClient.PostAsync("http://localhost:32160/api/home/GetShift", httpContent);

                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        response = "Some error occured." + httpResponseMessage.StatusCode;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while passing info");
            }

            return response;
        }*/

        public string PassComplexData()
        {
            string responseString = "";
            HttpWebResponse response = null;

            var webClient = new WebClient();

            // get string representation of JSON data
            string rawJSON = webClient.DownloadString("https://se465-webservice.firebaseio.com/.json");

            Console.WriteLine(rawJSON);

            // convert rawJSON into JSON object
            JObject json = JObject.Parse(rawJSON);

            try
            {
                var request = (HttpWebRequest)WebRequest.Create("http://localhost:64085/api/home/GetShift");

                request.Accept = "application/json";
                request.Method = "POST";

                ShiftData shift = new ShiftData()
                {
                    Id = "165432",
                    Name = "Mehdi",
                    Date = "June 3",
                    StartTime = "2:00 pm",
                    EndTime = "3:00 pm"
                };

                var data = Encoding.ASCII.GetBytes(shift.ToString());

                request.ContentType = "application/json";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                response = (HttpWebResponse)request.GetResponse();

                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;
                    responseString = "Some error occured: " + response.StatusCode.ToString();
                }
                else
                {
                    responseString = "Some error occured: " + e.Status.ToString();
                }
            }

            return responseString;
        }
    }
}
