namespace Task3;

/// <summary>
/// Стационарный компьютер
/// </summary>
public abstract class StationaryComputer : Computer
{
    /// <summary>
    /// Вендор процессора 
    /// </summary>
    public static string VendorCpu { get; protected set; }

    // static обосновывается тем что магазин закупает/собирает технику на процессорах от одного вендора посколько он лучше других
    // в сфере ноутбуков к примеру пока рулят AMD
    // или  магазин это партнер какого то вендора и у них договор  

    /// <summary>
    /// ОЗУ
    /// </summary>
    public int RAM { get; protected set; }

    //Я понимаю что у ноутбуков тоже есть такие параметры ,просто у ноутбука они не изменяемы + я ничего больше не смог придумать 

    /// <summary>
    /// Этот метод докупает ОЗУ 
    /// </summary>
    public abstract void UpgradeRAM();
}