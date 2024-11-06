namespace Utils;

/// <summary>
/// Class Operations 
/// </summary>
public class Date
{
    #region Public Methods
    /// <summary>
    /// Calculate Age base on date
    /// </summary>
    /// <param name="date"></param>
    /// <returns>int</returns>
    public int Age(DateOnly date)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        int age = today.Year - date.Year;
        if (date > today.AddYears(-age)) age--;
        return age;
    }
    
    /// <summary>
    /// Calculate Age base on date
    /// (generic with primitives args)
    /// </summary>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <param name="day"></param>
    /// <returns>int</returns>
    public int Age(int year, int month, int day)
    {
        DateOnly date = new DateOnly(year, month, day);
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        int age = today.Year - date.Year;
        if (date > today.AddYears(-age)) age--;
        return age;
    }
    #endregion
}