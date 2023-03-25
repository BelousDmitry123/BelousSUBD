using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Кадры_Белоус
{
    public partial class fAdd : Form
    {
        public fAdd()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (TbxFirstName.Text.Trim() == "" || TbxLastName.Text.Trim() == "" || TbxPhone.Text.Trim() == "" || TbxEmail.Text.Trim()=="")
            {
                MessageBox.Show("Фамилия, имя, телефон и email являются обязательными для заполнения", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TbxEmail.Text.Trim() != "")
            {
                try
                {
                    MailAddress Email = new MailAddress(TbxEmail.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Недопустимый адрес E-mail", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            DateTime date = Convert.ToDateTime(DtpBirthday.Text);
            string TxtQuery = $@"insert into Kadr(LastName,FirstName,Patronymic,Email,Phone,Birthday,Gender)
values ('{TbxLastName.Text}','{TbxFirstName.Text}','{TbxPatronymic.Text}','{TbxEmail.Text}','{TbxPhone.Text}','{date.ToString("yyyy-MM-d")}','{LblGenderCode.Text}')";
            SqlCommand Query1 = new SqlCommand(TxtQuery, Con);
            Query1.ExecuteNonQuery();
            this.Close();
        }

        private void TbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            if (e.KeyChar == ' ' || e.KeyChar == '-')
                e.Handled = false;
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RbtMale_CheckedChanged(object sender, EventArgs e)
        {
            LblGenderCode.Text = "м";
        }

        private void RbtFemale_CheckedChanged(object sender, EventArgs e)
        {
            LblGenderCode.Text = "ж";
        }
    }
}
