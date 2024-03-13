using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaListaConcatenata
{
    public class Nodo
    {
        public int Dato { get; set; }
        public Nodo Successivo { get; set; }
    }

    public class Pila
    {
        private Nodo testa;

        public Pila()
        {
            testa = null;
        }

        // PUSH
        public void InserisciInTesta(int dato)
        {
            Nodo nuovoNodo = new Nodo { Dato = dato, Successivo = testa };
            testa = nuovoNodo;
        }

        // POP
        public bool CancellaInTesta()
        {
            if (testa != null)
            {
                //Nodo temp = testa;
                testa = testa.Successivo;
                //temp = null;
                return true;
            }
            else
                return false;
        }
        public override string ToString()
        {
            String s = "";
            Nodo corrente = testa;
            while(corrente != null)
            {
                s += corrente.Dato + "\n";
                corrente = corrente.Successivo;
            }
            return s;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pila pila = new Pila();

            pila.InserisciInTesta(3);
            pila.InserisciInTesta(2);
            pila.InserisciInTesta(1);

            Console.WriteLine(pila);

            if (pila.CancellaInTesta())
                Console.WriteLine(pila);
            else
                Console.WriteLine("La pila è vuota.");
        }
    }
}
