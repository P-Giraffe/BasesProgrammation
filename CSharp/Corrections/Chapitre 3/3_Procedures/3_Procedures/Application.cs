using System;

public class Application
{
    public void fonctionPrincipale()
    {
        //DEBUT de votre programme

		int a = 10;
        int b = a++ + ++a;
        int c = a + b;
        Console.WriteLine(c);
        //FIN de votre programme
    }

    //DECLAREZ VOS FONCTIONS EN DESSOUS DE CETTE LIGNE

    void exercice1()
    {
        Console.WriteLine("Entrez les dimensions des 2 cotés :");
        double valeur1 = Utilisateur.saisirReel();
        double valeur2 = Utilisateur.saisirReel();
        pythagore(valeur1, valeur2);
    }

    void pythagore(double coteA, double coteB)
    {
        double carreHyp = coteA * coteA + coteB * coteB;
        double hypothenuse = Math.Sqrt(carreHyp);
        Console.WriteLine("L'hypothénuse vaut " + hypothenuse);
    }

    void exercice2()
    {
        demandeValeurs(7);
        demandeValeurs(4);
        demandeValeurs(2);
    }

    void demandeValeurs(int diviseur)
    {
        int compteur = 0;
        int compteurDivisibles = 0;
        int saisieUtilisateur;
        do
        {
            Console.WriteLine("Saisissez une valeur");
            saisieUtilisateur = Utilisateur.saisirEntier();
            if (saisieUtilisateur != 0)
            {
                compteur++;
                if (saisieUtilisateur % diviseur == 0)
                {
                    compteurDivisibles++;
                }
            }

        } while (saisieUtilisateur != 0);
        Console.WriteLine("Vous avez entré " + compteur + " valeur" + (compteur > 1 ? "s" : "") + " dont " + compteurDivisibles + " divisible(s) par 7");
    }

    void exercice3()
    {
        int dimension = Utilisateur.saisirEntier();
        multiplication(dimension);

        multiplication(4);
    }

    void multiplication(int n)
    {
        for (int numLigne = 1; numLigne <= n; numLigne++)
        {
            for (int numColonne = 1; numColonne <= n; numColonne++)
            {
                Console.Write(numLigne * numColonne + "  ");
            }

            Console.WriteLine();
        }
    }

    void exercice4()
    {
        sommeProche(10);
        Console.WriteLine("devrait être 10");
        
        sommeProche(11);
        Console.WriteLine("devrait être 10");

        sommeProche(14);
        Console.WriteLine("devrait être 15");

        sommeProche(18);
        Console.WriteLine("devrait être 15");
    }



    void sommeProche(int sommeVoulue) {
        int somme = 0;
        int compteur = 0;
        while (somme < sommeVoulue) {
            compteur++;
            somme = somme + compteur;
        }
        int ecartCourant = somme - sommeVoulue;
        int ecartPrecedent = sommeVoulue - (somme - compteur);
        if (ecartPrecedent <= ecartCourant) {
            somme = somme - compteur;
        }
        Console.WriteLine(somme);
    }

    void sommeProche_v2(int sommeVoulue) {
        int ecart = sommeVoulue;
        int ecartPrecedent = 0;
        int nbAdditionne = 1;
        int somme = 0;
        bool meilleurEcartTrouve = false;

        do
        {
            ecartPrecedent = ecart;
            somme = somme + nbAdditionne;
            ecart = Math.Abs(sommeVoulue - somme);
            meilleurEcartTrouve = ecart < ecartPrecedent;
            if (meilleurEcartTrouve == false)
            {
                somme = somme - nbAdditionne;
            }
            nbAdditionne++;
        } while (meilleurEcartTrouve == true);
        Console.WriteLine(somme);
    }

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


