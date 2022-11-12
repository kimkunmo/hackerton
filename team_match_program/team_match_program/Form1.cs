using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_match_program
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> IdPassward = new Dictionary<string, string>();
        public List<string> Nickname = new List<string>() {"김근모01", "김근모02", "박근민", "양두영", "최재원"};
        public List<string> ID = new List<string>() {"qwer", "asdf", "zxcv", "1234", "qazx"};
        public List<int> Win = new List<int>() {3, 2, 2, 1, 0};
        public List<int> Defeat = new List<int>() {0, 1, 1, 2, 3};
        public List<string> Team = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            IdPassward.Add("1", "1");
            bool flag = false;
            while (true)
            {
                frmLogin login = new frmLogin();
                DialogResult drResult = login.ShowDialog();
                if (drResult == DialogResult.Cancel)
                {
                    MessageBox.Show("로그인이 취소되었습니다. 프로그램을 종료합니다.");

                    login.Close();
                    Close();
                    break;
                }
                if (drResult == DialogResult.No)
                {
                    frmSignUp signup = new frmSignUp();
                    DialogResult sresult = signup.ShowDialog();
                    if (sresult == DialogResult.OK)
                    {
                        foreach (KeyValuePair<string, string> username in IdPassward)
                        {
                            if (username.Key == signup.NewID)
                            {
                                MessageBox.Show("실패");
                                flag = true;
                            }
                            else if(username.Value == signup.NewPass)
                            {
                                MessageBox.Show("실패");
                                flag = true;
                            }
                        }
                        if (!flag)
                        {
                            IdPassward.Add(signup.NewID, signup.NewPass);
                            Nickname.Add(signup.NickName);
                            ID.Add(signup.NewID);
                            Win.Add(0);
                            Defeat.Add(0);
                        }
                        else
                        {
                            MessageBox.Show("회원가입 실패");
                        }
                    }
                }
                
                else if (drResult == DialogResult.OK)
                {
                    foreach (KeyValuePair<string, string> username in IdPassward)
                    {
                        if (username.Key == login.inputID && username.Value == login.inputPass)
                        {
                            MessageBox.Show("성공");
                            frmOption option = new frmOption();
                            DialogResult oresult = option.ShowDialog();
                            if (oresult == DialogResult.OK)
                            {

                            }
                                goto EXITFOR;
                        }
                    }

                }
            }
        EXITFOR:
            MessageBox.Show("프로그램 실행");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeamCreate create = new frmTeamCreate();
            DialogResult crResult = create.ShowDialog();
            if (crResult == DialogResult.OK)
            {
                Team.Add(create.name);
                frmTeamManagement_admin admin = new frmTeamManagement_admin(Team);
                DialogResult adResult = admin.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
