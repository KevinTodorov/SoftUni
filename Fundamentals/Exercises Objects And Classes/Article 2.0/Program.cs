using System;
using System.Collections.Generic;
using System.Linq;

namespace Article_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(", ");
                Article article = new Article(array[2], array[1], array[0]);
                articles.Add(article);
            }

            string type = Console.ReadLine();

            switch (type)
            {
                case "title":
               articles.Sort((article1, article2) => article1.Title.CompareTo
                   (article2.Title)); 
                    break;
                case "content":
                articles.Sort((article1, article2) => article1.Content.CompareTo
                    (article2.Content));
                    break;
                case "author":
                    articles.Sort((article1, article2) => article1.Author.CompareTo
                        (article2.Author));
                    break;
            }

            foreach (Article item in articles)
            {
                Console.WriteLine(item);
            }
            
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
