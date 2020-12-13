using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ContactManagerProject.Views
{
    /// <summary>
    /// Interaction logic for ShowAllUsers.xaml
    /// </summary>
    public partial class ShowAllUsers : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ShowAllUsers()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        private void EditAll_Click(object sender, RoutedEventArgs e)
        {
            //-\(O_O)/-
        }

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            //Truncate table

            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete all users?", "Delete All Users", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            string qry = "TRUNCATE TABLE contact";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (result == MessageBoxResult.Yes)
            {
                if (cmd.ExecuteNonQuery() == 1) //Doesn't equal one anymore don;t know why.
                {
                    MessageBox.Show("Successfully Deleted All Users.", "Delete All Users", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Action Not Available.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
