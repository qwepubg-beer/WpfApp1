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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для GetFilm.xaml
    /// </summary>
    public partial class GetFilm : Page
    {
        public GetFilm()
        {
            InitializeComponent();
            ReleaseDate.Text = MainClass.ChoosingFilm.ReleaseDate.ToString();
            Name.Text = MainClass.ChoosingFilm.Name;
            Genre.Text = "Жанр: " + MainClass.ChoosingFilm.Genre;
            Name.Text = "Описание: " + MainClass.ChoosingFilm.Description;
            Name.Text = MainClass.ChoosingFilm.Age.ToString() + "+";

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
