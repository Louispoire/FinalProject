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

namespace ContactManagerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        SqlConnection conn;
        SqlCommand cmd;
        public MainWindow()
        {
            InitializeComponent();
            EditBtn.IsEnabled = false;
            DeleteBtn.IsEnabled = false;
            displayId.IsEnabled = false;
            displayName.IsEnabled = false;
            displayPhone.IsEnabled = false;
            displayEmail.IsEnabled = false;
            displayAddress.IsEnabled = false;




            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");
           
           
        }
        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            nameBox.Text = idBox.Text = searchBox.Text =
            emailBox.Text = addressBox.Text = mobileBox.Text = string.Empty;

            displayId.Text = displayEmail.Text = displayName.Text = displayAddress.Text = displayPhone.Text = string.Empty;
            EditBtn.IsEnabled = false;
            DeleteBtn.IsEnabled = false;
            displayId.IsEnabled = false;
            displayName.IsEnabled = false;
            displayPhone.IsEnabled = false;
            displayEmail.IsEnabled = false;
            displayAddress.IsEnabled = false;
            SaveBtn.IsEnabled = true;
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string qry = "INSERT INTO contact(id, name, phone, email, address) VALUES('" +idBox.Text + "', '" 
            + nameBox.Text + "','" + mobileBox.Text + "', '" + emailBox.Text + "','" + addressBox.Text + "')";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Save", "Successful");
            }
            else
            {
                MessageBox.Show("Sorry Invalid Entry", "Error In Saving", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            string idSearch = searchBox.Text;
            string qry = "UPDATE contact SET name='" + displayName.Text + "',phone='" +
            displayPhone.Text + "',email='" + displayEmail.Text + "',address='" + displayAddress.Text + "' WHERE id ='" + idSearch + "'";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Edited");
            }
            else
            {
                MessageBox.Show("Sorry Invalid Entry", "Error In Saving", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();
        }
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

            string qry = "UPDATE contact SET id='" + idBox.Text + "',name='" + nameBox.Text + "',phone='" +
            mobileBox.Text + "',email='" + emailBox.Text + "',address='" + addressBox.Text + "'";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Save");
            }
            else
            {
                MessageBox.Show("Sorry Invalid Entry", "Error In Saving", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text.All(char.IsDigit))
            {
                string idSearch = searchBox.Text;
                string qry = "SELECT * FROM contact WHERE id=" + idSearch;
                conn.Open();
                cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                        EditBtn.IsEnabled = true;
                        DeleteBtn.IsEnabled = true;
                        displayName.IsEnabled = true;
                        displayPhone.IsEnabled = true;
                        displayEmail.IsEnabled = true;
                        displayAddress.IsEnabled = true;
                        displayId.Text = searchBox.Text;
                        displayName.Text = reader["name"].ToString();
                        displayPhone.Text = reader["phone"].ToString();
                        displayEmail.Text = reader["email"].ToString();
                        displayAddress.Text = reader["address"].ToString();
                 
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please enter a number. Thank you");
                searchBox.Text = string.Empty;
            }
        }



    }



}

