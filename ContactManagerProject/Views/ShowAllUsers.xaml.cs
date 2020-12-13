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
            //The code will begin with Delete all button disabled.
            InitializeComponent();
            DeleteAll.IsEnabled = false;
            ShowAll.IsEnabled = true;
            //User cannot edited the data grid 
            View.IsEnabled = false;

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        //Create class contact used by the data grid
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
            View.IsEnabled = true;

            //connecting to database
            string qry = "SELECT * FROM contact";
            conn.Open();

            //executing query
            cmd = new SqlCommand(qry, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //looping through all rows
            while (reader.Read())
            {
   
                id = reader["id"].ToString();
                name = reader["name"].ToString();
                phone = reader["phone"].ToString();
                email = reader["email"].ToString();
                address = reader["address"].ToString();

                //Each row in the table contact will be added in the data grid until there is not row left

                dataDisplay.Items.Add(new Contact { id = reader["id"].ToString(), name=reader["name"].ToString(), phone=reader["phone"].ToString(), email = reader["email"].ToString(), address = reader["address"].ToString()
            });

            }
            conn.Close();
        }

        //Delete all contacts 
        private void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete all users?", "Delete All Users", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
            

            //execute query to database
            string qry = "DELETE FROM contact;";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (result == MessageBoxResult.Yes)
            {
                //display message if everything works
                if (cmd.ExecuteNonQuery() == 1)
                {
                    
                    MessageBox.Show("Successfully Deleted All Users.", "Delete All Users", MessageBoxButton.OK, MessageBoxImage.Information);
                    DeleteAll.IsEnabled = false;
                    View.IsEnabled = false;
                    displayView.Text = viewBox.Text = string.Empty;
                    dataDisplay.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Action Not Available.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            conn.Close();
        }

        //seek info from table based on a id
        //user will enter an ID in textbox and the database will display the contact based on the ID
        private void View_Click(object sender, RoutedEventArgs e)
        {
            if (viewBox.Text.All(char.IsDigit))
            {
                //Search based on ID
                string idSearch = viewBox.Text;
                if (idSearch != string.Empty)
                {

                    //execute query
                    conn.Open();
                    string qry = "SELECT * FROM contact WHERE id= @id";
                    cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@id", idSearch);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    { 
                        //display contact that has the searched id
                        displayView.Text = ("Name: " + reader["name"].ToString() + "\nPhone: " + reader["phone"].ToString() + 
                            "\nEmail: " + reader["email"].ToString() + "\nAddress: " + reader["address"].ToString());
                    }
                    conn.Close();
                }
                else
                {
                    //exception
                    MessageBox.Show("Please enter a number. Thank you", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    viewBox.Text = string.Empty;
                }
            }
            else
            {
                //exception
                MessageBox.Show("Please enter a number. Thank you", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                viewBox.Text = string.Empty;
            }
        }
    }
}
