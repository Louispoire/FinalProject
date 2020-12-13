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
    /// Interaction logic for ExportUsers.xaml
    /// </summary>
    public partial class ExportUsers : UserControl
    {
        SqlConnection conn;
        SqlCommand cmd;
        public ExportUsers()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=contacts;Integrated Security=True");

        }
        private void ExportAll_Click(object sender, RoutedEventArgs e)
        {

            string name;
            string phone;
            string email;
            string address;
            string path = filePath.Text;
            if (path != string.Empty && path.Length > 4)
            {
                var result = path.Substring(path.Length - 4);
                if (result == ".csv")
                {

                    // The line below will create a file my_file.py in
                    // the Python_Files folder in D:\ drive
                    try
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        // Create the file, or overwrite if the file exists.
                        using (StreamWriter fs = new StreamWriter(@path, true))
                        {

                            conn.Open();
                            string qry = "SELECT name, phone, email, address FROM contact";
                            cmd = new SqlCommand(qry, conn);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                name = reader["name"].ToString();
                                phone = reader["phone"].ToString();
                                email = reader["email"].ToString();
                                address = reader["address"].ToString();
                                string info = name + ", " + phone + ", " + email + ", " + address;
                                fs.WriteLine(info);

                            }
                            MessageBox.Show("The file has been created: " + @path, "File Exported", MessageBoxButton.OK, MessageBoxImage.Information);
                        }

                        // Open the stream and read it back.
                        using (StreamReader sr = File.OpenText(@path))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(s);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    //string path = filePath.Text;
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


        }
    }
}