using System;

public class Application
{
    void dessinerCarre(int taille, String pixel) {
        for (int numLigne = 1; numLigne <= taille; numLigne++)
        {
            for (int numColonne = 1; numColonne <= taille; numColonne++)
            {
                Console.Write(pixel);
            }

            // sauter une ligne
            Console.WriteLine();
        }
    }

    double calculePuissance(double nombre, int puissance) {
        double resultat = 1;
        for(int etape=0; etape < puissance; etape = etape + 1) {
            resultat = resultat * nombre;
        }
        return resultat;
    }


    public void fonctionPrincipale()
    {
        //DEBUT de votre programme
        Console.WriteLine("Entrez la valeur de départ :");
        double valeurUtilisateur = Utilisateur.saisirReel();
        double resultatCalcul;
        resultatCalcul = calculePuissance(valeurUtilisateur,3);
        resultatCalcul = resultatCalcul + 10;
        resultatCalcul = calculePuissance(resultatCalcul,2);
        Console.WriteLine("Voici le résultat de votre calcul : " + resultatCalcul);
        Utilisateur.saisirTexte();
        //FIN de votre programme
    }



    //DECLAREZ VOS FONCTIONS EN DESSOUS DE CETTE LIGNE

    /* EXEMPLES DE PROCEDURES ET FONCTIONS :
	
		void uneProcedure(int param1, int param2)
		{
			Console.WriteLine(param1+param2);
		{
		
		int uneFonction(int param1, int param2)
		{
			int resultat = 0;
			resultat = param1 + param2;
			return resultat;
		}
		
		
		*/

    //NE PAS TOUCHER LE CODE EN DESSOUS DE CETTE LIGNE
}


