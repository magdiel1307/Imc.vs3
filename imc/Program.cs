using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proporcione el peso en kilogramos de la persona:");
            var pesoComoTexto = Console.ReadLine();
            decimal peso = Convert.ToDecimal(pesoComoTexto);

            Console.WriteLine("Proporcione la altura en metros de la persona:");
            var estaturaComoTexto = Console.ReadLine();
            decimal estatura = Convert.ToDecimal(estaturaComoTexto);

            // Calcular IMC
            decimal imc = peso / (estatura * estatura);

            // Mostrar resultado
            Console.WriteLine($"\nEl IMC de la persona es: {imc:F2}");

            // Determinar estado nutricional
            string estado;
            if (imc < 18.5m)
                estado = "Bajo peso";
            else if (imc < 25m)
                estado = "Peso normal";
            else if (imc < 30m)
                estado = "Sobrepeso";
            else
                estado = "Obesidad";

            Console.WriteLine($"Estado nutricional: {estado}");
        }
    }
}
