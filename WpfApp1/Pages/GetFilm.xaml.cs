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
            DataContext = MainClass.ChoosingFilm;
            InitializeComponent();
            List <FilmActor> actors = Core.Context.FilmActor.Where(a=>a.FilmID==MainClass.ChoosingFilm.ID).ToList();
            List <Actor> actors1 = new List<Actor>();
            foreach(FilmActor actor in actors)
            {
                Actor editUser = Core.Context.Actor.First(u => u.ID==actor.ActorID);
                actors1.Add(editUser);  
            }
            ActorsList.ItemsSource = actors1;   
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            if (MainClass.user != null)
            {
                mainWindow.MainFrame.Navigate(new BuyTicket());
            }
            else
            {
                var result = MessageBox.Show("Вы хотите войти в аккаунт?", "Ошибка авторизации", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes) { mainWindow.MainFrame.Navigate(new Enter()); }


            }
        }
    }
}
