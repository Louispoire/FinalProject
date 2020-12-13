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
        private void ImportAll_Click(object sender, RoutedEventArgs e)
        {
            string path = filePath.Text;
            if (path != string.Empty && path.Length > 4)
            {
                var result = path.Substring(path.Length - 4);
                if (result == ".csv")
                {
                    StreamReader reader = new StreamReader(File.OpenRead(@path));
                    string name;
                    string phone;
                    string email;
                    string address;

                    conn.Open();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (!String.IsNullOrWhiteSpace(line))
                        {
                            string[] values = line.Split(',');
                            if (values.Length >= 4)
                            {
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

