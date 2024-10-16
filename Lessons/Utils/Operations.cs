namespace Utils;

/// <summary>
/// Class Operations 
/// </summary>
public class Operations
{
    /// <summary>
    /// Calculate Age base on date
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public int Age(DateOnly date)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        int age = today.Year - date.Year;
        if (today < date.AddYears(-age)) age--;
        return age;
    }
}