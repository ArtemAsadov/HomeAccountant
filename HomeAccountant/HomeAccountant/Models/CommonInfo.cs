namespace HomeAccountant.Models
{
    public class CommonInfo
    {
        public string MachineName { get; init; }
        public string ServiceName { get; init; }
        public DateTime TimeStart { get; init; }
        public string Version { get; init; }

        public CommonInfo(string machineName, string serviceName, DateTime timeStart, string version)
        {
            MachineName = machineName;
            ServiceName = serviceName;
            TimeStart = timeStart;
            Version = version;
        }
    }
}
