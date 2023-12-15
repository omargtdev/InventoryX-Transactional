using System.Net.Mail;
using System.Text.RegularExpressions;

namespace InventoryX_Transactional.Extensions;

public static class StringExtensions
{

    public static bool IsLessThan3Characters(this string value) => 
        string.IsNullOrEmpty(value) || value.Trim().Length < 3;
    
    public static bool IsNullOrEmptyOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);

    public static bool IsValidEmail(this string value)
    {
        var isValid = true;
        try
        {
            _ = new MailAddress(value);
        }
        catch
        {
            isValid = false;    
        }

        return isValid;
    }

    public static bool IsValidPhoneNumber(this string value)
    {
        if(value.IsNullOrEmptyOrWhiteSpace())
        {
            return false;
        }

        string PhoneNumberWith9NumbersPattern = @"^9\d{8}$";

        return Regex.IsMatch(value, PhoneNumberWith9NumbersPattern);
    }

    public static bool HasOnlyNumbers(this string value)
    {
        if(value.IsNullOrEmptyOrWhiteSpace())
        {
            return false;
        }

        var OnlyNumbersPattern = @"^\d+$";
        return Regex.IsMatch(value, OnlyNumbersPattern);
    }

}
