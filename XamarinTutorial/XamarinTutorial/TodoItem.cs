namespace XamarinTutorial
{
    public class TodoItem
    {
        public string TodoText { get; set; }

        public bool IsComplete { get; set; }

        public TodoItem(string todoText, bool isComplete)
        {
            TodoText = todoText;
            IsComplete = isComplete;
        }
    }
}
