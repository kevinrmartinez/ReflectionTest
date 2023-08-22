// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

string dllPath = @"C:\Users\force\source\C#\ReflectionTest\ReflectionPackTest\bin\Debug\net7.0\ReflectionPackTest.dll";

Assembly assembly = Assembly.LoadFrom(dllPath);
Type type = assembly.GetType("ReflectionPackTest.Pack");

object instancia = Activator.CreateInstance(type);
MethodInfo[] Pack = type.GetMethods();

for (int i = 0; i < Pack.Length; i++)
{
    Console.WriteLine(Pack[i].ToString());
}
Console.WriteLine();


Type[] methodTypes1 = new Type[]
    { };
Type[] methodTypes2 = new Type[]
    { typeof(string) };
Type[] methodTypes3 = new Type[]
    { typeof(IList<Object>) };
MethodInfo Pack1 = type.GetMethod("Pack1", methodTypes3);
Pack1.Invoke(instancia, new object[] { new List<Object> { "bitch" } });
Console.Beep();
