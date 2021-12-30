using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinTutorial
{
    public class TodoListViewModel
    {
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public string NewTodoInputValue { get; set; }

        public ICommand AddTodoCommand => new Command(AddTodoItem);

        public ICommand RemoveTodoCommand => new Command(RemoveTodoItem);

        public TodoListViewModel()
        {
            TodoItems = new ObservableCollection<TodoItem>();
            TodoItems.Add(new TodoItem("Todo 1", false));
            TodoItems.Add(new TodoItem("Todo 2", true));
            TodoItems.Add(new TodoItem("Todo 3", false));
        }

        private void AddTodoItem()
        {
            TodoItems.Add(new TodoItem(NewTodoInputValue, false));
            NewTodoInputValue = string.Empty;
        }

        public void RemoveTodoItem(object o)
        {
            TodoItem todoItem = o as TodoItem;
            if (todoItem != null)
            {
                TodoItems.Remove(todoItem);
            }
        }
    }
}
