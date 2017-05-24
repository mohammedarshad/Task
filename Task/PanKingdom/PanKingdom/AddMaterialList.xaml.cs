using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
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
using System.Windows.Shapes;

namespace PanKingdom
{
    /// <summary>
    /// Interaction logic for AddMaterialList.xaml
    /// </summary>
    public partial class AddMaterialList : Window
    {
        public AddMaterialList()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            //Simple3Des crypt = new Simple3Des("cryptval");
            //string pwd = txtcode.Text;
            //string webuserpassword = crypt.EncryptData(txtcode.Text);
            //SqlCeConnection con = new SqlCeConnection("Data Source=PanKingdom.sdf;Password=Pankingdom@123");
            string Connection_String = ConfigurationManager.ConnectionStrings["Pankingdom"].ConnectionString;
            SqlCeConnection con = new SqlCeConnection(Connection_String);
            try
            {
                //Open Connection...
               
                con.Open();
                //Write Query For Insert Data Into Table using Creating Object Of SqlCommand...
                SqlCeCommand comm = new SqlCeCommand("INSERT INTO MaterialList VALUES(" + txtunity.Text + "," + txtcode.Text + "," + txtcat.Text + "," + txtdesc.Text + ")", con);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //If Any Exception Will Occur then It Will Display That Message...
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                
                con.Close();
               
              
            }

        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
