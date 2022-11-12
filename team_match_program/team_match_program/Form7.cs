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
    public partial class frmTeamManagement_admin : Form
    {
        public frmTeamManagement_admin(List<string> Team)
        {
            InitializeComponent();
            Form1 main = new Form1();
            textBox1.Text = Team[0];
            for (int i = 0; i < main.Nickname.Count; i++)
            {
                dataGridView1.Rows.Add(main.Nickname[i], main.Win[i], main.Defeat[i]);
            }
        }

        private void frmTeamManagement_admin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
