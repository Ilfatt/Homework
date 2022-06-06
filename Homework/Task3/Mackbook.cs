using System;

namespace Task3;

/// <summary>
///  Класс Макбук
/// </summary>
public class Mackbook : Laptop
{
    /// <summary>
    /// Заменить батарею
    /// </summary>
        
    public override void ReplaceBattery()
    {
        Cost += 12000;
        Console.WriteLine("Вы заменили батарею");
    }
    /// <summary>
    /// Тач бар
    /// </summary>
    public bool TouchBar { get; private set; }

    /// <summary>
    /// Конструктор для создания Мукбука 
    /// </summary>
    public Mackbook(int age, int cost, bool touchBar, double weight)
    {
        Age = age;
        Cost = cost;
        TouchBar = touchBar;
        Weight = weight;
    }

    /// <summary>
    /// Метод проверящий Макбук на наличие тач бара 
    /// </summary>
    /// <returns>возвращает строкой информацию о наличии/отсутсвии тач бара </returns>
    public string HaveTouchBar()
    {
        if (TouchBar)
        {
            return "есть крутой тач бар";
        }

        return "Мак сам по себе крутой";
    }

    /// <summary>
    /// Метод который запускает Ведьмака
    /// </summary>
    /// <returns>Возвращает строкой невозможность запуска ведьмака на макбуке </returns>
    public new string PlayTheWitcher3()
    {
        return "Я сделан для более высоких целей";
    }
}