namespace HomeAccountant.Models
{
    public class StatusInfo
    {
        public string Username { get; init; }
        public string Host { get; init; }
        public int ProcessId { get; init; }
        public string ProcessName { get; init; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public DateTime DateOfCreation { get; set; }

        public StatusInfo(string username, string host, int processId, string processName)
        {
            Username = username;
            Host = host;
            ProcessId = processId;
            ProcessName = processName;
            DateOfCreation = DateTime.Now;
        }
    }
}
