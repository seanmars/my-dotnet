using Microsoft.CSharp;

public static class TypeNameExtension
{
  public static string GetSimplifiedName(this Type t)
  {
    using (var provider = new CSharpCodeProvider())
    {
        var typeRef = new CodeTypeReference(t);
        return provider.GetTypeOutput(typeRef);
    }    
  }
}
