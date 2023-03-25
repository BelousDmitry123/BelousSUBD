using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace СУБД_Кадры_Белоус
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static string TxtCon = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{Application.StartupPath}\Kadres.mdf"";Integrated Security=True";

        struct Kadr
        {
            public string ID, LastName, FirstName, Patronymic,Email,Phone,Birthday;
        }

        List<Kadr> LstKadr = new List<Kadr>();

        int CountPerPage = 5, NBegin = 0;

        void GetDataFromDB()
        {
            NBegin = 0;

            SqlConnection Con = new SqlConnection(TxtCon);
            Con.Open();

            string Uslovie = "";

            if (CmbFind.Text == "Фамилии")
                Uslovie += $" where LastName LIKE '{TbFind.Text}%'";
            if (CmbFind.Text == "Имени")
                Uslovie += $" where FirstName LIKE '{TbFind.Text}%'";
            if (CmbFind.Text == "Отчеству")
                Uslovie += $" where Patronymic LIKE '{TbFind.Text}%'";

            if (CmbFilter.Text == "мужской")
                Uslovie += $" and Gender='м'";
            if (CmbFilter.Text == "женский")
                Uslovie += $" and Gender='ж'";

            if (CmbSort.SelectedIndex == 1)
                Uslovie += " order by LastName";
            if (CmbSort.SelectedIndex == 2)
                Uslovie += " order by Birthday desc";

            string TxtQuery = @"
select Id,LastName,FirstName,Patronymic,Email,Phone,Birthday
from Kadr
" + Uslovie;
            SqlCommand Query1 = new SqlCommand(TxtQuery, Con);
            SqlDataReader Res = Query1.ExecuteReader();
            LstKadr.Clear();
            while (Res.Read())
            {
                Kadr NewKard = new Kadr();
                NewKard.ID = Res["ID"].ToString();
                NewKard.LastName = Res["LastName"].ToString();
                NewKard.FirstName = Res["FirstName"].ToString();
                NewKard.Patronymic = Res["Patronymic"].ToString();
                NewKard.Email = Res["Email"].ToString();
                NewKard.Phone = Res["Phone"].ToString();
                NewKard.Birthday = Res["Birthday"].ToString();
                LstKadr.Add(NewKard);
            }
            Res.Close();
            Con.Close();

            TslInfo.Text = TxtQuery + Uslovie;
        }

        void FillDgvClient()
        {

            DgvClients.Rows.Clear();
            for (int i = NBegin; i <= NBegin + CountPerPage - 1; i++)
            {
                
                if (i > LstKadr.Count - 1)
                    break;
              
                string Mess = $"{LstKadr[i].LastName} {LstKadr[i].FirstName} {LstKadr[i].Patronymic}\r\nЭлектронная почта: {LstKadr[i].Email}\r\nТелефонный номер: {LstKadr[i].Phone}\r\nДата рождения: {LstKadr[i].Birthday}";

                DgvClients.Rows.Add(Mess, LstKadr[i].ID);
            }
            if (CountPerPage == 0)
                CountPerPage = 1;
            int Cnt = LstKadr.Count / CountPerPage;
            
            if (LstKadr.Count % CountPerPage != 0)
                Cnt++;
            

            PanelPages.Controls.Clear();
            LblBack.Dock = DockStyle.Left;
            LblNext.Dock = DockStyle.Left;
            PanelPages.Controls.Add(LblNext);
            for (int i = Cnt; i >= 1; i--)
            {
                Label Lbl = new Label();
                Lbl.Text = i.ToString();
                Lbl.Dock = DockStyle.Left;
                Lbl.AutoSize = true;
               
                if ((NBegin + CountPerPage) / CountPerPage == i)
                {
                    Lbl.BackColor = Color.LightGray;
                    Lbl.Font = new Font(Lbl.Font, FontStyle.Underline);
                }
                Lbl.Click += Lbl_Click;
                PanelPages.Controls.Add(Lbl);
            }

            PanelPages.Controls.Add(LblBack);


        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            
            int n = int.Parse((sender as Label).Text);
            NBegin = (n - 1) * CountPerPage;
            FillDgvClient();
        }
        private void LblBack_Click(object sender, EventArgs e)
        {
            
            if (NBegin > 0)
            {
                NBegin -= CountPerPage;
                FillDgvClient();
            }
        }

        private void LblNext_Click(object sender, EventArgs e)
        {
            
            if (NBegin + CountPerPage < LstKadr.Count)
            {
                NBegin += CountPerPage;
                FillDgvClient();
            }
        }

        private void TbFind_TextChanged(object sender, EventArgs e)
        {
            GetDataFromDB();
            FillDgvClient();
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataFromDB();
            FillDgvClient();
        }

        private void CmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDataFromDB();
            FillDgvClient();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            fAdd fadd = new fAdd();
            fadd.ShowDialog();

            int CurrentNBegin = NBegin;
            GetDataFromDB();
            NBegin = CurrentNBegin;
            FillDgvClient();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Вы действительно хотите удалить кадра?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.No)
                return;

            SqlConnection Con = new SqlConnection(TxtCon);
            Con.Open();
            string TxtQuery = $"delete from Kadr where Id={DgvClients.CurrentRow.Cells[1].Value}";
            SqlCommand Query1 = new SqlCommand(TxtQuery, Con);
            Query1.ExecuteNonQuery();
            Con.Close();

            int CurrentNBegin = NBegin;
            GetDataFromDB();
            NBegin = CurrentNBegin;
            FillDgvClient();
            TslInfo.Text = TxtQuery;
            MessageBox.Show("Кадр был успешно удалён!", "Внимание!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GetDataFromDB();
            FillDgvClient();

            CmbFilter.SelectedIndex = 0;
            CmbSort.SelectedIndex = 0;
        }

        
    }
}
