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

        //Export database to .csv file
        private void ExportAll_Click(object sender, RoutedEventArgs e)
        {

            string name;
            string phone;
            string email;
            string address;

            //file path use to create a file
            string path = filePath.Text;
            //check if the path is not empty or have a length higher than 4
            if (path != string.Empty && path.Length > 4)
            {
                //Check if the file end with .csv
                var result = path.Substring(path.Length - 4);
                if (result == ".csv")
                {
                    try
                    {
                        //check if the file already exist. If so, it will delete the current file.
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        
                        //StreamWriter
                        using (StreamWriter fs = new StreamWriter(@path, true))
                        {

                            //connect to database
                            conn.Open();
                            string qry = "SELECT name, phone, email, address FROM contact";
                            cmd = new SqlCommand(qry, conn);
                            SqlDataReader reader = cmd.ExecuteReader();
                            //loop through database until no more row
                            while (reader.Read())
                            {
                                //add each row from the database to the file
                                name = reader["name"].ToString();
                                phone = reader["phone"].ToString();
                                email = reader["email"].ToString();
                                address = reader["address"].ToString();
                                string info = name + ", " + phone + ", " + email + ", " + address;
                                fs.WriteLine(info);

                            }
                            //message displaying file has been created
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