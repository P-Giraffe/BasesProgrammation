using System;

public class Application
{
    public void fonctionPrincipale()
    {
        //DEBUT de votre programme
		exercice2();
        //FIN de votre programme
    }

    //DECLAREZ VOS FONCTIONS EN DESSOUS DE CETTE LIGNE

    bool estPaire(int a)
    {
        bool aEstPaire;

        if (a % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

        return aEstPaire;
    }

    void exercice1()
    {
        int val1, val2;
        Console.WriteLine("Veuillez entrer le nombre 1 : ");
        val1 = Utilisateur.saisirEntier();

        Console.WriteLine("Veuillez entrer le nombre 2 : ");
        val2 = Utilisateur.saisirEntier();

        Console.Write("La première valeur saisie (" + val1 + ",");
        if (estPaire(val1) == true)
        {
            Console.Write("paire");
        }
        else
        {
            Console.Write("impaire");
        }

        Console.Write(") est plus ");

        if (val1 > val2)
        {
            Console.Write("grande");
        }
        else
        {
            Console.Write("petite");
        }

        Console.Write(" que la seconde (" + val2 + ",");
        if (estPaire(val2) == true)
        {
            Console.Write("paire");
        }
        else
        {
            Console.Write("impaire");
        }

        Console.WriteLine(")\n");

    }

    void exercice2()
    {
        int lePlusGrand = lePlusGrandDesDeux(2, 8);
        Console.WriteLine(lePlusGrand + " devrait etre 8");

        lePlusGrand = lePlusGrandDesDeux(20, 8);
        Console.WriteLine(lePlusGrand + " devrait etre 20");

        lePlusGrand = lePlusGrandDesTrois(2, 5, 9);
        Console.WriteLine(lePlusGrand + " devrait etre 9");

        lePlusGrand = lePlusGrandDesTrois(2, -5, -9);
        Console.WriteLine(lePlusGrand + " devrait etre 2");

        lePlusGrand = lePlusGrandDesTrois(0, 5, 0);
        Console.WriteLine(lePlusGrand + " devrait etre 5");
    }

    int lePlusGrandDesDeux(int a, int b)
    {
        int lePlusGrand;

        if (b > a)
        {
            lePlusGrand = b;
        }
        else
        {
            lePlusGrand = a;
        }

        return lePlusGrand;
    }

    int lePlusGrandDesTrois(int a, int b, int c)
    {
        int resultat = lePlusGrandDesDeux(a, b);
        resultat = lePlusGrandDesDeux(resultat, c);
        return resultat;
    }

    void afficheEspaces(int nbEspaces)
    {
        for (int i = 0; i < nbEspaces; i++)
        {
            Console.Write("  ");
        }
    }

    int obtenirUniteDuNombre(int nbre)
    {
        int resultat = nbre % 10;
        return resultat;
    }

    void afficheNombresCroissants(int nbre)
    {
        for (int i = nbre; i <= (2 * nbre) - 1; i++)
        {
            int uniteNombre = obtenirUniteDuNombre(i);
            Console.Write(uniteNombre + " ");
        }
    }

    void afficheNombresDecroissants(int nbre)
    {
        for (int i = 2 * (nbre - 1); i >= nbre; i--)
        {
            int uniteNombre = obtenirUniteDuNombre(i);
            Console.Write(uniteNombre + " ");
        }
    }

    void pyramide()
    {
        for (int lignePyramide = 1; lignePyramide <= 10; lignePyramide++)
        {
            afficheEspaces(10 - lignePyramide);
            afficheNombresCroissants(lignePyramide);
            afficheNombresDecroissants(lignePyramide);
            Console.WriteLine();
            Console.WriteLine();
        }
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


