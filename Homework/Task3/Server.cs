using System;

namespace Task3;

/// <summary>
/// Класс Сервер
/// </summary>
public class Server : StationaryComputer
{
    /// <summary>
    /// Конструктор серверов
    /// </summary>
    public Server( string vendorCpu, int _RAM, int countCpu)
    {
        VendorCpu = vendorCpu;
        RAM = _RAM;
        CountCpu = countCpu;
        Cost = MinCost.GetValueOrDefault("Server");
    }

    /// <summary>
    /// Дата сборки
    /// </summary>

    public override int Age { get; protected set; } = 0;

    /// <summary>
    /// Количество процессоров
    /// </summary>
    public int CountCpu { get; private set; }

    /* Этот метод и переопределенный метод ToString() делает одно и тоже поэтому этот метод пусть останется как коммент
     /// <summary>
    /// Метод рекламириющий сервер
    /// </summary>
    /// <returns>Возвращает текстовую рекламу </returns>


    public string Advertising()
    {
        return $"{CountCpu} мощных процессоров от компании  {VendorCpu} и {RAM} гб озу  подойдут" +
               " даже для моделирования солнечной системы";
        
    }
    */


    /// <summary>
    ///  определяет как долго техника храниться на складе 
    /// </summary>
    /// <returns>Возвращает строкой время хранения на складе </returns>
    public override string StorageTime
    {
        get
        {
            return "новый"; //Сервера делаются только под заказ 
        }
    }

    /// <summary>
    /// Этот метод докупает ОЗУ 
    /// </summary>
    public override void UpgradeRAM()
    {
        if (RAM == 0)
        {
            RAM = 8;
            Cost = Cost + 600 * RAM;
        }

        Cost = Cost + 600 * RAM;
        if (RAM == 1)
        {
            RAM = RAM + 1;
        }

        RAM = RAM * 2;
    }

    /// <summary>
    /// Этот метод запускает Ведьмака на Сервере
    /// </summary>
    /// <returns>Возвращает информацию о мощности которую он отвел на игру</returns>
    /// <exception cref="NotTrueInputException"></exception>
    public new string PlayTheWitcher3()
    {
        while (true)
        {
            int intPower = default;

            Console.WriteLine("Какой процент моей вычислительной мощности вы хотите занять для этих целей ? " +
                              "(На вход разрешены только числа от 1 до 100)");
            string strPower = Console.ReadLine();
            try
            {
                intPower = int.Parse(strPower);
                if (intPower >= 101 || intPower <= 0)
                {
                    throw new NotTrueInputException();
                }
            }
            catch
            {
                throw new NotTrueInputException();
            }

            if (intPower == default)
            {
                continue;
            }

            return $"Целых {intPower} процентов моей мощи я отвел для запуска этой великолепной игры ";
        }
    }

    public new string ToString()
    {
        return
            $"{StorageTime} сервер  с ценой всего лишь {Cost} c {RAM} ГБ ОЗУ и с {CountCpu} мощными процессорами от компании {VendorCpu}";
    }
}