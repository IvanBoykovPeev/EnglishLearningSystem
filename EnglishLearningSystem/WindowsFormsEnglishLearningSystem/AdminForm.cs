using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEnglishLearningSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Words' table. You can move, or remove it, as needed.
            this.wordsTableAdapter.Fill(this.database1DataSet.Words);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.wordsTableAdapter.Update(this.database1DataSet.Words);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
