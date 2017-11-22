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
    /// Interaction logic for CreatingTeamWindow.xaml
    /// </summary>
    public partial class CreatingTeamWindow : Window
    {
        Controller.Controller controller;
        Facade.EF.Team team;

        public CreatingTeamWindow(Controller.Controller controller, Facade.EF.Team team)
        {
            InitializeComponent();
            this.controller = controller;
            this.team = team;
        }

        private void CreateTeam(object sender, RoutedEventArgs e)
        {
            string teamName = tbTeamName.Text;
            string track = cbTrack.SelectionBoxItem.ToString();
            string school = null;

            if (team == null)
            {
                team = controller.CreateTeam(teamName, track, school, false);

                if (team == null)
                {
                    MessageBox.Show("Team name taken!");
                }
                else
                {
                    MessageBox.Show("Team created!");
                }
            }
            else
            {
                MessageBox.Show("Already created a team!");
            }


            // todo add persons to the team...
        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(controller,team);
            this.Close();
            window.Show();
        }
    }
}
