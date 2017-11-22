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

namespace WpfYoungEnterpriseGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controller.Controller controller;
        Facade.EF.Team team = null;

        public MainWindow(Controller.Controller controller, Facade.EF.Team team)
        {
            InitializeComponent();
            this.controller = controller;
            this.team = team;
        }

        private void ManageTeam(object sender, RoutedEventArgs e)
        {
            TeamSettingsWindow window = new TeamSettingsWindow(controller,team);
            this.Close();
            window.Show();
        }

        private void MakeTeam(object sender, RoutedEventArgs e)
        {
            CreatingTeamWindow window = new CreatingTeamWindow(controller,team);
            this.Close();
            window.Show();
        }
    }
}
