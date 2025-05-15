using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API.Extensions;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateOnly dob)
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var age = today.Year - dob.Year;
        if (dob > today.AddYears(-age)) age--; // if birthday doesn't happened in current year 
        return age;
    }

}
