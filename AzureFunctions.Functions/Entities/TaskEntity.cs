using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace AzureFunctions.Functions.Entities
{
    internal class TaskEntity : TableEntity
    {
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
