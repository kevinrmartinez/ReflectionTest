// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

string dllPath = "ReflectionPackTest.dll";

Assembly assembly = Assembly.LoadFrom(dllPath);
Type ReflectionPackTestType = assembly.GetType("ReflectionPackTest.Pack");

object instancia = Activator.CreateInstance(ReflectionPackTestType);
MethodInfo[] Pack = ReflectionPackTestType.GetMethods();

for (int i = 0; i < Pack.Length; i++)
{
    Console.WriteLine(Pack[i].ToString());
}
Console.WriteLine();
var len = args.Length;
string argument = string.Empty;
for (int i = 0; i < len; i++)
{
    argument += args[i];
}

Type[] methodTypes1 = new Type[]
    { };

Type[] methodTypes2 = new Type[]
    { typeof(string) };
MethodInfo Pack1 = ReflectionPackTestType.GetMethod("Pack1", methodTypes2);
Pack1.Invoke(instancia, new object[] { "bitch" });
if (!string.IsNullOrEmpty(argument))
{ Pack1.Invoke(instancia, new object[] { argument }); }

Type[] methodTypes3 = new Type[]
    { typeof(IList<Object>) };

MethodInfo Pack2 = ReflectionPackTestType.GetMethod("Pack1", methodTypes3);
Pack2.Invoke(instancia, new object[] { new List<Object> { "bitch" } });
//Console.Beep();
