using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Form1 : Form
    {
        Library lib = new Library();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lib.LoadFromFile();
            RefreshList();
        }
        void RefreshList()
        {
            listBox1.Items.Clear();

            foreach (var book in lib.Books)
            {
                listBox1.Items.Add(book);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Titletxt.Text == "" || Authortxt.Text == "")
                {
                    MessageBox.Show("Please enter title and author");
                    return;
                }

                Book b = new Book(Titletxt.Text, Authortxt.Text);
                lib.AddBook(b);
                lib.SaveToFile();
                RefreshList();

                Titletxt.Clear();
                Authortxt.Clear();
            }
            catch
            {
                MessageBox.Show("Error adding book");
            }
        }

        private void Borrowbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            lib.Books[listBox1.SelectedIndex].IsBorrowed = true;
            lib.SaveToFile();
            RefreshList();
        }

        private void Returntxt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            lib.Books[listBox1.SelectedIndex].IsBorrowed = false;
            lib.SaveToFile();
            RefreshList();
        }

        private void Authortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Titletxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
