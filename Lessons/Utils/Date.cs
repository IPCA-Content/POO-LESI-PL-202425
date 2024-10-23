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
    /// <returns></returns>
    public int Age(DateOnly date)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        int age = today.Year - date.Year;
        if (date > today.AddYears(-age)) age--;
        return age;
    }
    #endregion
}