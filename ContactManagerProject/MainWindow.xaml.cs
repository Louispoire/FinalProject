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
using System.Data;
using System.Data.SqlClient;
using ContactManagerProject.ViewModels;

namespace ContactManagerProject
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /*
        public sealed class SingletonDB
        {
        private static readonly SingletonDB instance = new SingletonDB();
        private readonly SqlConnection conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");

      
        static SingletonDB()
        {
        }

        private SingletonDB()
        {
        }

        public static SingletonDB Instance
        {
            get
            {
                return instance;
            }
        }

        public SqlConnection GetDBConnection()
        {
            return conn;
        }
    }
    */
    public partial class MainWindow : Window
    {
        SqlConnection conn;
        SqlCommand cmd;
        public MainWindow()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ShowAllUsersModel();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AddUserModel();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new DeleteUserModel();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new UpdateUserModel();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to to exit he application?", "Quit Contact Manager", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                FrmWindow.Close();
            }
        }
    }

}

