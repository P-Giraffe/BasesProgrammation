package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

import java.util.Random;

public class Application {
    public void fonctionPrincipale() {
        /************************* Exercice 1 ****************************/
        String prenom = ConsoleReader.readString("Entrez votre prénom");
        System.out.println("Bonjour " + prenom + " !");

        /************************* Exercice 2 ****************************/
        double note1 = ConsoleReader.readDouble("Note 1");
        double note2 = ConsoleReader.readDouble("Note 2");
        double note3 = ConsoleReader.readDouble("Note 3");
        double moyenne = (note1 + note2 + note3) / 3;
        System.out.println("La moyenne de ces 3 notes vaut " + moyenne);

        /************************* Exercice 3 ****************************/
        double base = ConsoleReader.readDouble("Base du triangle");
        double hauteur = ConsoleReader.readDouble("Hauteur du triangle");
        double aire = (base * hauteur)/2;
        System.out.println("Aire du triangle : " + aire);

        /************************* Exercice 4 ****************************/
        double rayon = ConsoleReader.readDouble("Rayon du cercle");
        final double PI = 3.14159265;
        double aireCercle = PI * rayon * rayon;
        System.out.println("Aire du cercle : " + aireCercle);

        /************************* Exercice 5 ****************************/
        int taille = ConsoleReader.readInt("Taille du carré à dessiner");
        for (int ligne = 0; ligne < taille; ligne++) {
            //dessiner la ligne
            for (int colonne = 0; colonne < taille; colonne++) {
                System.out.print(" *");
            }

            //sauter une ligne
            System.out.println();
        }
        /************************* Exercice 6 ****************************/
        //Moyenne plusieurs notes
        //double moyenne;
        double somme = 0;
        int nbNotes;

        //Demander à l'utilisateur le nombre de notes
        nbNotes = ConsoleReader.readInt("Combien de notes à saisir ?");

        //Demander les notes individuellement
        for (int numNote = 0; numNote < nbNotes; numNote++) {
            //Demander à la personne de saisir la note
            double note = ConsoleReader.readDouble("Saisir la note " + numNote);

            //Faire grossir la somme avec la nouvelle note
            somme = somme + note;
        }

        //Calculer la moyenne
        if (nbNotes > 0) {
            moyenne = somme / nbNotes;
            System.out.println("Voici la moyenne : " + moyenne);
        }
        /************************* Exercice 7 ****************************/
        int resultat = 1;
        int n = ConsoleReader.readInt("Factorielle à calculer");

        for (int compteur = 1; compteur <= n; compteur++) {
            resultat = resultat * compteur;
            /*
            System.out.print(compteur);
            if (compteur < n) {
                System.out.print(" x ");
            }
            */
        }

        System.out.println(" = " + resultat);

        /************************* Exercice 8 ****************************/
        Random generateur = new Random();
        int nombreAleatoire = 0;

        nombreAleatoire = generateur.nextInt(100) + 1; //nextInt retourne un nombre aléatoire compris entre 0 et 99. Nous ajoutons 1 pour avoir un nombre entre 1 et 100
        int nombreUtilisateur = 0;
        int nombreEssais = 0;
        do
        {
            nombreEssais++;
            nombreUtilisateur = ConsoleReader.readInt("Combien vaut le nombre mystère");
            if (nombreUtilisateur < nombreAleatoire)
            {
                System.out.println("C'est plus");
            }
            else if (nombreUtilisateur > nombreAleatoire)
            {
                System.out.println("C'est moins");
            }
        } while (nombreAleatoire != nombreUtilisateur);

        System.out.println("Bravo! Vous avez trouvé en " + nombreEssais + " essai(s)");


        /*********************** Exercice 9 **************************/
        int nbAllumettes = 20;
        int saisieUtilisateur;
        String joueurEnCours;
        String prochainJoueur = "Joueur 1";

        do
        {
            joueurEnCours = prochainJoueur;
            for (int i = 0; i < nbAllumettes; i++)
            {
                System.out.print("| ");
            }
            System.out.println(" Il reste " + nbAllumettes + " allumette(s)");
            int saisieMax = nbAllumettes < 3 ? nbAllumettes : 3;
            do
            {
                saisieUtilisateur = ConsoleReader.readInt(joueurEnCours + ": prenez entre 1 et "+saisieMax+" allumette(s)");
            } while (saisieUtilisateur < 1 || saisieUtilisateur > saisieMax);


            nbAllumettes = nbAllumettes - saisieUtilisateur;

            if (joueurEnCours == "Joueur 1")
            {
                prochainJoueur = "Joueur 2";
            }
            else
            {
                prochainJoueur = "Joueur 1";
            }
        } while (nbAllumettes > 0);

        System.out.println("Le " + prochainJoueur + " a gagné");
    }


}
