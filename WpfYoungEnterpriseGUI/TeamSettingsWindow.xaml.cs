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

        public TeamSettingsWindow(Controller.Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
    }
}
