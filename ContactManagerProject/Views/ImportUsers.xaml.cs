using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
    /// Interaction logic for ImportUsers.xaml
    /// </summary>
    public partial class ImportUsers : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ImportUsers()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");

        }

        //Import data from .csv file
        private void ImportAll_Click(object sender, RoutedEventArgs e)
        {
            //create a string containing the path the user entered
            string path = filePath.Text;
            //check if the path is not empty or have a length higher than 4
            if (path != string.Empty && path.Length > 4)
            {
                //Check if the file end with .csv
                var result = path.Substring(path.Length - 4);
                if (result == ".csv")
                {
                    //StreamReader will open the file
                    StreamReader reader = new StreamReader(File.OpenRead(@path));
                    string name;
                    string phone;
                    string email;
                    string address;

                    conn.Open();
                    //loop through the file
                    while (!reader.EndOfStream)
                    {
                        //for each row in the file, set the value name, phone, email, address
                        string line = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(',');
                            if (values.Length >= 4)
                            {
                                //for each row in the file, set the value name, phone, email, address using .Split(',') to separate them 
                                name = values[0];
                                phone = values[1];
                                email = values[2];
                                address = values[3];
                                string qry = "INSERT INTO contact(name, phone, email, address) VALUES(@name, @phone, @email, @address)";
                                cmd = new SqlCommand(qry, conn);
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@phone", phone);
                                cmd.Parameters.AddWithValue("@email", email);
                                cmd.Parameters.AddWithValue("@address", address);
                                //insert the row inside table and go back at the top of the loop until file has no more data
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("User added: " + name, "ADDED!", MessageBoxButton.OK, MessageBoxImage.Information);


                                }
                                else
                                {
                                    MessageBox.Show("Cannot add...", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please end the file with .csv. Thank you.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a file path", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            conn.Close();


        }
    }
}

