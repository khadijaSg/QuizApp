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
    public partial class Questions : Form
    {

        QuizEntitiess db = new QuizEntitiess();

        public Questions()
        {
            InitializeComponent();
        }

        private void Questions_load(object sender, EventArgs e)
        {
            var myList = db.Questions.ToList();
            tbxQuestions.Text = myList[0].Question1;
            btnAnswer1.Text = myList[0].Answer1;
            btnAnswer2.Text = myList[0].Answer2;
            btnAnswer3.Text = myList[0].Answer3;
            btnAnswer4.Text = myList[0].Answer4;
        }

       
    }
}
