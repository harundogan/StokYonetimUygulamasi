using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Controls;
using System.Security;

namespace ZaferMarketlerZinciri
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database=ZaferDB;Integrated Security = False");
        PasswordStrengthChecker _passwordStrength = new PasswordStrengthChecker();

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Güvenliğiniz İçin Şifrenizde Büyük Harf,Küçük Harf,Rakam ve (@,!,&,$) Gibi Özel Karakterler Kullanmanız Daha İyi Olacaktır!", "Şifre Hakkında Bilgilendirme", MessageBoxButtons.OK);
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("select * from Users where Name='" + txtUserName.Text + "'", _connection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                SifreKontrol();
            }
            else
            {
                MessageBox.Show("Sistemde Böyle Bir Kullanıcı Tanımlı Değildir!");
            }
            _connection.Close();
        }

        void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        void UpdatePassword()
        {
            if (txtNewPassword.Text == txtNewPasswordRp.Text && txtNewPassword.Text != "" && txtNewPasswordRp.Text != "" && txtNewPassword.Text.Length >= 8)
            {
                string password = txtNewPassword.Text;
                var key = GenerateRandomNumber(24);
                var iv = GenerateRandomNumber(8);

                var encrypted = Encrypt(Encoding.UTF8.GetBytes(password),key,iv);

                string dir = txtUserName.Text;
                Directory.CreateDirectory("data\\" + dir);
                var sw = new StreamWriter("data\\" + dir + "\\data.cd");

                string encUsr = txtUserName.Text;
                string encPass = Convert.ToBase64String(encrypted);
                string usrPass = txtNewPassword.Text;
                string sifrelenecekKey = "";
                string orjSifre = "";
                foreach (var sKey in encPass)
                {
                    sifrelenecekKey += Convert.ToChar(sKey + 79);
                }

                foreach (var item in usrPass)
                {
                    orjSifre += Convert.ToChar(item + 93);
                }

                sw.WriteLine(encUsr);
                sw.WriteLine(sifrelenecekKey);
                sw.WriteLine(orjSifre);
                sw.Close();

                ConnectionControl();
                SqlCommand command = new SqlCommand("update Users set Password=@Password where Name=@Name", _connection);
                command.Parameters.AddWithValue("@Name", txtUserName.Text);
                command.Parameters.AddWithValue("@Password", Convert.ToBase64String(encrypted)); //Sql veritabanımıza şifrelenmiş verimizi kaydetmek için parametre olarak şifreli verimizi belirtiyoruz.
                command.ExecuteNonQuery();
                _connection.Close();
                MessageBox.Show("Şifreniz Başarılı Bir Şekilde Değiştirilmiştir!");
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
            else if (txtUserName.Text == string.Empty)
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz!");
        }

        void SifreKontrol()
        {
            if (txtNewPassword.Text.Length < 8 && txtNewPasswordRp.Text != string.Empty && txtNewPassword.Text != string.Empty)
                MessageBox.Show("Yeni Şifreniz En Az 8 Karakter Olmalıdır!");
            else if (txtNewPassword.Text != string.Empty && txtNewPasswordRp.Text != string.Empty && lblStrength.Text == "Çok Düşük" || lblStrength.Text == "Düşük")
            {
                MessageBox.Show("Güvenliğiniz Açısından Daha Güçlü Bir Şifre Girmelisiniz!");
                SifreKontrol();
            }
            else if (txtNewPassword.Text != txtNewPasswordRp.Text)
                MessageBox.Show("Girilen Şifreler Eşleşmemektedir!");
            else if (txtNewPassword.Text == string.Empty || txtNewPasswordRp.Text == string.Empty)
                MessageBox.Show("Şifre Alanları Boş Bırakılamaz!");
            else
                UpdatePassword();
        }

        private static byte[] GenerateRandomNumber(int length) 
        {
            /*Şifreleme provider'ı olarak TripleDES kullandım. GenerateRandomNumber metodu belirlediğimiz kriterlerde anahtar üretilmesini sağlıyor.
            RNGCryptoServiceProvider sınıfından randomNumberGenerator adlı bir nesne oluşturarak CryptoServiceProvider sınıfının özelliklerinden
            yararlandık.
             
             */
            using (RNGCryptoServiceProvider randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length]; //verdiğimiz length parametresi kadar yeni byte blokları oluşturduk. (Henüz byte bloklarına henüz değer atanmadı.)
                randomNumberGenerator.GetBytes(randomNumber); //Oluşturduğumuz byte'lara GetBytes metodu yardımıyla değer ataması yaptık.

                return randomNumber; //Artık randomNumber değişkeni yeni oluşturduğumuz x byte'ı taşıyan bir byte nesnesi haline geldi.
            }
        }

        private static byte[] Encrypt(byte[] dataToEncrypt, byte[] key, byte[] iv)
        {
            using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider())
            {
                tripleDES.Key = key;
                tripleDES.IV = iv;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDES.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(dataToEncrypt, 0, dataToEncrypt.Length);

                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        public void GetPasswordStrength(string password)
        {
            password = txtNewPassword.Text;
            int score = _passwordStrength.GeneratePasswordScore(password);

            if (score < 30)
            {
                lblStrength.Text = "Çok Düşük";
                lblStrength.ForeColor = Color.Red;
            }

            else if (score < 50)
            {
                lblStrength.Text = "Düşük";
                lblStrength.ForeColor = Color.OrangeRed;
            }

            else if (score < 70)
            {
                lblStrength.Text = "Normal";
                lblStrength.ForeColor = Color.Orange;
            }

            else if (score < 80)
            {
                lblStrength.Text = "Güçlü";
                lblStrength.ForeColor = Color.Yellow;
            }

            else if (score > 85)
            {
                lblStrength.Text = "Güvenli";
                lblStrength.ForeColor = Color.LightGreen;
            }
        }


        private void chxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            if (chxShowPassword.Checked == false)
            {
                txtNewPassword.PasswordChar = '*';
            }
        }

        private void chxShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            txtNewPasswordRp.PasswordChar = '\0';
            if (chxShowPassword2.Checked == false)
            {
                txtNewPasswordRp.PasswordChar = '*';
            }
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            GetPasswordStrength(txtNewPassword.Text);
        }



    }
}
