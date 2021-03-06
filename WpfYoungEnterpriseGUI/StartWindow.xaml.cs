﻿using System;
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
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            InitializeController();
        }

        private void InitializeController()
        {
            Controller.Controller controller = new Controller.Controller(new Facade.DBFacade());
            Facade.EF.Team team = null;

            MainWindow window = new MainWindow(controller,team);
            this.Close();
            window.Show();
        }
    }
}
