package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

public class Application {
    public void fonctionPrincipale() {
        //Exemple d'utilisation
    }

    void exercice1()
    {
        System.out.println("Entrez les dimensions des 2 cotés :");
        double valeur1 = ConsoleReader.readDouble("côté 1");
        double valeur2 = ConsoleReader.readDouble("côté 2");
        pythagore(valeur1, valeur2);
    }

    void pythagore(double coteA, double coteB)
    {
        double carreHyp = coteA * coteA + coteB * coteB;
        double hypothenuse = Math.sqrt(carreHyp);
        System.out.println("L'hypothénuse vaut " + hypothenuse);
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
            System.out.println("Saisissez une valeur");
            saisieUtilisateur = ConsoleReader.readInt("");
            if (saisieUtilisateur != 0)
            {
                compteur++;
                if (saisieUtilisateur % diviseur == 0)
                {
                    compteurDivisibles++;
                }
            }

        } while (saisieUtilisateur != 0);
        System.out.println("Vous avez entré " + compteur + " valeur" + (compteur > 1 ? "s" : "") + " dont " + compteurDivisibles + " divisible(s) par 7");
    }

    void exercice3()
    {
        multiplication(4);
    }

    void multiplication(int n)
    {
        for (int numLigne = 1; numLigne <= n; numLigne++)
        {
            for (int numColonne = 1; numColonne <= n; numColonne++)
            {
                System.out.print(numLigne * numColonne + "  ");
            }

            System.out.println();
        }
    }

    void exercice4()
    {
        int nb = ConsoleReader.readInt("Somme à cibler");
        sommeProche(nb);
    }

    void sommeProche(int cible) {

        int nbAdditionne = 1;
        int somme = 0;

        while (somme < cible) {
            somme = somme + nbAdditionne;
            if (nbAdditionne > 1)
            {
                System.out.print(" + ");
            }
            System.out.print(nbAdditionne);
            nbAdditionne++;
        }
        if (somme != cible) {
            nbAdditionne--;
            int ecartActuel = Math.abs(somme - cible);
            int precedentEcart = cible - (somme - nbAdditionne);

            if (ecartActuel >= precedentEcart) {
                somme = somme - nbAdditionne;
            }
        }
        System.out.println(" = " + somme);
    }

    boolean estPaire(int a)
    {
        boolean aEstPaire;

        if (a % 2 == 0)
        {
            aEstPaire = true;
        }
        else
        {
            aEstPaire = false;
        }

        return aEstPaire;
    }

    void exercice5()
    {
        int val1, val2;
        System.out.println("Veuillez entrer le nombre 1 : ");
        val1 = ConsoleReader.readInt("");

        System.out.println("Veuillez entrer le nombre 2 : ");
        val2 = ConsoleReader.readInt("");

        System.out.print("La première valeur saisie (" + val1 + ",");
        if (estPaire(val1) == true)
        {
            System.out.print("paire");
        }
        else
        {
            System.out.print("impaire");
        }

        System.out.print(") est plus ");

        if (val1 > val2)
        {
            System.out.print("grande");
        }
        else
        {
            System.out.print("petite");
        }

        System.out.print(" que la seconde (" + val2 + ",");
        if (estPaire(val2) == true)
        {
            System.out.print("paire");
        }
        else
        {
            System.out.print("impaire");
        }

        System.out.println(")\n");

    }

    void exercice6()
    {
        int lePlusGrand = lePlusGrandDesDeux(2, 8);
        System.out.println(lePlusGrand + " devrait etre 8");

        lePlusGrand = lePlusGrandDesDeux(20, 8);
        System.out.println(lePlusGrand + " devrait etre 20");

        lePlusGrand = lePlusGrandDesTrois(2, 5, 9);
        System.out.println(lePlusGrand + " devrait etre 9");

        lePlusGrand = lePlusGrandDesTrois(2, -5, -9);
        System.out.println(lePlusGrand + " devrait etre 2");

        lePlusGrand = lePlusGrandDesTrois(0, 5, 0);
        System.out.println(lePlusGrand + " devrait etre 5");
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
            System.out.print("  ");
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
            System.out.print(uniteNombre + " ");
        }
    }

    void afficheNombresDecroissants(int nbre)
    {
        for (int i = 2 * (nbre - 1); i >= nbre; i--)
        {
            int uniteNombre = obtenirUniteDuNombre(i);
            System.out.print(uniteNombre + " ");
        }
    }

    void pyramide()
    {
        for (int lignePyramide = 1; lignePyramide <= 10; lignePyramide++)
        {
            afficheEspaces(10 - lignePyramide);
            afficheNombresCroissants(lignePyramide);
            afficheNombresDecroissants(lignePyramide);
            System.out.println();
            System.out.println();
        }
    }
}
