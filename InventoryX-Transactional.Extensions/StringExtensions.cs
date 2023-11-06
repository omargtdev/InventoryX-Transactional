namespace InventoryX_Transactional.Extensions;

public static class StringExtensions
{
    public static bool IsLessThan3Characters(this string value) => 
        string.IsNullOrEmpty(value) || value.Trim().Length < 3;
}
