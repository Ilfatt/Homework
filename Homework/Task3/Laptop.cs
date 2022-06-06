using System.Data.SqlTypes;

namespace Task3;

/// <summary>
/// Класс ноутбук
/// </summary>
public abstract class Laptop : Computer
{
    /// <summary>
    /// Вес
    /// </summary>
    public double Weight { get; protected set; }

    /// <summary>
    /// Дата сборки
    /// </summary>
    public override int Age { get; protected set; }

    /// <summary>
    /// Метод проверящий ноутбук на мобильность 
    /// </summary>
    /// <returns>возвращает строкой тяжость ноутбука </returns>
    public string Severity()
    {
        if (Weight <= 1.5)
        {
            return "весит как пёрышко";
        }

        if (Weight <= 2)
        {
            return "очень легкий";
        }

        return "легкий";
    }

    public abstract void ReplaceBattery();
    //  По тз мне надо было сделать новый абстрактный метод раз я старый в свойство переделаол
        
}