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
    /// <param name="memberInfo">The MemberInfo to check.</param>
    /// <returns><c>true</c> if the specified MemberInfo is a field; otherwise, <c>false</c>.</returns>
    public static bool IsField(this System.Reflection.MemberInfo memberInfo)
    {
        return memberInfo.MemberType == MemberTypes.Field;
    }

    /// <summary>
    /// Determines whether the specified MemberInfo is a property.
    /// </summary>
    /// <param name="memberInfo">The MemberInfo to check.</param>
    /// <returns><c>true</c> if the specified MemberInfo is a property; otherwise, <c>false</c>.</returns>
    public static bool IsProperty(this System.Reflection.MemberInfo memberInfo)
    {
        return memberInfo.MemberType == MemberTypes.Property;
    }
}