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
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.SqlServerCe;

namespace PanKingdom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object Materialist { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            //FillDataGrid();
        }

        private void FillDataGrid()
        {
            //string ConString =ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string ConString = "Data Source=PanKingdom.sdf;Password=Pankingdom@123";
            string CmdString = string.Empty;
            using (SqlCeConnection con = new SqlCeConnection(ConString))
            {
                CmdString = "select * from MaterialList";
                SqlCeCommand cmd = new SqlCeCommand(CmdString, con);
                SqlCeDataAdapter sda = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable("MaterialList");
                sda.Fill(dt);
                materiallist.ItemsSource = dt.DefaultView;
            }
        }

        public void btnadd_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialList aml = new AddMaterialList();
            aml.Show();
        }

        public void btnedit_Click(object sender, RoutedEventArgs e)
        {

        }

        public void btndel_Click(object sender, RoutedEventArgs e)
        {

        }

        public void btnclose_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
