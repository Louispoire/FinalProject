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
            DeleteAll.IsEnabled = false;
            ShowAll.IsEnabled = true;

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        public class Contact
        {
            public string id { get; set; }
            public string name { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string address { get; set; }

            

        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            string id;
            string name;
            string phone;
            string email;
            string address;
            DeleteAll.IsEnabled = true;
            ShowAll.IsEnabled = false;
            //-\(O_O)/-
            string qry = "SELECT * FROM contact";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
   
                id = reader["id"].ToString();
                name = reader["name"].ToString();
                phone = reader["phone"].ToString();
                email = reader["email"].ToString();
                address = reader["address"].ToString();


                dataDisplay.Items.Add(new Contact { id = reader["id"].ToString(), name=reader["name"].ToString(), phone=reader["phone"].ToString(), email = reader["email"].ToString(), address = reader["address"].ToString()
            });

            }
            conn.Close();
        }

        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            //Truncate table

            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete all users?", "Delete All Users", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            string qry = "DELETE FROM contact;";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (result == MessageBoxResult.Yes)
            {
                if (cmd.ExecuteNonQuery() == 1) //Doesn't equal one anymore don;t know why.
                {
                    MessageBox.Show("Action Not Available.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Successfully Deleted All Users.", "Delete All Users", MessageBoxButton.OK, MessageBoxImage.Information);
                    
                }
            }
            conn.Close();
        }
    }
}
