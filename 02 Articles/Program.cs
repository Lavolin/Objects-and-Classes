using System;

namespace _02_Articles
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

        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;
        

        public string Author // properties
        {
            get => author_;
            set => author_ = value;
        }
        public override string ToString() => $"{Title} - {Content}: {Author}"; // method


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] initialArticle = Console.ReadLine().Split(", ");
            Article article = new Article(initialArticle[0], initialArticle[1], initialArticle[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ");
                string mainCmd = cmd[0];
                string argument = cmd[1];
                switch (mainCmd)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
}
