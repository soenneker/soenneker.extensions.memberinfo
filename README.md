[![](https://img.shields.io/nuget/v/soenneker.extensions.memberinfo.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.memberinfo/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.memberinfo/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.memberinfo/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.memberinfo.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.memberinfo/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.memberinfo/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.memberinfo/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.MemberInfo
Fast reflection member-kind checks for fields and properties.

## Installation

```bash
dotnet add package Soenneker.Extensions.MemberInfo
```

## Usage

```csharp
using Soenneker.Extensions.MemberInfo;

foreach (MemberInfo member in typeof(Customer).GetMembers())
{
    if (member.IsProperty())
    {
        ProcessProperty((PropertyInfo)member);
    }
    else if (member.IsField())
    {
        ProcessField((FieldInfo)member);
    }
}
```

`IsField()` returns `true` only when `MemberInfo.MemberType` is `MemberTypes.Field`. `IsProperty()` does the same for `MemberTypes.Property`. Methods, constructors, events, nested types, and other member kinds return `false` from both checks.

These methods classify metadata that has already been discovered; they do not enumerate members, inspect access modifiers, distinguish static from instance members, or check whether a property is readable/writable. A null `MemberInfo` throws `NullReferenceException` when the extension dereferences it.
