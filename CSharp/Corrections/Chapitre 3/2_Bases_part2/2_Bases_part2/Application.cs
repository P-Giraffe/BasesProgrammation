using System;

public class Application
{
    public void fonctionPrincipale()
    {
        //DEBUT de votre programme

        //Exercice 1 : Moyenne
        int nbNotes = 0;
        do
        {
            Console.WriteLine("Combien de notes ?");
            nbNotes = Utilisateur.saisirEntier();
        } while (nbNotes <= 0);

        double somme = 0;
        double note;
        for (int numNote = 1; numNote <= nbNotes; numNote++)
        {
            Console.WriteLine("Entrez la note " + numNote);
            note = Utilisateur.saisirReel();
            somme = somme + note;
        }

        Console.WriteLine("La moyenne est de " + (somme / nbNotes));

        //Exercice 2 : Factorielle
        Console.WriteLine("Quelle factorielle voulez-vous calculer ?");
        int n = Utilisateur.saisirEntier();
        long resultat = 1;

        for (int i = 1; i <= n; i++)
        {
            resultat = resultat * i;
        }
        Console.WriteLine("La factorielle de " + n + " est " + resultat);

		//Exercice 3 : Nombre Mystère
        var generateur = new Random();
        int nombreAleatoire = 0;

        nombreAleatoire = generateur.Next(1, 100);
        int nombreUtilisateur = 0;
        int nombreEssais = 0;
        do
        {
            Console.WriteLine("Combien vaut le nombre mystere ?");
            nombreUtilisateur = Utilisateur.saisirEntier();
            nombreEssais++;
            if (nombreUtilisateur < nombreAleatoire)
            {
                Console.WriteLine("C'est plus");
            }
            else if (nombreUtilisateur > nombreAleatoire)
            {
                Console.WriteLine("C'est moins");
            }
        } while (nombreAleatoire != nombreUtilisateur);

        Console.WriteLine("Bravo! Vous avez trouvé en " + nombreEssais + " essai(s)");


		//Exercice 4 : Jeu de Nim
        int nbAllumettes = 20;
        string joueurEnCours;
        string prochainJoueur = "Joueur 1";

        do
        {
            joueurEnCours = prochainJoueur;
            for (int i = 0; i < nbAllumettes; i++)
            {
                Console.Write("| ");
            }
            Console.WriteLine(" Il reste " + nbAllumettes + " allumette(s)");

            int saisieUtilisateur;
            do
            {
                Console.WriteLine(joueurEnCours + ": prenez entre 1 et 3 allumette(s)");
                saisieUtilisateur = Utilisateur.saisirEntier();
            } while (saisieUtilisateur < 1 || saisieUtilisateur > 3);


            nbAllumettes = nbAllumettes - saisieUtilisateur;

            if (joueurEnCours == "Joueur 1")
            {
                prochainJoueur = "Joueur 2";
            }
            else
            {
                prochainJoueur = "Joueur 1";
            }
        } while (nbAllumettes != 0);

        Console.WriteLine("Le " + prochainJoueur + " a gagné");
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


