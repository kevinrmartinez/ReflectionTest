namespace ReflectionPackTest
{
    public class Pack
    {
        public static void Pack1()
        {
            Console.WriteLine("Cargado exitosamente");
        }

        public static void Pack1(string S) 
        {
            Console.WriteLine(S);
            Console.WriteLine("Cargado exitosamente");
        }

        public static void Pack1(IList<Object> objects)
        {
            Console.WriteLine(objects[0].ToString());
            Console.WriteLine("Cargado exitosamente");
        }
    }
}