using System;

namespace IA
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string hypo = "Si marie va au marché alors les enfants vont à l'ecole.si les enfants ne vont pas à l'ecole alors c'est dimanche";
            
            Hypothese h = new Hypothese(hypo);

        }
    }
}

/*
    Si je suis un homme alors je suis mortelle.Fitiavana n'est pas mortelle.
    string hypothese = "Si je suis un homme alors je suis mortelle.Fitiavana n'est pas mortelle";
            string[] hypotheses = hypothese.Split(".");
            Console.WriteLine(hypotheses.Length);

    p -> q
    q -> s
    s -> t

    7t
*/
