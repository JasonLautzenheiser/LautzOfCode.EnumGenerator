namespace LautzOfCode.EnumGenerator;

public readonly struct EnumToGenerate {
  public readonly string Name;
  internal readonly string? FullyQualifiedName;
  internal readonly string? Namespace;
  internal readonly bool IsPublic;
  internal readonly bool HasFlags;
  internal readonly string UnderlyingType;
  internal readonly List<KeyValuePair<string, object>> Values;

  public EnumToGenerate(
    string name,
    string? ns,
    string? fullyQualifiedName,
    string underlyingType,
    bool isPublic,
    List<KeyValuePair<string, object>> values,
    bool hasFlags) {
    Name = name;
    Namespace = ns;
    UnderlyingType = underlyingType;
    Values = values;
    HasFlags = hasFlags;
    IsPublic = isPublic;
    FullyQualifiedName = fullyQualifiedName;
  }
}
