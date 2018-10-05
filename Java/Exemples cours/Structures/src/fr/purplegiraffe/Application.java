package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

public class Application {
    public void fonctionPrincipale() {
        Joueur j = new Joueur("Jack", "Johnson");
        System.out.println(j.pseudo);

        Joueur j1 = new Joueur("Sheldon");
        System.out.println(j1.pseudo);


        Joueur j2 = new Joueur("Leonard", 100);
        System.out.println(j2.pseudo);



//
//
//
//
//        Joueur j1 = creerJoueur();
//        Joueur j2 = creerJoueur();
//
//        afficherJoueur(j1);
//        afficherJoueur(j2);
    }

    void truc(Joueur j) {
        j.score = 100;
    }

    Joueur creerJoueur() {
        String pseudo = ConsoleReader.readString("Entrez votre pseudo");
        Joueur nouveauJoueur = new Joueur(pseudo);
        do {
            nouveauJoueur.score = ConsoleReader.readInt("Entrez votre score");
        } while (nouveauJoueur.score < 0);

        return nouveauJoueur;
    }

    void afficherJoueur(Joueur joueurAAfficher) {
        System.out.println("Bonjour " + joueurAAfficher.pseudo + " votre score est de " + joueurAAfficher.score);
    }
}
