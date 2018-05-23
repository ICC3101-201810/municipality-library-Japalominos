using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
using ClassLibrary1;
namespace Inscripción
{
    class Program
    {
        static void Main(string[] args)
        {
       


            Console.WriteLine("Ingrese el nombre de la persona:");
            string n = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido de la persona:");
            string a = Console.ReadLine();
            Console.WriteLine("Ingrese el rut de la persona:");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese el año de nacimiento de la persona:");
            int ano1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de nacimiento de la persona:");
            int mes1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el dia de nacimiento de la persona:");
            int dia1 = Convert.ToInt32(Console.ReadLine());
            DateTime i = new DateTime(ano1, mes1, dia1);
            Person p1 = new Person(n, a, i, null, rut, null, null);
            Console.WriteLine("Nombre de la persona: " + p1.First_name);
            Console.WriteLine("Apellido de la persona: " + p1.Last_name);
            Console.WriteLine("Rut de la persona: " + p1.Rut);
            Console.WriteLine("Fecha de Nacimiento de la persona: " + p1.Birth_date);
            Console.WriteLine("Quiere cambiar el nombre: Escriba si o no:");
            string dec1 = Console.ReadLine();
            if (dec1 == "si")
            {
                Console.WriteLine("Ingrese el nuevo nombre:");
                string nn = Console.ReadLine();
                p1.changeFirstName(nn);
            }
            Console.WriteLine("Quiere cambiar el apellido: Escriba si o no:");
            string dec2 = Console.ReadLine();
            if (dec2 == "si")
            {
                Console.WriteLine("Ingrese el nuevo apellido:");
                string na = Console.ReadLine();
                p1.changeLastName(na);

            }
            Console.WriteLine("La persona fue abandonada?, Escriba si o no");
            string dec3 = Console.ReadLine();
            if (dec3 == "si")
            {
                p1.getAbandoned();
            }
            Console.WriteLine("La persona tiene Alma Mater y Grado Profesional?, Escriba si o no");
            string dec4 = Console.ReadLine();
            if (dec4 == "si")
            {
                Console.WriteLine("Ingrese el Alma Mater de la persona:");
                string alma = Console.ReadLine();
                Console.WriteLine("Ingrese el Grado Profesional de la persona:");
                string grado = Console.ReadLine();

                p1.setEducation(alma, grado);

            }
            Console.WriteLine("Ingrese marca del Auto: ");
            string ma = Console.ReadLine();
            Console.WriteLine("Ingrese modelo del Auto: ");
            string mo = Console.ReadLine();
            Console.WriteLine("Ingrese año del Auto: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese placa del Auto: ");
            string p = Console.ReadLine();
            Console.WriteLine("Ingrese número de cinturones de seguridad del Auto: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si el auto es diesel");
            string dec5 = Console.ReadLine();
            bool d;
            if (dec5 == "1")
            {
                d = true;
            }
            else
            {
                d = false;
            }
            Car c1 = new Car(ma, mo, ano, p1, p, c, d);
            Console.WriteLine("Marca del auto: " + c1.Brand);
            Console.WriteLine("Es diesel: " + c1.Diesel);
            Console.WriteLine("La placa es: " + c1.License_plate);
            Console.WriteLine("El modelo es: " + c1.Model);
            Console.WriteLine("Cantidad de cinturones: " + c1.Seatbelts);
            Console.WriteLine("Año del auto: " + c1.Year);
            Console.ReadKey();

            Console.WriteLine("Ingrese la calle de la casa: ");
            string ca = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de la casa: ");
            int nuca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la comuna de la casa: ");
            string comca = Console.ReadLine();
            Console.WriteLine("Ingrese la ciudad de la casa: ");
            string cica = Console.ReadLine();
            Console.WriteLine("Ingrese el año de construccion de la casa: ");
               int anoca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de habitaciones de la casa: ");
            int haca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de baños de la casa: ");
            int baca = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese 1 si tiene patio: ");
            string dec6 = Console.ReadLine();
            bool paca;
            if (dec6 == "1")
            {
                paca = true;
            }
            else
            {
                paca = false;
            }
            Console.WriteLine("Ingrese 1 si tiene piscina: ");
            string dec7 = Console.ReadLine();
            bool pica;
            if (dec7 == "1")
            {
                pica = true;
            }
            else
            {
                pica = false;
            }
            Address a1 = new Address(ca, nuca, comca, cica, p1, anoca, haca, baca, paca, pica);
            Console.WriteLine("La calle de la casa es: " + a1.Street);
            Console.WriteLine("El número de la casa es: " + a1.Number);
            Console.WriteLine("La comuna en que se encuentra la casa es: " + a1.Commune);
            Console.WriteLine("La ciudad en que se encuentra la casa es: " + a1.City);
            Console.WriteLine("El año de construcción de la casa es: " + a1.Year_of_contruction);
            Console.WriteLine("El numero de habitación que tiene la casa son: " + a1.Bedrooms);
            Console.WriteLine("El numero de baños que tiene la casa son: " + a1.Bathrooms);
            Console.WriteLine("Tiene Patio: " + a1.Backyard);

            Console.WriteLine("¿Quiere añadir mas habitaciones a la casa?, ingrese si , o no: ");
            string dec8 = Console.ReadLine();
            if (dec8 == "si")
            {
                Console.WriteLine("Cuantas piezas quiere añadir: ");
                int ndn= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a1.addBeedrooms(ndn));
            }
            Console.WriteLine("¿Quiere añadir mas baños a la casa?, ingrese si , o no: ");
            string dec9 = Console.ReadLine();
            if (dec9 == "si")
            {
                Console.WriteLine("Cuantas piezas quiere añadir: ");
                int nbn = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a1.addBathrooms(nbn));
            }
        }
            
        
        
    }
}
