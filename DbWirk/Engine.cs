using System;
using System.Collections.Generic;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Policy;

namespace DbWirk
{
    public static class Engine
    {
        public static string logged { get; set; } = "";
        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\choco\source\repos\DbWirk\DbWirk\Worker.mdf;Integrated Security=True");
        //extern public static void Add();
        private static string Key = "asjfrtpfdscmbaxz";
        private static string IV = "asdarasd";
        #region Arrays
        public static List<string> arrayCity = new List<string>();
        public static List<string> arrayGarant = new List<string>();
        public static List<string> arrayPubnum = new List<string>();
        public static List<string> arrayFirm = new List<string>();
        public static List<string> arrayDefect = new List<string>();
        public static List<string> arrayModel = new List<string>();
        public static List<string> arrayTypemodel = new List<string>();
        #endregion

        static Engine()
        {

        }

        public static string Encrypt(string src)
        {
            byte[] plainTextBytes = System.Text.ASCIIEncoding.Unicode.GetBytes(src);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.Unicode.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.Unicode.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encrypted = crypto.TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
            crypto.Dispose();
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string src)
        {
            byte[] encryptedbytes = Convert.FromBase64String(src);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.Unicode.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.Unicode.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] secret = crypto.TransformFinalBlock(encryptedbytes, 0, encryptedbytes.Length);
            crypto.Dispose();
            return System.Text.ASCIIEncoding.Unicode.GetString(secret);
        }



        public static string Choice(string text1, string text2, string key)
        {
            if(text1 == null || text1 == "")
            {
                switch(key) {
                    case "city":
                        {
                            Query("insert into City (City) values (N'" + Encrypt(text2) + "')");
                            break;
                        }
                    case "pubnum":
                        {
                            Query("insert into PubNum (pubnum) values (N'" + Encrypt(text2) + "')");
                            break;
                        }
                    case "defect":
                        {
                                Query("insert into Defect (defect) values (N'" + Encrypt(text2) + "')");
                                break;
                        }
                    case "model":
                        {
                            Query("insert into Model (model) values (N'" + Encrypt(text2) + "')");
                            break;
                        }
                    case "typemodel":
                        {
                            Query("insert into Typemodel (typemodel) values (N'" + Encrypt(text2) + "')");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                return text2;
            }
            return text1;
        }

        public static void Query(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Query", e);
            }
            finally
            {
                connection.Close();
            }
        }

        public static string QueryString(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                object objString = cmd.ExecuteScalar();
                string text = Convert.ToString(objString);
                return text;
            }
            catch (Exception e)
            {
                throw new Exception("QueryString", e);
            }
            finally
            {
                connection.Close();
            }
            
        }

        public static object QueryObject(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch (Exception e)
            {
                throw new Exception("QueryString", e);
            }
            finally
            {
                connection.Close();
            }
        }

        public static int QueryInt(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                object objString = cmd.ExecuteScalar();
                int text = Convert.ToInt32(objString);
                return text;
            }
            catch (Exception e)
            {
                throw new Exception("QueryInt", e);
            }
            finally
            {
                connection.Close();
            }
            
        }

        public static bool QueryBool(string query)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                object objString = cmd.ExecuteScalar();
                bool text = Convert.ToBoolean(objString);
                return text;
            }
            catch (Exception e)
            {
                throw new Exception("QueryBool", e);
            }
            finally
            {
                connection.Close();
            }
            
        }

        public static List<string> QueryArrayWorker()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select name from Worker";
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> workerArray = new List<string>();
                while (reader.Read())
                {
                    workerArray.Add(reader.GetValue(0).ToString());
                }
                return workerArray;
            }
                
            catch (Exception e)
            {
                throw new Exception("QueryArrayWorker", e);
            }
            finally
            {
                connection.Close();
            }
            
        }

        public static void Register(string name, string login, string password, string repassword)
        {
            bool check = QueryBool("select 1 where EXISTS(select login from Worker where login = '" + login + "') union all select 0 where not exists(select login from Worker where login = '" + login + "')");
            if(!check)
            {
                if (password == repassword)
                {
                    Query("insert into Worker (name, login, password) values (N'" + name + "', N'" + login + "', N'" + password + "')");
                    MessageBox.Show("Регистрация прошла успешно!");
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Данный пользователь уже существует!");
            }
            
        }

        public static KeyValuePair<object, object> Cast<K, V>(this KeyValuePair<K, V> kvp)
        {
            return new KeyValuePair<object, object>(kvp.Key, kvp.Value);
        }

        public static KeyValuePair<T, V> CastFrom<T, V>(Object obj)
        {
            return (KeyValuePair<T, V>)obj;
        }

        public static KeyValuePair<object, object> CastFrom(Object obj)
        {
            var type = obj.GetType();
            if (type.IsGenericType)
            {
                if (type == typeof(KeyValuePair<,>))
                {
                    var key = type.GetProperty("Key");
                    var value = type.GetProperty("Value");
                    var keyObj = key.GetValue(obj, null);
                    var valueObj = value.GetValue(obj, null);
                    return new KeyValuePair<object, object>(keyObj, valueObj);
                }
            }
            throw new ArgumentException(" ### -> public static KeyValuePair<object , object > CastFrom(Object obj) : Error : obj argument must be KeyValuePair<,>");
        }

        public static void Add(Dictionary<string, string> dict)
        {
                Query("insert into Service ([city], [firm], [pubnum], [datecome], [card], [defect], [dateservice], [model], [garant], [sub], [typemodel]) values" +
                    " (N'" + dict["city"] + "', N'" + dict["firm"] + "', N'" + dict["pubnum"] + "', N'" + dict["datecome"] + "', N'" + dict["card"] + "', N'" + dict["defect"]
                    + "', N'" + dict["dateservice"] + "', N'" + dict["model"] + "', N'" + dict["garant"] + "', N'"+ dict["sub"] +"', N'"+ dict["typemodel"] +"')");
        }
    }
}
