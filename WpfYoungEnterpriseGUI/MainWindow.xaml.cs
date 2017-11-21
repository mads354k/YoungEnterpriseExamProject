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

        public MainWindow()
        {
            InitializeComponent();
            InitializeController();
        }

        private void InitializeController()
        {
            Facade.IDataFacade dataHandler = new Facade.DBFacade();

            this.controller = new Controller.Controller(dataHandler);
        }

        private void ManageTeam(object sender, RoutedEventArgs e)
        {
            TeamSettingsWindow window = new TeamSettingsWindow(controller);
            this.Close();
            window.Show();
        }

        private void MakeTeam(object sender, RoutedEventArgs e)
        {
            CreatingTeamWindow window = new CreatingTeamWindow(controller);
            this.Close();
            window.Show();
        }
    }
}
