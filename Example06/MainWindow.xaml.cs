using Example06.Models;
using Example06.Storage;
using Example06.ViewModels;
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

namespace Example06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FoodStorage foodStorage;
        private readonly MainViewModel mainViewModel;
        public MainWindow()
        {
            foodStorage = new FoodStorage();
            mainViewModel = new MainViewModel { Food = new Food(), Foods = foodStorage.Foods };
            InitializeComponent();
            DataContext = mainViewModel;

        }

        private void OnAddFood(object sender, RoutedEventArgs e)
        {
            foodStorage.AddFood(mainViewModel.Food);
            mainViewModel.Food = new Food();
        }
    }
}
