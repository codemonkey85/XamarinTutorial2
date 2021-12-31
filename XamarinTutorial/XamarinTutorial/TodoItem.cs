using System;

namespace XamarinTutorial
{
    public class TodoItem
    {
        public long TaskId { get; set; }

        public string TaskTitle { get; set; }

        public bool IsComplete { get; set; }

        public DateTime? DueDate { get; set; }

        public TodoItem(string todoText, bool isComplete)
        {
            TaskTitle = todoText;
            IsComplete = isComplete;
        }
    }
}
