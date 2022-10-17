using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SofttechLoginUygulması
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            gridDoldur();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;


        public void gridDoldur()
        {
            con = new SqlConnection("server=. ;Initial Catalog= loginEkranı; Integrated Security=SSPI ");
            da = new SqlDataAdapter("Select * From Table_customer_information ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Table_customer_information");
            dataGridView1.DataSource = ds.Tables["Table_customer_information"];
            con.Close();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            this.table_customer_informationTableAdapter2.Fill(this.loginEkranıDataSet2.Table_customer_information);
        }

        private void button_girisYap_Click_1(object sender, EventArgs e)
        {
            label_username.Visible = true; textBox_username.Visible = true;
            label_password.Visible = true; textBox_password.Visible = true;
            label_islemSeçiniz.Visible = false;
            button_girisYap.Visible = false; button_kayitOl.Visible = false;
            button_geri.Visible = true;
            button_girisYap2.Visible = true;
        }

        private void button_kayitOl_Click_1(object sender, EventArgs e)
        {
            label_islemSeçiniz.Visible = false;
            button_girisYap.Visible = false;
            button_kayitOl.Visible = false;
            button_kayitOl2.Visible = true;
            button_geri.Visible = true;

            label_username.Visible = true; textBox_username.Visible = true;
            label_password.Visible = true; textBox_password.Visible = true;
            label_ad.Visible = true; textBox_ad.Visible = true;
            label_soyad.Visible = true; textBox_soyad.Visible = true;
            label_mail.Visible = true; textBox_mail.Visible = true;
            label_telefon.Visible = true; maskedTextBox_telefon.Visible = true;
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            label_islemSeçiniz.Visible = true;
            button_girisYap.Visible = true;
            button_kayitOl.Visible = true;
            button_geri.Visible = false;
            button_girisYap2.Visible = false;
            button_kayitOl2.Visible = false;

            label_username.Visible = false; textBox_username.Visible = false;
            label_password.Visible = false; textBox_password.Visible = false;
            label_ad.Visible = false; textBox_ad.Visible = false;
            label_soyad.Visible = false; textBox_soyad.Visible = false;
            label_mail.Visible = false; textBox_mail.Visible = false;
            label_telefon.Visible = false; maskedTextBox_telefon.Visible = false;
        }

        private void button_kayitOl2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = cmd.CommandText = $"insert into dbo.Table_customer_information(username,password,name,surname,mail,phone_number) values('{textBox_username.Text}', '{textBox_password.Text}', '{textBox_ad.Text}', '{textBox_soyad.Text}', '{textBox_mail.Text}', '{maskedTextBox_telefon.Text}')";
            cmd.ExecuteNonQuery();
            con.Close();
            gridDoldur();

            textBox_username.Clear();
            textBox_password.Clear();
            textBox_ad.Clear();
            textBox_soyad.Clear();
            textBox_mail.Clear();
            maskedTextBox_telefon.Clear();
        }

        private void button_girisYap2_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Table_customer_information where username=@username AND password=@password";
            con = new SqlConnection("server=.; Initial Catalog=loginEkranı;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@username", textBox_username.Text);
            cmd.Parameters.AddWithValue("@password", textBox_password.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();

            textBox_username.Clear();
            textBox_password.Clear();

        }
    }
}
