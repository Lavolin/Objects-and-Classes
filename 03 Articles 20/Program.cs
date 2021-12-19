using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Articles_20
{
    class Article
    {
        private string title_;
        private string content_;
        private string author_;


        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title // properties
        {
            get => title_;
            set => title_ = value;
        }

        public string Content // properties
        {
            get => content_;
            set => content_ = value;
        }
        public string Author // properties
        {
            get => author_;
            set => author_ = value;
        }

        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;




        public override string ToString() => $"{Title} - {Content}: {Author}"; // method


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();


            for (int i = 0; i < n; i++)
            {
                string[] initialArticle = Console.ReadLine().Split(", ");

                Article article = new Article(initialArticle[0], initialArticle[1], initialArticle[2]);
                articles.Add(article);
            }
            string line = Console.ReadLine();
            switch (line)
            {
                case "title":
                    articles.Sort((article1, article2) => article1.Title.CompareTo(article2.Title));
                    break;
                case "content":
                    articles.Sort((article1, article2) => article1.Content.CompareTo(article2.Content));
                    break;
                case "author":
                    articles.Sort((article1, article2) => article1.Author.CompareTo(article2.Author));
                    break;
            }

            foreach (Article article in articles)
            {

                Console.WriteLine(article);
            }
        }
    }
}
