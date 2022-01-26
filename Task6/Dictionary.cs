namespace Task6
{
    internal class Dictionary
    {
        private string[] rus = new string[5];
        private string[] eng = new string[5];
        private string[] ua = new string[5];

        public Dictionary()
        {
            rus[0] = "книга"; eng[0] = "book"; ua[0] = "Книга";
            rus[1] = "ручка"; eng[1] = "pen"; ua[1] = "Ручка";
            rus[2] = "солнце"; eng[2] = "sun"; ua[2] = "Сонце";
            rus[3] = "яблоко"; eng[3] = "apple"; ua[3] = "Яблуко";
            rus[4] = "стол"; eng[4] = "table"; ua[4] = "Стола";
        }

        public string this[string index, Language language]
        {
            get
            {
                string[] dict = null;
                switch (language)
                {
                    case Language.Rus:
                        dict = rus;
                        break;
                    case Language.Eng:
                        dict = eng;
                        break;
                    case Language.Ua:
                        dict = ua;
                        break;
                }
                for (int i = 0; i < dict.Length; i++)
                    if (dict[i] == index)
                        return rus[i] + " - " + eng[i] + " - " + ua[i];

                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < rus.Length)
                    return rus[index] + " - " + eng[index] + " - " + ua[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }

        public enum Language
        {
            Rus,
            Eng,
            Ua
        }
    }
}
