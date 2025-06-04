using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeamSignUpModule
{
    public partial class SignUpForm : Form
    {
        Db DB = new Db();

        private static bool idState = false;
        private static string imgFilepath = "";

        public SignUpForm()
        {
            InitializeComponent();
            getDep();
        }

        private void checkAvBtn_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                idCheckLabel.Text = "공백은 사용할 수 없습니다.";
                idState = false;
                return;
            }

            if (DB.avCheck(id.Text))
            {
                idCheckLabel.Text = "사용 가능한 아이디입니다.";
                idState = true;
            }
            else
            {
                idCheckLabel.Text = "사용 불가능한 아이디입니다.";
                idState = false;
            }
        }



        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (!idState)
            {
                MessageBox.Show("아이디 중복확인이 필요합니다.");
                return;
            }
            if (!infoCheck())
            {
                MessageBox.Show("회원가입 실패. 누락된 정보가 존재합니다.");
                return;
            }
            DB.sendData(name.Text, nickname.Text, id.Text, pw.Text, department.SelectedIndex + 1, address.Text, team.Text, imgFilepath);
            MessageBox.Show("회원가입이 완료되었습니다. 로그인으로 돌아갑니다.");
            //form close
        }

        private bool infoCheck()
        {
            //check that all information is entered & id availability
            if (name.Text != "" && nickname.Text != "" && pw.Text != "" && department.Text != "" && address.Text != "")
            {
                return true;
            }
            return false;
        }

        private void getDep()
        {
            List<String> depList = DB.getDep();
            foreach (string item in depList) department.Items.Add(item);
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void imgLoad_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\";
            dialog.Filter = "JPG Files(*.jpq)|*.jpg|JPGE Files(*.jpqe)|*.jpge|PNG Files(*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            imgBox.Image = Bitmap.FromFile(image_file);
            imgFilepath = image_file;
        }

        private void imgDel_Click(object sender, EventArgs e)
        {
            imgBox.Image = null;
        }

        private void department_SelectedIndexChanged(object sender, EventArgs e)
        {
            team.Items.Clear();
            List<String> teamList = DB.getTeam(department.SelectedIndex + 1);
            foreach (string item in teamList) team.Items.Add(item);
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            idState = false;
            idCheckLabel.Text = "중복확인 필요";
        }

        private void getAdBtn_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();

            if (frm.Address != "")
            {
                txtAddress.Text = frm.Address;
            }
            frm = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
