using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookManagementApp
{
    public partial class Form1 : Form
    {
        private List<Book> books;

        public Form1()
        {
            InitializeComponent();
            books = new List<Book>();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtAuthor.Text) ||
                string.IsNullOrEmpty(txtPublisher.Text) || string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("All fields must be filled!");
                return;
            }

            Book newBook = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Publisher = txtPublisher.Text,
                Year = int.Parse(txtYear.Text)
            };
            books.Add(newBook);
            UpdateBookList();
            ClearInputFields();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            string titleToDelete = txtTitle.Text;
            books.RemoveAll(b => b.Title.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));
            UpdateBookList();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();
            var searchResult = books.FindAll(b => b.Title.ToLower().Contains(query) || b.Author.ToLower().Contains(query));
            lstBooks.Items.Clear();
            foreach (var book in searchResult)
            {
                lstBooks.Items.Add(book.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateBookList()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book.ToString());
            }
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtYear.Clear();
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Author} - {Publisher} - {Year}";
        }
    }
}
