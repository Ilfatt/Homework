using System;

namespace Task3;

/// <summary>
/// Класс персональный компьютер
/// </summary>
public class Pc : StationaryComputer
{
    /// <summary>
    /// Конструктор создающий персональные компьютеры 
    /// </summary>
    public Pc(int age, int cost, string vendorCpu, int _RAM, int agePeriphery)
    {
        Age = age;
        Cost = cost;
        VendorCpu = vendorCpu;
        RAM = _RAM;
        AgePeriphery = agePeriphery;
    }

    /// <summary>
    /// Наличие,отсутсвие перефирии 
    /// </summary>

    public bool HavePeriphery { get; private set; } = false;

    /// <summary>
    /// Дата сборки
    /// </summary>
    public override int Age { get; protected set; }

    /// <summary>
    /// Актуальность перефирии ,время ее покупки 
    /// </summary>
    public int AgePeriphery { get; private set; }


    /// <summary>
    /// Метод позволяющий купить перефирию
    /// </summary>
    /// <param name="costPeriphery">Цена перефирии</param>
    public void BuyPeriphery(int costPeriphery = 10000)
    {
        HavePeriphery = true;
        Cost += costPeriphery;
        AgePeriphery = 0;
    }

    /// <summary>
    ///  определяет как долго техника (компьютер + переферия)
    /// храниться на складе/дату сборки/дату покупки 
    /// </summary>
    /// <returns>возвращает время хранения строкой </returns>
    public override string StorageTime
    {
        get
        {
            if (!HavePeriphery)
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

            string outputAgePeriphery = default;
            if (AgePeriphery == 0)
            {
                outputAgePeriphery = "только что купленной  перифирией";
            }
            else
            {
                outputAgePeriphery = "недавно купленной  перифирией";
            }

            if (Age <= 1)
            {
                return $"новый и с {outputAgePeriphery}";
            }

            if (Age <= 3)
            {
                return $"немномного полежал на складе и он с {outputAgePeriphery}";
            }

            return $"давно лежит на складе и он с {outputAgePeriphery}";
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
            Cost = Cost + 400 * RAM;
        }

        Cost = Cost + 400 * RAM;
        if (RAM == 1)
        {
            RAM = RAM + 1;
        }

        RAM = RAM * 2;
    }

    public new string ToString()
    {
        return
            $"{StorageTime} игровой пк с ценой всего лишь {Cost} c {RAM} ГБ ОЗУ и с мощным процессором от компании {VendorCpu}";
    }
}