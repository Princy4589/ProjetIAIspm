using System;
using System.Collections.Generic;

namespace IA
{
    class Program
    {
        //Simple fonction pour implication de deux booleen        
        public static bool implique(bool b1,bool b2){
            if(b1==true && b2==false){
                return false;
            }else
            {
                return true;
            }
        }


        //Ito ilay formule/calcule mila generen'ilay fonction an'i andy
        public static bool calculate(List<bool> b){

            return implique((b[0])||(b[1]) , (b[2])&&(implique(b[3],b[4])));

        }


        //Fenoina 0 aty alohan'ilay bas possible ra toa ka tsy ampy p.Length
        public static string addO(int x,string t){
            string text = t;
            for (int i = 0; i < x; i++)
            {
                text = "0" + text;
            }
            return text;
        }
        

        //Avadika tableau ana tableau ana booleen ilay tableau ana string
        public static List<bool> boolTab(string s){
            List<bool> result = new List<bool>();
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == '0'){
                    result.Add(false);

                }else
                {
                    result.Add(true);
                }
            }
            return result;
        }




        static void Main(string[] args)
        {
            //
            // ──────────────────────────────────────────────────
            //   Debut du programme
            //      Principe : [Cas possible en int] => [Cas possible en Boolean] => [Cas possible en proposition]
            //      Mbola mila opimisena ilay code dia iintegrena ilay fonction mamadika an'ilay texte ana hypothese
            //      ho lasa formule 
            // ──────────────────────────────────────────────────
            //

            

            //
            // ───────────────────────────────────────────────────────────────
            // ny variable propsIndex(Index misy ilay proposition atao demonstration) 
            // sy propsNegation(valeur de negation anilay proposition an'ny utilisateur)
            // Proposition à tester : Il n'y a pas de remboursement


            int propsIndex = 4;
            bool propsNegation = false;

            //
            // ───────────────────────────────────────────────────────────────
            //Declaration ny proposition rehetra anaty hypothese
            //    
                
            List<Props> p = new List<Props>();
            p.Add(new Props("Le groupe ne sait pas jouer du rock"));
            p.Add(new Props("Les boissons ne sont pas livré à temps"));
            p.Add(new Props("Noro est triste"));
            p.Add(new Props("La fete des fin d'annés sont annulé"));
            p.Add(new Props("Il y a remboursement"));


            //
            // ───  ────────────────────────────────────────────────────────────
            //Variable micontenir ny cas de negation possible rehetra
            List<List<bool>> bruteforce = new List<List<bool>>();
            /*
                00000
                00001
                00010
                00011
                00100
                00101
                00110
                00111
                01000
                01001
                01010
                01011
                01100
                01101
                01110
                01111
                10000
                10001
                10010
                10011
                10100
                10101
                10110
                10111
                11000
                11001
                11010
                11011
                11100
                11101
                11110
                11111
            */

            //
            // ───  ────────────────────────────────────────────────────────────
            //Generation d'une tableau de tableau de boolean contenant tout les cas de negation possible
            for (int i = 0; i < Math.Pow(2 , p.Count); i++)
            {
                List<bool> tmp = boolTab(addO(p.Count-Convert.ToString(i,2).Length,Convert.ToString(i,2)));
                bruteforce.Add(tmp);
            }



            //
            // ───  ────────────────────────────────────────────────────────────
            //On Fixe toutes les (propsIndex)ème booleen du bruteforce à propsNegation
            for (int i = 0; i < bruteforce.Count; i++)
            {
                bruteforce[i][propsIndex] = propsNegation;
            }


            //
            // ───  ────────────────────────────────────────────────────────────
            //Nombre des cas possible
            int cas = 0;
            System.Console.WriteLine("Liste des instruction vraie");


            //
            // ───  ────────────────────────────────────────────────────────────
            //Parcourir toute les cas et prendre ce qui est vraie
            foreach (var item in bruteforce)
            {
                if(calculate(item)){ //Si la combinaison est vraie
                    
                    cas++; //Mazava oazy

                    System.Console.WriteLine("Cas "+cas+" si "+p[propsIndex].showIf(propsNegation));
                    for (int i = 0; i < item.Count; i++)
                    {
                        if (i != propsIndex)
                        {
                            System.Console.WriteLine("===>"+p[i].showIf(item[i])); // la methode showIf à voir dans la class Props
                        }
                    }
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
