using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class EnterQuiz : Form
    {

        QuizEntitiess db = new QuizEntitiess();

        public EnterQuiz()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxUserName.Text == "" || tbxSurname.Text == "")
            {
                MessageBox.Show("Please fill the gaps...");
            }
            else
            {
                User user = new User();
                user.Username = tbxUserName.Text;
                user.Surname = tbxSurname.Text;
                Questions questions = new Questions();
                
                questions.Show();
                db.Users.Add(user);
                db.SaveChanges();
                tbxUserName.Text = "";
                tbxSurname.Text = "";
            }
        }

        private void EnterQuiz_Load(object sender, EventArgs e)
        {
            var category = db.Categories.ToList();
            CategoryList.Items.Add(category[0].CategoryName);
            CategoryList.Items.Add(category[1].CategoryName);
            CategoryList.Items.Add(category[2].CategoryName);
        }

        private void CategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
