using Newtonsoft.Json;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Banco banco = new Banco();


            Console.WriteLine("Ingrese nombre del Titular: ");
            banco.Titular = Console.ReadLine();

            Console.WriteLine("Ingrese Tipo de cuenta: ");
            banco.Tipo = Console.ReadLine();

            Console.WriteLine("Ingrese cantidad de Saldo: ");
            banco.Saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese Cantidad de Cuentas: ");
            banco.CantidadCuentas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese si esta activa: ");
            banco.EstaActivo = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Ingrese sexo del Titular: ");
            banco.Sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese Id de Sucursal: ");
            banco.Sucursal.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nombre de la Sucursal: ");
            banco.Sucursal.Nombre = Console.ReadLine();


            Console.WriteLine(JsonConvert.SerializeObject(banco));


        }

        public class Banco
        {
            public Banco ()
            {
                this.Sucursal = new Sucursal();
            }

            public string Titular { get; set; } // "Lucas santoro"
            public string Tipo { get; set; } // "Caja ahorro"
            public double Saldo { get; set; } // 1234,2
            public int CantidadCuentas { get; set; } // 2
            public bool EstaActivo { get; set; } //true / false (a nivel de base de datos 1/0
            public char Sexo { get; set; } // 'F'/'M'
            public Sucursal Sucursal { get; set; }
        }
    }

    public class Sucursal
    {
        public int Id { get; set; } //tener en cuenta que el id puede ser int o string (GUID)
        public string Nombre { get; set; } //Suc. Devoto
    }
}