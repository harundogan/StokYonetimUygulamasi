using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ZaferMarketlerZinciri
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=ZaferDB;Integrated Security = False");
            // conn nesnesi ile veritabanımız olan ZaferDB'ye bağlantı kurduk.
            conn.Open();

            string dir = txtUserName.Text;
            var sr = new StreamReader("data\\" + dir + "\\data.cd");
            string encUsr = sr.ReadLine();
            string encPass = sr.ReadLine();
            string usrPass = sr.ReadLine();
            string decPass = "";
            string decSfr = "";

            foreach (var item in encPass)
            {
                decPass += Convert.ToChar(item - 79);
            }

            foreach (var dcSfr in usrPass)
            {
                decSfr += Convert.ToChar(dcSfr - 93);
            }

            sr.Close();
            SqlCommand sqlCommand = new SqlCommand("select * from Users where Name='" + txtUserName.Text + "' and Password='" + decPass + "'",conn);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                if (decPass == Convert.ToString(dr["Password"]) && decSfr == txtPassword.Text && encUsr == txtUserName.Text)
                {
                    Main main = new Main();
                    MessageBox.Show("Giriş başarılı. Yönlendiriliyorsunuz!");
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış. Tekrar deneyin!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
        }

        #region Şifre sıfırlama ekranının açılması
        private void lnkForgotPass_Click(object sender, EventArgs e)
        {
            ChangePassword chgPass = new ChangePassword();
            chgPass.Show();
            this.Hide();
        }
        #endregion
    }
}
