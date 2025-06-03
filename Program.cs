using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__3_Metodos_y_Funciones
{
    internal class Program
    {
        private static double aumento = 0;
        private static int contOperarios = 0;
        private static int contTecnicos = 0;
        private static int conProfesionales = 0;
        private static double acumOperarios = 0;
        private static double acumTecnicos = 0;
        private static double acumProfesionales = 0;
        private static string continuar;
        private static string Acumular;
        private static string CalcularAumento;
        private static string CalcularSalarioBruto;





        public Program()
        {
        }

        static void Main(string[] args, string calcularSalarioBruto)
        {
            Console.Clear();
            Console.WriteLine("-----Registro de empleados-----");

            string cedula = SolicitarTexto("Ingrese la cedula: ");
            string nombre = SolicitarTexto("Ingrese el nombre del empleado: ");
            int tipoEmpleado = SolicitarTipoEmpleado();
            double horasLaborales = SolicitarNumero("Cantidad de horas laborales: ");
            double precioHora = SolicitarNumero("Precio por hora: ");

            double salarioOrdinario = CalcularSalarioOrdinario(horasLaborales, precioHora);
            double aumento = CalcularAumento(tipoEmpleado, (int)salarioOrdinario);
            double salarioBruto = CalcularSalarioBruto(salarioOrdinario: salarioOrdinario, aumento);
            double deduccion = salarioBruto * 0.0917;
            double salarioNeto = salarioBruto - deduccion;

            object value = MostrarDatosEmpleado(cedula, nombre, tipoEmpleado, horasLaborales, precioHora, salarioOrdinario, aumento, salarioBruto, deduccion, salarioNeto);
            Acumular(tipoEmpleado, salarioNeto);

            Console.WriteLine("\nDesea registrar otro empleado? (s/n)");
            continuar = Console.ReadLine().ToLower();

        }

        private static double CalcularSalarioBruto(double salarioOrdinario, double aumento)
        {
            throw new NotImplementedException();
        }

        private static object MostrarDatosEmpleado(string cedula, string nombre, int tipoEmpleado, double horasLaborales, double precioHora, double salarioOrdinario, double aumento, double salarioBruto, double deduccion, double salarioNeto)
        {
            throw new NotImplementedException();
        }

        private MostrarResumen();
        }

        static string SolicitarTexto(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        static double SolicitarNumero(string mensaje)
        {
            Console.WriteLine(mensaje);
            return double.Parse(Console.ReadLine());
        }

        static int SolicitarTipoEmpleado()
        {
            int tipo;
            do
            {
                Console.WriteLine("Ingrese el tipo de empleado (1: Operario, 2: Técnico, 3: Profesional):");
                tipo = int.Parse(Console.ReadLine());
            } while (tipo < 1 || tipo > 3);

            return tipo;
        }

        static double CalcularSalarioOrdinario(double horas, double precio)
        {
            return horas * precio;
        }

        private static double CalcularAumento(double salarioOrdinario, 
            int tipo)
        {
            switch (tipo)
            {
                case 1: return salarioOrdinario * 0.15;
                case 2: return salarioOrdinario * 0.10;
                case 3: return salarioOrdinario * 0.055;
                default: return 0;
            }
        }

        static void MostrarDatos(string cedula, string nombre, int tipo, double horas, double precio, double ordinario, double aumento, double bruto, double deduccion, double neto)
        {
            Console.WriteLine("\n-----Datos del empleado-----");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de empleado: {(tipo == 1 ? "Operario" : tipo == 2 ? "Técnico" : "Profesional")}");
            Console.WriteLine($"Horas laborales: {horas}");
            Console.WriteLine($"Precio por hora: {precio:C}");
            Console.WriteLine($"Salario ordinario: {ordinario:C}");
            Console.WriteLine($"Aumento: {aumento:C2}");
            Console.WriteLine($"Salario bruto: {bruto:C}");
            Console.WriteLine($"Deducción CCSS: {deduccion:C}");
            Console.WriteLine($"Salario neto: {neto:C}");
        }

        static void Acumular(int tipo, double salarioNeto)
        {
            switch (tipo)
            {
                case 1:
                    contOperarios++;
                    acumOperarios += salarioNeto;
                    break;
                case 2:
                    contTecnicos++;
                    acumTecnicos += salarioNeto;
                    break;
                case 3:
                    int contProfesionales = conProfesionales++;
                    acumProfesionales += salarioNeto;
                    break;
            }
        }

        static void MostrarResumen(int conProfesionales)
        {
            Console.WriteLine("\n-----Resumen-----");
            Console.WriteLine($"Total operarios: {contOperarios}, Monto acumulado: {acumOperarios:C}");
            Console.WriteLine($"Total técnicos: {contTecnicos}, Monto acumulado: {acumTecnicos:C}");
            Console.WriteLine(value: $"Total profesionales: {conProfesionales}, Monto acumulado: {acumProfesionales:C}");
        }
    }
}



