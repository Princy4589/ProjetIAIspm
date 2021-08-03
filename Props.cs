using System;

namespace IA
{
    class Props
    {
        public string value{get;set;}
        public bool negation{get;set;}

        public Props(string value , bool negation = true){
            this.value = value;
            this.negation = this.value.Contains("ne ") || this.value.Contains("n'");
        }

        public string showIf(bool t){
            return this.str(t);
        }

        public string str(bool t){
            return !t?"Fausse => "+"("+this.value+")":"("+this.value+")";
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
