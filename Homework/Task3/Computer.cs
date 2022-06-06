namespace Task3
{
    /// <summary>
    /// Класс Компьютера  стоит на вершине иерархии и является основным 
    /// </summary>
    public abstract class Computer : ISellable
    {
        /// <summary>
        /// Метод для продажи
        /// </summary>
        /// <returns>цену проданного товара</returns>
        public int Sell(Informs del)
        {
            Console.WriteLine("Продано!");
            del(); 
            return Cost;
        }

        /// <summary>
        /// Цена
        /// </summary>
        public int Cost { get; protected set; }

        /// <summary>
        /// Дата сборки
        /// </summary>

        public abstract int Age { get; protected set; }
        
        /// <summary>
        /// определяет как долго техника храниться на складе/дату сборки 
        /// </summary>
        /// <returns>возвращает время хранения строкой </returns> 
        public virtual string StorageTime
        {
            get
            {
                if (Age <= 1)
                {
                    return "новый";
                }

                if (Age <= 3)
                {
                    return "немномного полежал на складе";
                }

                return "давно лежит на складе";
            }
        }

        /// <summary>
        /// Этот метод погружает нас в мир ведьмака 
        /// </summary>
        /// <returns>возвращает строкой  комфортность игры на данной технике </returns>
        public string PlayTheWitcher3()
        {
            if (Cost <= 35000)
            {
                return "Тяжело....";
            }

            if (Cost <= 120000)
            {
                return "Я постараюсь обеспечить хороший Fps и красивую картинку ";
            }

            return "Приятного времяпрепровождения в  8K 60Fps";
        }
    }
}