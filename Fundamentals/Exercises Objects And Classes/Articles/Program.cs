using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[2], input[1], input[0]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(": ");

                switch (array[0])
                {
                    case "Edit":
                        article.Edit(array[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(array[1]);
                        break;
                    case "Rename":
                        article.Rename(array[1]);
                        break;
                }
            }

            Console.WriteLine($"{article.ToString()}");
        }
    }

    class Article
    {
        public string author_;
        public string content_;
        public string title_;

        public Article(string author, string content, string title)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title
        {
            get => title_;
            set => title_ = value;
        }

        public string Content
        {
            get => content_;
            set => content_ = value;
        }

        public string Author
        {
            get => author_; 
            set => author_ = value;
        }

        public void Edit(string content) => Content = content;

        public void ChangeAuthor(string author) => Author = author;

        public void Rename(string title) => Title = title;

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
