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

namespace StyleApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public class Names
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public int age { get; set; }
        public int peopleHeight { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Names> namesList = new List<Names>
            {
                new Names { name="Юрий", surname="Добронравов", patronymic="Святославович", age = 18, peopleHeight = 180 },
                 new Names { name="Александр", surname="Легкий", patronymic="Сергеевич", age = 18, peopleHeight = 186 },

            };
            mainGrid.ItemsSource = namesList;
        }
    }
}
