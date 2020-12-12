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
            nameBox.Text = searchBox.Text =
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
            string qry = "INSERT INTO contact(name, phone, email, address) VALUES('" + nameBox.Text + "','" + mobileBox.Text + "', '" + emailBox.Text + "','" + addressBox.Text + "')";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Created.");
                nameBox.Text = searchBox.Text =
                emailBox.Text = addressBox.Text = mobileBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Cannot Create Row.");
            }
            conn.Close();
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            string idSearch = searchBox.Text;
            conn.Open();
            string qry = "UPDATE contact SET name='" + displayName.Text + "',phone='" +
            displayPhone.Text + "',email='" + displayEmail.Text + "',address='" + displayAddress.Text + "' WHERE id = @id";
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@id", idSearch);
            
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully Edited");
                displayId.Text = displayEmail.Text = displayName.Text = displayAddress.Text = displayPhone.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Cannot Edit. Please Stanby!");
            }
            conn.Close();
        }
        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //Insert delete here
            string qry = "";
            conn.Open();
            cmd = new SqlCommand(qry, conn);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Row Deleted.");
            }
            else
            {
                MessageBox.Show("Cannot Delete Row.");
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
                            EditBtn.IsEnabled = true;
                            DeleteBtn.IsEnabled = true;
                            displayName.IsEnabled = true;
                            displayPhone.IsEnabled = true;
                            displayEmail.IsEnabled = true;
                            displayAddress.IsEnabled = true;
                            displayId.Text = searchBox.Text;

                            //The next lines are displaying the informations on the form
                            displayName.Text = reader["name"].ToString();
                            displayPhone.Text = reader["phone"].ToString();
                            displayEmail.Text = reader["email"].ToString();
                            displayAddress.Text = reader["address"].ToString();


                            MessageBox.Show("Name: " +reader["name"].ToString()+ "\n Phone: " +reader["phone"].ToString()+ "\n Email: " +reader["email"].ToString()+ "\n Address: " +reader["address"].ToString());
                 
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a number. Thank you");
                    searchBox.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please enter a number. Thank you");
                searchBox.Text = string.Empty;
            }
        }



    }



}

