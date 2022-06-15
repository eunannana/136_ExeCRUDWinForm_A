using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm_136_A
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iLibraryDataSet.Librarian' table. You can move, or remove it, as needed.
            this.librarianTableAdapter.Fill(this.iLibraryDataSet.Librarian);

        }
    }
}
