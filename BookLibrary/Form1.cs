using Entities;
using Repository;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //var Books = new List<Book>();
            //Books.Add(new Book { title = "Sherlock", author = "Conan Doyle", genre = "Romance", status = true });
            //Books.Add(new Book { title = "Hercule Poirot", author = "Agatha Christie", genre = "Mystery", status= true });

            //var source = new BindingList<Book>(Books);
            InitializeGrid();

        }

        private void InitializeGrid()
        {
            BookRepository bookRepository = new BookRepository();
            List<Book> bookList = bookRepository.GetBooks();
            List<Book> romanceBooks = bookList.Where(book => book.genre.ToLower() == "romance").ToList();
            this.RomanceGrid.DataSource = romanceBooks;
            List<Book> mysteryBooks = bookList.Where(b => b.genre.ToLower() == "mystery").ToList();
            this.MysteryGrid.DataSource = mysteryBooks;
            List<Book> SFBooks = bookList.Where(b => b.genre.ToLower() == "sf").ToList();
            this.SFGrid.DataSource = SFBooks;
            List<Book> psychologyBooks = bookList.Where(b => b.genre.ToLower() == "psychology").ToList();
            this.PsychologyGrid.DataSource = psychologyBooks;
            List<Book> adventureBooks = bookList.Where(b => b.genre.ToLower() == "adventure").ToList();
            this.AdventureGrid.DataSource = adventureBooks;
            List<Book> otherBooks = bookList.Where(b => b.genre.ToLower() == "other").ToList();
            this.OtherGrid.DataSource = otherBooks;


            this.Counter.Text = Convert.ToString(bookList.Count);

        }



        //private string SearchingBooks()
        //{
        //    BookRepository bookRepository1 = new BookRepository();
            
        //}
        
        


        private void Romance_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Book book = new Book();
            book.title = TitleBox.Text;
            book.author = AuthorBox.Text;
            book.genre = GenreBox.Text;
            book.status = StatusBox.Checked;
            
            BookRepository repository = new BookRepository();
            repository.SaveBook(book);
            InitializeGrid();

            this.TitleBox.Text = String.Empty;
            this.AuthorBox.Text = String.Empty;
            this.GenreBox.Text = String.Empty;
            this.StatusBox.Checked = false;

        }

        private void OK_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBook();

        }

        private void SearchBook()
        {
            string title = SearchBox.Text;
            BookRepository bookRepository = new BookRepository();
            List<Book> books = bookRepository.GetBooks();
            //List<Book> books2 = new List<Book>();
            //books2.AddRange(bookRepository.GetBooks());
            List<Book> foundBooks = books.Where(b => b.title.ToLower() == title.ToLower()).ToList();
            if (foundBooks.Count == 0)
            {
                this.SearchResultBox.Text = "404 BOOK NOT FOUND. You can buy this book.";
            }
            else
            {
                this.SearchResultBox.Text = "BOOK FOUND. DO NOT buy this book!";
            }

            SearchBox.Text = String.Empty;
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            if (e.KeyChar == 13)

            {
                SearchBook();
            }
        }
    }
}