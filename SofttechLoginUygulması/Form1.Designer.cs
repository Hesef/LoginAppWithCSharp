namespace SofttechLoginUygulması
{
    partial class Form_login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablecustomerinformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginEkranıDataSet = new SofttechLoginUygulması.loginEkranıDataSet();
            this.table_customer_informationTableAdapter = new SofttechLoginUygulması.loginEkranıDataSetTableAdapters.Table_customer_informationTableAdapter();
            this.tablecustomerinformationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginEkranıDataSet1 = new SofttechLoginUygulması.loginEkranıDataSet1();
            this.table_customer_informationTableAdapter1 = new SofttechLoginUygulması.loginEkranıDataSet1TableAdapters.Table_customer_informationTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablecustomerinformationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.loginEkranıDataSet2 = new SofttechLoginUygulması.loginEkranıDataSet2();
            this.table_customer_informationTableAdapter2 = new SofttechLoginUygulması.loginEkranıDataSet2TableAdapters.Table_customer_informationTableAdapter();
            this.button_kayitOl2 = new System.Windows.Forms.Button();
            this.maskedTextBox_telefon = new System.Windows.Forms.MaskedTextBox();
            this.button_girisYap2 = new System.Windows.Forms.Button();
            this.dateTimePicker_dogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label_dogumTarihi = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label_telefon = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_geri = new System.Windows.Forms.Button();
            this.label_islemSeçiniz = new System.Windows.Forms.Label();
            this.button_kayitOl = new System.Windows.Forms.Button();
            this.button_girisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablecustomerinformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEkranıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecustomerinformationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEkranıDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecustomerinformationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEkranıDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tablecustomerinformationBindingSource
            // 
            this.tablecustomerinformationBindingSource.DataMember = "Table_customer_information";
            this.tablecustomerinformationBindingSource.DataSource = this.loginEkranıDataSet;
            // 
            // loginEkranıDataSet
            // 
            this.loginEkranıDataSet.DataSetName = "loginEkranıDataSet";
            this.loginEkranıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_customer_informationTableAdapter
            // 
            this.table_customer_informationTableAdapter.ClearBeforeFill = true;
            // 
            // tablecustomerinformationBindingSource1
            // 
            this.tablecustomerinformationBindingSource1.DataMember = "Table_customer_information";
            this.tablecustomerinformationBindingSource1.DataSource = this.loginEkranıDataSet1;
            // 
            // loginEkranıDataSet1
            // 
            this.loginEkranıDataSet1.DataSetName = "loginEkranıDataSet1";
            this.loginEkranıDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_customer_informationTableAdapter1
            // 
            this.table_customer_informationTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablecustomerinformationBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 376);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 173);
            this.dataGridView1.TabIndex = 37;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // tablecustomerinformationBindingSource2
            // 
            this.tablecustomerinformationBindingSource2.DataMember = "Table_customer_information";
            this.tablecustomerinformationBindingSource2.DataSource = this.loginEkranıDataSet2;
            // 
            // loginEkranıDataSet2
            // 
            this.loginEkranıDataSet2.DataSetName = "loginEkranıDataSet2";
            this.loginEkranıDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_customer_informationTableAdapter2
            // 
            this.table_customer_informationTableAdapter2.ClearBeforeFill = true;
            // 
            // button_kayitOl2
            // 
            this.button_kayitOl2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_kayitOl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayitOl2.Location = new System.Drawing.Point(255, 305);
            this.button_kayitOl2.Name = "button_kayitOl2";
            this.button_kayitOl2.Size = new System.Drawing.Size(78, 28);
            this.button_kayitOl2.TabIndex = 57;
            this.button_kayitOl2.Text = "Kayıt Ol";
            this.button_kayitOl2.UseVisualStyleBackColor = false;
            this.button_kayitOl2.Visible = false;
            this.button_kayitOl2.Click += new System.EventHandler(this.button_kayitOl2_Click_1);
            // 
            // maskedTextBox_telefon
            // 
            this.maskedTextBox_telefon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maskedTextBox_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox_telefon.Location = new System.Drawing.Point(189, 241);
            this.maskedTextBox_telefon.Mask = "(999) 000-0000";
            this.maskedTextBox_telefon.Name = "maskedTextBox_telefon";
            this.maskedTextBox_telefon.Size = new System.Drawing.Size(144, 26);
            this.maskedTextBox_telefon.TabIndex = 56;
            this.maskedTextBox_telefon.Visible = false;
            // 
            // button_girisYap2
            // 
            this.button_girisYap2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_girisYap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_girisYap2.Location = new System.Drawing.Point(247, 144);
            this.button_girisYap2.Name = "button_girisYap2";
            this.button_girisYap2.Size = new System.Drawing.Size(86, 28);
            this.button_girisYap2.TabIndex = 55;
            this.button_girisYap2.Text = "Giriş Yap";
            this.button_girisYap2.UseVisualStyleBackColor = false;
            this.button_girisYap2.Visible = false;
            this.button_girisYap2.Click += new System.EventHandler(this.button_girisYap2_Click);
            // 
            // dateTimePicker_dogumTarihi
            // 
            this.dateTimePicker_dogumTarihi.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker_dogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_dogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dogumTarihi.Location = new System.Drawing.Point(189, 275);
            this.dateTimePicker_dogumTarihi.Name = "dateTimePicker_dogumTarihi";
            this.dateTimePicker_dogumTarihi.Size = new System.Drawing.Size(144, 24);
            this.dateTimePicker_dogumTarihi.TabIndex = 54;
            this.dateTimePicker_dogumTarihi.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_dogumTarihi.Visible = false;
            // 
            // label_dogumTarihi
            // 
            this.label_dogumTarihi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_dogumTarihi.AutoSize = true;
            this.label_dogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_dogumTarihi.Location = new System.Drawing.Point(58, 279);
            this.label_dogumTarihi.Name = "label_dogumTarihi";
            this.label_dogumTarihi.Size = new System.Drawing.Size(125, 20);
            this.label_dogumTarihi.TabIndex = 53;
            this.label_dogumTarihi.Text = "Doğum Tarihi: ";
            this.label_dogumTarihi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_dogumTarihi.Visible = false;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_mail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_mail.Location = new System.Drawing.Point(189, 210);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(144, 26);
            this.textBox_mail.TabIndex = 50;
            this.textBox_mail.Visible = false;
            // 
            // label_telefon
            // 
            this.label_telefon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_telefon.AutoSize = true;
            this.label_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_telefon.Location = new System.Drawing.Point(104, 244);
            this.label_telefon.Name = "label_telefon";
            this.label_telefon.Size = new System.Drawing.Size(79, 20);
            this.label_telefon.TabIndex = 51;
            this.label_telefon.Text = "Telefon: ";
            this.label_telefon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_telefon.Visible = false;
            // 
            // label_mail
            // 
            this.label_mail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_mail.Location = new System.Drawing.Point(101, 213);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(82, 20);
            this.label_mail.TabIndex = 52;
            this.label_mail.Text = "E-posta: ";
            this.label_mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_mail.Visible = false;
            // 
            // textBox_ad
            // 
            this.textBox_ad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_ad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ad.Location = new System.Drawing.Point(189, 146);
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(144, 26);
            this.textBox_ad.TabIndex = 46;
            this.textBox_ad.Visible = false;
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_soyad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_soyad.Location = new System.Drawing.Point(189, 177);
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(144, 26);
            this.textBox_soyad.TabIndex = 47;
            this.textBox_soyad.Visible = false;
            // 
            // label_soyad
            // 
            this.label_soyad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_soyad.AutoSize = true;
            this.label_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_soyad.Location = new System.Drawing.Point(114, 180);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(69, 20);
            this.label_soyad.TabIndex = 48;
            this.label_soyad.Text = "Soyad: ";
            this.label_soyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_soyad.Visible = false;
            // 
            // label_ad
            // 
            this.label_ad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_ad.AutoSize = true;
            this.label_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ad.Location = new System.Drawing.Point(142, 149);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(41, 20);
            this.label_ad.TabIndex = 49;
            this.label_ad.Text = "Ad: ";
            this.label_ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_ad.Visible = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_username.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_username.Location = new System.Drawing.Point(189, 83);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(144, 26);
            this.textBox_username.TabIndex = 42;
            this.textBox_username.Visible = false;
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_password.Location = new System.Drawing.Point(189, 114);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(144, 26);
            this.textBox_password.TabIndex = 44;
            this.textBox_password.Visible = false;
            // 
            // label_password
            // 
            this.label_password.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_password.Location = new System.Drawing.Point(126, 117);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(57, 20);
            this.label_password.TabIndex = 43;
            this.label_password.Text = "Şifre: ";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_password.Visible = false;
            // 
            // label_username
            // 
            this.label_username.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_username.Location = new System.Drawing.Point(67, 86);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(116, 20);
            this.label_username.TabIndex = 45;
            this.label_username.Text = "Kullanıcı Adı: ";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_username.Visible = false;
            // 
            // button_geri
            // 
            this.button_geri.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_geri.Location = new System.Drawing.Point(12, 12);
            this.button_geri.Name = "button_geri";
            this.button_geri.Size = new System.Drawing.Size(54, 28);
            this.button_geri.TabIndex = 41;
            this.button_geri.Text = "Geri";
            this.button_geri.UseVisualStyleBackColor = false;
            this.button_geri.Visible = false;
            this.button_geri.Click += new System.EventHandler(this.button_geri_Click);
            // 
            // label_islemSeçiniz
            // 
            this.label_islemSeçiniz.AutoSize = true;
            this.label_islemSeçiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_islemSeçiniz.Location = new System.Drawing.Point(67, 16);
            this.label_islemSeçiniz.Name = "label_islemSeçiniz";
            this.label_islemSeçiniz.Size = new System.Drawing.Size(266, 20);
            this.label_islemSeçiniz.TabIndex = 40;
            this.label_islemSeçiniz.Text = "Yapmak istediğiniz işlemi seçin: ";
            // 
            // button_kayitOl
            // 
            this.button_kayitOl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_kayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kayitOl.Location = new System.Drawing.Point(118, 49);
            this.button_kayitOl.Name = "button_kayitOl";
            this.button_kayitOl.Size = new System.Drawing.Size(78, 28);
            this.button_kayitOl.TabIndex = 38;
            this.button_kayitOl.Text = "Kayıt Ol";
            this.button_kayitOl.UseVisualStyleBackColor = false;
            this.button_kayitOl.Click += new System.EventHandler(this.button_kayitOl_Click_1);
            // 
            // button_girisYap
            // 
            this.button_girisYap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_girisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_girisYap.Location = new System.Drawing.Point(202, 49);
            this.button_girisYap.Name = "button_girisYap";
            this.button_girisYap.Size = new System.Drawing.Size(86, 28);
            this.button_girisYap.TabIndex = 39;
            this.button_girisYap.Text = "Giriş Yap";
            this.button_girisYap.UseVisualStyleBackColor = false;
            this.button_girisYap.Click += new System.EventHandler(this.button_girisYap_Click_1);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 561);
            this.Controls.Add(this.button_kayitOl2);
            this.Controls.Add(this.maskedTextBox_telefon);
            this.Controls.Add(this.button_girisYap2);
            this.Controls.Add(this.dateTimePicker_dogumTarihi);
            this.Controls.Add(this.label_dogumTarihi);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label_telefon);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.label_soyad);
            this.Controls.Add(this.label_ad);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_geri);
            this.Controls.Add(this.label_islemSeçiniz);
            this.Controls.Add(this.button_kayitOl);
            this.Controls.Add(this.button_girisYap);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_login";
            this.Text = "Giriş Uygulaması";
            this.Load += new System.EventHandler(this.Form_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablecustomerinformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEkranıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecustomerinformationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEkranıDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablecustomerinformationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEkranıDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private loginEkranıDataSet loginEkranıDataSet;
        private System.Windows.Forms.BindingSource tablecustomerinformationBindingSource;
        private loginEkranıDataSetTableAdapters.Table_customer_informationTableAdapter table_customer_informationTableAdapter;
        private loginEkranıDataSet1 loginEkranıDataSet1;
        private System.Windows.Forms.BindingSource tablecustomerinformationBindingSource1;
        private loginEkranıDataSet1TableAdapters.Table_customer_informationTableAdapter table_customer_informationTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private loginEkranıDataSet2 loginEkranıDataSet2;
        private System.Windows.Forms.BindingSource tablecustomerinformationBindingSource2;
        private loginEkranıDataSet2TableAdapters.Table_customer_informationTableAdapter table_customer_informationTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_kayitOl2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefon;
        private System.Windows.Forms.Button button_girisYap2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogumTarihi;
        private System.Windows.Forms.Label label_dogumTarihi;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_geri;
        private System.Windows.Forms.Label label_islemSeçiniz;
        private System.Windows.Forms.Button button_kayitOl;
        private System.Windows.Forms.Button button_girisYap;
    }
}

