namespace AzureFunctions.Common.Models
{
    internal class Task
    {
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
