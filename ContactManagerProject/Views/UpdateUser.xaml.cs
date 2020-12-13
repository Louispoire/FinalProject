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
    /// Interaction logic for UpdateUser.xaml
    /// </summary>
    public partial class UpdateUser : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public UpdateUser()
        {
            InitializeComponent();

            UpdateBtn.IsEnabled = false;
            displayId.IsEnabled = false;
            displayName.IsEnabled = false;
            displayPhone.IsEnabled = false;
            displayEmail.IsEnabled = false;
            displayAddress.IsEnabled = false;

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            string idSearch = searchBox.Text;
            conn.Open();
            string qry = "UPDATE contact SET name='" + displayName.Text + "',phone='" +
            displayPhone.Text + "',email='" + displayEmail.Text + "',address='" + displayAddress.Text + "' WHERE id = @id";
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@id", idSearch);

            if (cmd.ExecuteNonQuery() == 1) //Doesn't equal one anymore don;t know why.
            {
                MessageBox.Show("Successfully Updated", "Update User", MessageBoxButton.OK, MessageBoxImage.Information);
                displayId.Text = displayEmail.Text = displayName.Text = displayAddress.Text = displayPhone.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Cannot Edit. Please Stanby!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text.All(char.IsDigit))
            {
                string idSearch = searchBox.Text;
                if (idSearch != string.Empty)
                {
                    conn.Open();
                    string qry = "SELECT * FROM contact WHERE id= @id";
                    cmd = new SqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@id", idSearch);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Here we enabled this form for editing
                        UpdateBtn.IsEnabled = true;
                        displayName.IsEnabled = true;
                        displayPhone.IsEnabled = true;
                        displayEmail.IsEnabled = true;
                        displayAddress.IsEnabled = true;
                        displayId.Text = searchBox.Text;
                        searchBox.Text = string.Empty;

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
                    MessageBox.Show("Please enter a number. Thank you", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    searchBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please enter a number. Thank you", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                searchBox.Text = string.Empty;
            }
        }
    }
}
