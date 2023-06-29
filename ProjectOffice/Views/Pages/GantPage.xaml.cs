using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для GantPage.xaml
    /// </summary>
    public partial class GantPage : Page
    {
        public GantPage()
        {
            InitializeComponent();
            var tasks = new List<Task>()
            {
                new Task(){Name = "Задача 1", Start = new DateTime(2022, 1, 1), End=new DateTime(2022, 1, 1), StatusName = "Открытый"},
                new Task(){Name = "Задача 2", Start = new DateTime(2022, 1, 15), End=new DateTime(2022, 1, 5), StatusName = "Готовый"},
                new Task(){Name = "Задача 3", Start = new DateTime(2022, 2, 15), End=new DateTime(2022, 2, 10), StatusName = "Готовый"},

            };
            var first = tasks.First();
            var end = tasks.Last();

            var grid = new Grid();
            for (int i = 1; i <= 7; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(25) });
                for (int j = 1; j <= 4 * 10; j++)
                {
                    if (i == first.End.Day && j == first.End.Day % 7)
                    {
                        grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(25) });
                        var rectangle1 = new Grid();
                        rectangle1.Width = 50;
                        rectangle1.Height = 50;
                        rectangle1.Margin = new Thickness(0, 5, 5, 5);
                        rectangle1.Background = new SolidColorBrush(Colors.Green);
                        Grid.SetRow(rectangle1, i);
                        Grid.SetColumn(rectangle1, j);
                        grid.Children.Add(rectangle1);
                    }
                    else
                    {
                        grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(25) });
                        var rectangle = new Grid();
                        rectangle.Width = 50;
                        rectangle.Height = 50;
                        rectangle.Margin = new Thickness(0, 5, 5, 5);
                        rectangle.Background = new SolidColorBrush(Colors.Blue);
                        Grid.SetRow(rectangle, i);
                        Grid.SetColumn(rectangle, j);
                        grid.Children.Add(rectangle);
                    }
                }
            }
            GantGrid.Children.Add(grid);



        }
        public class Task
        {
            public string Name { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }
            public string StatusName { get; set; }
        }
    }
}
