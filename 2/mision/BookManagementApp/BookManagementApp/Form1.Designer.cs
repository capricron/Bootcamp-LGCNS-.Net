namespace BookManagementApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 41);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(12, 67);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(50, 13);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 93);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(68, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(68, 38);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(68, 64);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(200, 20);
            this.txtPublisher.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(68, 90);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 20);
            this.txtYear.TabIndex = 7;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(15, 116);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(96, 116);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 9;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(177, 116);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(91, 23);
            this.btnSearchBook.TabIndex = 10;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 116);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(15, 145);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(334, 199);
            this.lstBooks.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 350);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(334, 20);
            this.txtSearch.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(364, 381);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Book Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
