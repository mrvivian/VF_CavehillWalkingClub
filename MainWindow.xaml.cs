using System.Collections.Generic;
using System.Windows;

namespace VF_CavehillWalkingClub
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DataAccess dataAccess = new DataAccess();
            List<Employee> employees = dataAccess.GetEmployees();
            dataGrid.ItemsSource = employees;
        }
    }
}
