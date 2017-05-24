using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using System.IO;
using System.Data.SqlServerCe;
using System.Security.Cryptography;


namespace PanKingdom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public SqlCeConnection _con;
        public SqlCeCommand _cmd;
        protected override void OnStartup(StartupEventArgs e)
        {
            string _connStr = "Data Source = PanKingdom.sdf; Password = Pankingdom@123";

            if (File.Exists("PanKingdom.sdf"))
            {
               // File.Delete("PanKingdom.sdf");
            }
            else
            {
                if (CreateDatabase(_connStr))
                {
                    if (CreateTables(_connStr))
                    {

                    }
                }
            }
        }

        public bool CreateDatabase(string connStr)
        {
            bool result = false;
            try
            {
                SqlCeEngine engine = new SqlCeEngine(connStr);
                engine.CreateDatabase();
                result = true;
            }
            catch (Exception)
            {

                result = false;
            }

            return result;
        }

        public bool CreateTables(string connStr)
        {
            bool result = false;
            try
            {
                _con = new SqlCeConnection(connStr);
                _con.Open();
                _cmd = new SqlCeCommand(@"create table MaterialList(ID INT PRIMARY KEY IDENTITY(1,1) ,MaterialCode nvarchar(100),UnityType nvarchar(100),Category nvarchar(100),Description nvarchar(100))", _con);
                _cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                _con.Close();

            }
            finally
            {
                result = false;
                _con.Close();

            }
            return result;
        }

        // public bool insertDefaulData()




        public class Simple3Des
        {
           
            
            MemoryStream ms = new MemoryStream();
            private TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();
            
            private byte[] TruncateHash(string key, int length)
            {

                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

                // Hash the key.
                byte[] keyBytes = System.Text.Encoding.Unicode.GetBytes(key);
                byte[] hash = sha1.ComputeHash(keyBytes);

                // Truncate or pad the hash.
                Array.Resize(ref hash, length);
                return hash;
            }

            public Simple3Des(string key)
            {
                // Initialize the crypto provider.
                TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8);
                TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
            }

            public string EncryptData(string plaintext)
            {

                // Convert the plaintext string to a byte array.
                byte[] plaintextBytes = System.Text.Encoding.Unicode.GetBytes(plaintext);

                // Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Create the encoder to write to the stream.
                CryptoStream encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);

                // Use the crypto stream to write the byte array to the stream.
                encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
                encStream.FlushFinalBlock();

                // Convert the encrypted stream to a printable string.
                return Convert.ToBase64String(ms.ToArray());
            }

            public string DecryptData(string encryptedtext)
            {

                // Convert the encrypted text string to a byte array.
                byte[] encryptedBytes = Convert.FromBase64String(encryptedtext);

                // Create the stream.
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Create the decoder to write to the stream.
                CryptoStream decStream = new CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write);

                // Use the crypto stream to write the byte array to the stream.
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                decStream.FlushFinalBlock();

                // Convert the plaintext stream to a string.
                return System.Text.Encoding.Unicode.GetString(ms.ToArray());
            }

        }
    }
}
