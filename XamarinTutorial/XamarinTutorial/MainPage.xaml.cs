using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTutorial
{
    public partial class MainPage : ContentPage
    {
        readonly BookManager manager = new BookManager();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await manager.GetAll();
            foreach (var todo in result) 
            {
                Console.WriteLine(todo.TaskTitle);
            }
        }
    }
}
