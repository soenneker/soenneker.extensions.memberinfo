using System.Reflection;

namespace Soenneker.Extensions.MemberInfo;

/// <summary>
/// A collection of helpful MemberInfo (Reflection) extension methods
/// </summary>
public static class MemberInfoExtension
{
    /// <summary>
    /// Determines whether the specified MemberInfo is a field.
    /// </summary>
    /// <param name="member">The MemberInfo to check.</param>
    /// <returns><c>true</c> if the specified MemberInfo is a field; otherwise, <c>false</c>.</returns>
    internal static bool IsField(this System.Reflection.MemberInfo member)
    {
        return member.MemberType == MemberTypes.Field;
    }

    /// <summary>
    /// Determines whether the specified MemberInfo is a property.
    /// </summary>
    /// <param name="member">The MemberInfo to check.</param>
    /// <returns><c>true</c> if the specified MemberInfo is a property; otherwise, <c>false</c>.</returns>
    internal static bool IsProperty(this System.Reflection.MemberInfo member)
    {
        return member.MemberType == MemberTypes.Property;
    }
}