using System;

namespace IA
{
    static class Operation
    {
        public static void calc(Props p1,char connector,Props p2){
            switch (connector)
            {
                /*
                
                */
                case '+':
                System.Console.WriteLine(p1.ToString()+ " + " +p2.ToString()+" = " + (p1.negation|p2.negation));
                break;
                    
                case '*':
                System.Console.WriteLine(p1.ToString()+ " * " +p2.ToString()+" = " + (p1.negation&p2.negation));
                break;
                case '<':{
                    if( p1.negation == true && p2.negation==false){
                        System.Console.WriteLine(p1.ToString()+ " -> " +p2.ToString()+" = " + false);
                    }
                    else{
                        System.Console.WriteLine(p1.ToString()+ " -> " +p2.ToString()+" = " + true);
                      
                    }
                    break;
                }


            }
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
