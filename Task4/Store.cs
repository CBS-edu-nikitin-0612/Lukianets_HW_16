using System;

namespace Task4
{
    internal class Store
    {
        private Article[] articles;

        public Store(int size)
        {
            articles = new Article[size];
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index];
                return null;
            }
            set => articles[index] = value;
        }

        public Article this[string name]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (name == articles[i].Name)
                        return articles[i];                        
                }
                Console.WriteLine($"{name} not found");
                return null;
            }
        }
    }
}
