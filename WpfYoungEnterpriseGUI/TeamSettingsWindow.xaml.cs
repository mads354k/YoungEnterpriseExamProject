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
using System.Windows.Shapes;

namespace WpfYoungEnterpriseGUI
{
    /// <summary>
    /// Interaction logic for TeamSettingsWindow.xaml
    /// </summary>
    public partial class TeamSettingsWindow : Window
    {
        Controller.Controller controller;
        Facade.EF.Team team;

        public TeamSettingsWindow(Controller.Controller controller, Facade.EF.Team team)
        {
            InitializeComponent();
            this.controller = controller;
            this.team = team;
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(controller,team);
            this.Close();
            window.Show();
        }

        private void ChangeTeamName(object sender, RoutedEventArgs e)
        {
             string newName = tbNewTeamName.Text;
             controller.UpdateTeam(team.TeamName, newName, null, null, false);
            
        }

        private void ChangeTrack(object sender, RoutedEventArgs e)
        {
            string newTrack = cbTrack.SelectionBoxItem.ToString();
            controller.UpdateTeam(team.TeamName, team.TeamName, newTrack, null, false);
        }

        private void ChangeTeamMembers(object sender, RoutedEventArgs e)
        {
            
        }

        private void ApplyForEvent(object sender, RoutedEventArgs e)
        {
            
        }

        private void UploadReport(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
