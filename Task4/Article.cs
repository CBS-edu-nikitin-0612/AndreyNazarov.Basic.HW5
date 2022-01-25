namespace Task4
{
    internal class Article
    {
        private string name;
        private string shopName;
        private decimal priceUAH;

        public string GetInfo()
        {
            return $"Name: {name}\n" +
                $"Shop name: {shopName}\n" +
                $"Prise in UAH: {priceUAH}";
        }

        public bool IsName(string name)
        {
            return this.name == name;
        }

        public Article(string name, string shopName, decimal priceUAH)
        {
            this.name = name;
            this.shopName = shopName;
            this.priceUAH = priceUAH;
        }
    }
}
