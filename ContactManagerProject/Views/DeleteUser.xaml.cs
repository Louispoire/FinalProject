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
    /// Interaction logic for DeleteUser.xaml
    /// </summary>
    public partial class DeleteUser : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DeleteUser()
        {
            InitializeComponent();

            //These textboxes are not enabled because we don't users to edit 
            DeleteBtn.IsEnabled = false;
            displayId.IsEnabled = false;
            displayName.IsEnabled = false;
            displayPhone.IsEnabled = false;
            displayEmail.IsEnabled = false;
            displayAddress.IsEnabled = false;

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        //Delete contact from database
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //delete contact based on the searched ID. 
            string qry = "DELETE FROM contact where id='" + displayId.Text + "'";
            conn.Open();
            //Execute query
            cmd = new SqlCommand(qry, conn);
            //Display message depending on the results
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Row Deleted.", "Delete User", MessageBoxButton.OK, MessageBoxImage.Information);

                displayId.Text = displayEmail.Text = displayName.Text = displayAddress.Text = displayPhone.Text = string.Empty;
                
            }
            else
            {
                MessageBox.Show("Cannot Delete Row.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            //Search user based on an ID
            if (searchBox.Text.All(char.IsDigit))
            {
                string idSearch = searchBox.Text;
                if (idSearch != string.Empty)
                {
                    //execute the search based on the ID
                    conn.Open();
                    string qry = "SELECT * FROM contact WHERE id= @id";
                    cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@id", idSearch);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Here we enabled this form for editing
                        displayId.Text = searchBox.Text;
                        searchBox.Text = string.Empty;
                        DeleteBtn.IsEnabled = true;

                        //The next lines are displaying the informations on the form
                        displayName.Text = reader["name"].ToString();
                        displayPhone.Text = reader["phone"].ToString();
                        displayEmail.Text = reader["email"].ToString();
                        displayAddress.Text = reader["address"].ToString();

                    }
                    conn.Close();
                }
                else
                {
                    //Exception
                    MessageBox.Show("Please enter a number. Thank you", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    searchBox.Text = string.Empty;
                }
            }
            else
            {
                //Exception
                MessageBox.Show("Please enter a number. Thank you", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                searchBox.Text = string.Empty;
            }
        }
    }
}
