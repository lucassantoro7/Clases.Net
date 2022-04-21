namespace HelloWorld
{
    class Program
    {
        static void Main()
        {

        }

        public class Banco
        {
            public string Titular { get; set; } // "Lucas santoro"
            public string Tipo { get; set; } // "Caja ahorro"
            public double Saldo { get; set; } // 1234,2
            public int CantidadCuentas { get; set; } // 2
            public bool IstaActivo { get; set; } //true / false (a nivel de base de datos 1/0
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