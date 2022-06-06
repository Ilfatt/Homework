using System;

namespace Task3;

/// <summary>
/// Класс Игровой ноутбук
/// </summary>
public class GamingLaptop : Laptop
{
    /// <summary>
    /// Подсветка
    /// </summary>
    public bool Backlight { get; protected set; }

    /// <summary>
    /// Конструктор для создания игровых ноутбуков 
    /// </summary>
    public GamingLaptop(int age, bool backlight, double weight)
    {
        Age = age;
        Weight = weight;
        Backlight = backlight;
        Cost = MinCost.GetValueOrDefault("GamingLaptop");
    }

    /// <summary>
    /// Метод проверяет на наличие подсветки
    /// </summary>
    /// <returns>Возвращает наличие/отсутсвие подсветки </returns>
    public string HaveBacklight()
    {
        if (!Backlight)
        {
            return "к тому же тут нет этих ваших беспонтовых rgb";
        }

        return "к тому же он еще и светиться";
    }

    /// <summary>
    /// Заменить батарею
    /// </summary>
    public override void ReplaceBattery()
    {
        Cost += 5000;
        Console.WriteLine("Вы заменили батарею");
    }
}