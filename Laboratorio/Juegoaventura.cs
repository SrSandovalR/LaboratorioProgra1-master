using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio
{
    internal class Juegoaventura
    {

        public static void saludo()
        {
            Console.WriteLine("Hi Gamer:");
        }


        public void IniciarPartida()
        {
            jugando = true;
            Console.WriteLine("¡Partida iniciada!");
        }

        public void DetenerPartida()
        {
            // Error lógico
            jugando = false;//faltaba el false de jugando para indicar de que termino.
            Console.WriteLine("Partida detenida.");
        }

    }
}
