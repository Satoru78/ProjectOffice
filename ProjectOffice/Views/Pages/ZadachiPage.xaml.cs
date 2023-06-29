using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectOffice.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ZadachiPage.xaml
    /// </summary>
    public partial class ZadachiPage : Page
    {
        private HttpClient _client = new HttpClient();

        public ZadachiPage()
        {
            InitializeComponent();
            _client.BaseAddress = new Uri("https://localhost:44301/");
            GetTasks();

        }

        private void TaskDatasGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TaskDatasGrid.SetValue(Grid.ColumnSpanProperty, 2);
            tlbText.Visibility = Visibility.Visible;
        }
        void GetTasks()
        {
            var json = _client.GetStringAsync($"api/Tasks").Result;
            var tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            TaskDatasGrid.ItemsSource = tasks;
            string content = "";
            tasks.ForEach(x =>
            {
                content += x.ToString() + "\n";
            });
            File.WriteAllText("C:\\Users\\obaka\\Desktop\\Рабочий стол\\test1.csv", content, Encoding.UTF8);
        }
    }
}
