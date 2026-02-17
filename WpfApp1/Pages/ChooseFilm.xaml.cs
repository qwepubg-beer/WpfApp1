using WpfApp1.Pages;
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
using static WpfApp1.MainClass;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChooseFilm.xaml
    /// </summary>
    public partial class ChooseFilm : Page
    {
        public ChooseFilm()
        {
            InitializeComponent();
            List<Film> films = Core.Context.Film.ToList();
            FilmList.ItemsSource = films;
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new GetFilm());
        }


        private void FilmList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Film choosing = FilmList.SelectedItem as Film;
            if (choosing != null) { MainClass.ChoosingFilm = choosing; }
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            double i = Math.Round(Rating.Value, 1);
            string Search = TextSearch.Text;
            int length = Search.Length;
            List<Film> films = Core.Context.Film.Where(t => t.Name.StartsWith(Search) && i <= t.Rating).ToList();
            FilmList.ItemsSource = films;
        }

        private void Rating_ValueChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<double> e)
        {
            R.Text = $"Рейтинг > {Math.Round(Rating.Value, 1)}";
        }
    }
}
