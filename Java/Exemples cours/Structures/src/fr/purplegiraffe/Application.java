package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

public class Application {
    public void fonctionPrincipale() {
        //Exemple d'utilisation
        Joueur j1 = creerJoueur();

        Joueur j2 = creerJoueur();

        afficherJoueur(j1);
        afficherJoueur(j2);
    }

    Joueur creerJoueur() {
        Joueur nouveauJoueur = new Joueur();
        nouveauJoueur.pseudo = ConsoleReader.readString("Entrez votre pseudo");
        do {
            nouveauJoueur.score = ConsoleReader.readInt("Entrez votre score");
        } while (nouveauJoueur.score < 0);

        return nouveauJoueur;
    }

    void afficherJoueur(Joueur joueurAAfficher) {
        System.out.println("Bonjour " + joueurAAfficher.pseudo + " votre score est de " + joueurAAfficher.score);
    }
}
