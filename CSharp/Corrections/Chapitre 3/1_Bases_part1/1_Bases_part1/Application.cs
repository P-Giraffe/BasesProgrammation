using System;

public class Application
{
    public void fonctionPrincipale()
    {
        //DEBUT de votre programme
        //Exercice 1

        String prenom;
        Console.WriteLine("Entrez votre prénom : ");
        prenom = Utilisateur.saisirTexte();
        Console.WriteLine("Bonjour " + prenom + " !");


        //Exercice 2
        double somme = 0, note1, note2, note3;
        Console.WriteLine("Entrez la note 1");
        note1 = Utilisateur.saisirReel();
        Console.WriteLine("Entrez la note 2");
        note2 = Utilisateur.saisirReel();
        Console.WriteLine("Entrez la note 3");
        note3 = Utilisateur.saisirReel();
        somme = note1 + note2 + note3;
        Console.WriteLine("La moyenne est de " + (somme / 3));


        //Exercice 2 - Autre version
        const int NB_NOTES = 3;
        double sommeNotes = 0, note;
        for (int numNote = 1; numNote <= NB_NOTES; numNote++)
        {
            Console.WriteLine("Entrez la note " + numNote);
            note = Utilisateur.saisirReel();
            sommeNotes = sommeNotes + note;
        }

        Console.WriteLine("La moyenne est de " + (somme / NB_NOTES));


        //Exercice 3
        double baseTriangle, hauteurTriangle;
        Console.WriteLine("Entrez la base : ");
        baseTriangle = Utilisateur.saisirReel();
        Console.WriteLine("Entrez la hauteur : ");
        hauteurTriangle = Utilisateur.saisirReel();
        double aire = baseTriangle * hauteurTriangle / 2;
        Console.WriteLine("L'aire vaut " + aire);



        //Exercice 4
        double rayon;
        const double PI = 3.14159265;

        Console.WriteLine("Entrez le rayon : ");
        rayon = Utilisateur.saisirReel();
        Console.WriteLine("L'aire vaut " + (PI * rayon * rayon));


        //Exercice 5
        Console.WriteLine("Taille du carré à dessiner ?");
        int taille = Utilisateur.saisirEntier();
        for (int numLigne = 1; numLigne <= taille; numLigne++)
        {
            for (int numColonne = 1; numColonne <= taille; numColonne++)
            {
                if (numLigne == 1 || numLigne == taille
                    || numColonne == 1 || numColonne == taille)
                {
                    Console.Write(" * ");//en fonction de votre terminal et de sa hauteur de ligne, ajustez le nombre d'espaces
                }
                else
                {
                    Console.Write("   ");//en fonction de votre terminal et de sa hauteur de ligne, ajustez le nombre d'espaces
                }

            }

            // sauter une ligne
            Console.WriteLine();
        }
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


