using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
namespace Inscripción
{
    class Program
    {
        static void Main(string[] args)
        {
            //B1: para crear una persona necesitas una direccion , y para agregar una direccion se necesita a una persona 
            Assembly Muni = Assembly.LoadFile("C:\\Users\\ING\\Desktop\\municipality-library-Japalominos\\ClassLibrary1.dll");
            Type[] MuniType1 = Muni.GetTypes();
            string cb = "";          
            foreach (Type MuniType in MuniType1)
            {
                PropertyInfo[] MuniProp = MuniType.GetProperties();
                MethodInfo[] MuniMet = MuniType.GetMethods();
                cb += ("========================================\n");
                cb += (String.Format("Type Name: {0}\n", MuniType.Name));
                if (MuniType.IsClass)
                    cb += "Class\n";
                foreach (PropertyInfo property in MuniProp)
                {

                    cb += ("========================================\n");
                    cb += (string.Format("Property Name: {0}\n", property.Name));
                    cb += ("========================================\n");
                    cb += (string.Format("Property Type Name: {0}\n", property.PropertyType.Name));
                    cb += (string.Format("Property Type Full Name: {0}\n", property.PropertyType.FullName));
                    cb += (string.Format("Can we read the property?: {0}\n", property.CanRead.ToString()));
                    cb += (string.Format("Can we write the property?: {0}\n", property.CanWrite.ToString()));
                }
                cb += ("========================================\n");
                foreach (MethodInfo method in MuniMet)
                {
                    try
                    {
                        cb += (String.Format("Method info: {0}\n", MuniType.GetMethod(method.Name)));
                        cb += ("***\n");
                    }
                    catch { }

                }
            }
            


            Console.WriteLine(cb);
            Console.ReadKey();
        }
    }
}
