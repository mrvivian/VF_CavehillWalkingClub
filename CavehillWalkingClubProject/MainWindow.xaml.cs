using System.Collections.Generic;
using System.Windows;

namespace VF_CavehillWalkingClub
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            VF_CavehillWalkingClub();
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
