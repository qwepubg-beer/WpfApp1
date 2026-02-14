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

namespace Cimema.Pages
{
    /// <summary>
    /// Логика взаимодействия для FilmS.xaml
    /// </summary>
    public partial class FilmS : Page
    {
        public FilmS()
        {
            InitializeComponent();
            ReleaseDate.Text = Choose.ChoosingFilm.ReleaseDate.ToString();
            Name.Text= Choose.ChoosingFilm.Name;
            Genre.Text = "Жанр: " + Choose.ChoosingFilm.Genre;
            Name.Text = "Описание: "+Choose.ChoosingFilm.Description;
            Name.Text = Choose.ChoosingFilm.Age.ToString() + "+";
            
        }

        private void Session_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            { NavigationService.GoBack(); }
         }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            { NavigationService.GoBack(); }
        }
    }
}
