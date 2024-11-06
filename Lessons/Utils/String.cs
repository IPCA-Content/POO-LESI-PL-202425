using System.Text;

namespace Utils;

/// <summary>
/// Class String implements helpers
/// </summary>
public class String
{
    #region Methods
    /// <summary>
    /// Generate Random Strings
    /// </summary>
    /// <param name="count"></param>
    /// <param name="length"></param>
    /// <returns>string[]</returns>
    public string[] RandomStrings(int count, int length)
    {
        if (count < 0)
            throw new ArgumentException("Count cannot be negative.", nameof(count));
        if (length < 0)
            throw new ArgumentException("Length cannot be negative.", nameof(length));
        
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        string[] result = new string[count];

        for (int i = 0; i < count; i++)
        {
            StringBuilder sb = new StringBuilder(length);
            for (int j = 0; j < length; j++)
            {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            result[i] = sb.ToString();
        }

        return result;
    }
    #endregion
}