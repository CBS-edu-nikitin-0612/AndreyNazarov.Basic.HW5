namespace Task4
{
    internal class Store
    {
        private Article[] articles;

        public string this[int index]
        {
            get
            {
                return articles[index].GetInfo();
            }
        }

        public string this[string str]
        {
            get
            {
                string result = "";
                for (int i = 0; i < articles.Length - 1; i++)
                {
                    if (articles[i].IsName(str))
                    {
                        result = articles[i].GetInfo();
                        break;
                    }
                    result = $"Article ({str}) did not found";
                }
                return result;
            }
        }

        public Store()
        {
            var article1 = new Article("item1", "shop1", 100);
            var article2 = new Article("item2", "shop2", 200);
            var article3 = new Article("item3", "shop3", 10880);
            articles = new Article[3] { article1, article2, article3 };
        }
    }
}
