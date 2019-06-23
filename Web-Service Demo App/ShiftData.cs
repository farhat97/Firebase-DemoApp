namespace Web_Service_Demo_App
{
    public class ShiftData
    {
        //public string Id;
        //public string Date;
        //public string Name; //{ get; set; }
        //public string startTime;
        //public string endTime;

        private string date;
        private string id;
        private string name;
        private string endTime;
        private string startTime;

        public string Date { get => date; set => date = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string EndTime { get => endTime; set => endTime = value; }
        public string StartTime { get => startTime; set => startTime = value; }
    }
}