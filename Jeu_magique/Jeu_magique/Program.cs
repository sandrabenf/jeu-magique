// See https://aka.ms/new-consusing System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Jeu_magique // Note: actual namespace depends on the project name.
{
    internal class Program
    
    {
        static int demandernombre(int min, int max)
        {
            int nbr = -1;
            Console.Write($"Quelle est votre proposition (entre {min} et {max}) ?");
            try
            {
                nbr = int.Parse(Console.ReadLine());
                return nbr;
            }
            catch
            {
                Console.WriteLine("Valeur incorrecte!");
            }
            Console.ReadLine();
            return nbr;
        }




        static void Main()

        {
            const int MAX_COUP = 4;
            const int MAX_VALUE = 10;

            Random random = new Random();
            int nombre = random.Next(1, 11);
            int nombreChoisi = 0;

            Console.WriteLine("Trouvez le nombre entre 1 et 10");

            int nbCoup = 1;

            while ((nombreChoisi != nombre) && (nbCoup <= MAX_COUP))
            {

                nbJoueur = demandernombre(1, MAX_VALUE);
                    {
                        Console.WriteLine("Veuillez entrer un nombre entre 1 et 10.");
                    }
                    else
                    {
                        if (nombreChoisi < nombre)
                        {
                            Console.WriteLine("Le nombre recherché est plus grand.");
                        }
                        else if (nombreChoisi > nombre)
                        {
                            Console.WriteLine("Le nombre recherché est plus petit.");
                        }
                        else
                        {
                            Console.WriteLine("Bravo ! Vous avez trouvé le nombre !");
                        }
                        nbCoup++;
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre valide.");
                }
            } //end while
            Console.WriteLine($"Le nombre recherché était : {nombre} ");
        }// Fin programme 
    }
    
}