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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public AddUser()
        {
            InitializeComponent();

            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
        }

        //Clear form
        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            nameBox.Text = emailBox.Text =
            addressBox.Text = mobileBox.Text = string.Empty;
        }


        //add contact to database
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //make sure that textbox are not empty
            if (nameBox.Text != string.Empty || emailBox.Text != string.Empty || 
                addressBox.Text != string.Empty || mobileBox.Text != string.Empty)
            {
                //add the contact to the database
                string qry = "INSERT INTO contact(name, phone, email, address) VALUES('" + nameBox.Text + "','" + mobileBox.Text + "', '" + emailBox.Text + "','" + addressBox.Text + "')";
                conn.Open();
                cmd = new SqlCommand(qry, conn);
                //this will display a message on whether or not the query has been successfully added
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Created.", "Add User", MessageBoxButton.OK, MessageBoxImage.Information);
                    nameBox.Text = emailBox.Text =
                        addressBox.Text = mobileBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Cannot Create Row.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Sorry, please insert something in all fields", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();
        }
    }
}
