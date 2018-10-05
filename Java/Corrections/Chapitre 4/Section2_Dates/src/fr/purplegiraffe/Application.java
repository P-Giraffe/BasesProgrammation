package fr.purplegiraffe;

import fr.purplegiraffe.NE_PAS_TOUCHER.ConsoleReader;

public class Application {
    public void fonctionPrincipale() {
        String prenom = ConsoleReader.readString("Prénom");
        String nom = ConsoleReader.readString("Nom");
        System.out.println("Date de naissance");
        Date naissance = creerDate();
        Date embauche;
        boolean naissancePlusRecente;
        do {
            System.out.println("Date d'embauche");
            embauche = creerDate();
            naissancePlusRecente = estPlusRecenteQue(naissance,embauche);
            if (naissancePlusRecente) {
                System.out.println("Vous etes né après votre embauche ?");
            }
        } while(naissancePlusRecente == true);

        System.out.format("Bonjour %s %s voici votre date de naissance : \n",prenom, nom);
        afficherDate(naissance);
        System.out.println("Et voici votre date d'embauche");
        afficherDate(embauche);
    }

    void afficherDate(Date d) {
        System.out.format("%02d/%02d/%04d\n",d.jour, d.mois, d.annee);
    }

    Date creerDate() {
        Date nvDate = new Date();

        nvDate.annee = ConsoleReader.readInt("année");
        do {
            nvDate.mois = ConsoleReader.readInt("mois");
        } while (nvDate.mois < 1 || nvDate.mois > 12);

        int jourMax = obtenirJourMax(nvDate);
        do {
            nvDate.jour = ConsoleReader.readInt("jour");
        } while (nvDate.jour < 1 || nvDate.jour > jourMax);

        return nvDate;
    }

    int obtenirJourMax(Date nvDate) {
        int jourMax;
        switch (nvDate.mois) {
            case 4:
            case 6:
            case 9:
            case 11:
                jourMax = 30;
                break;
            case 2:
                if (estBissextile(nvDate.annee) == true) {
                    jourMax = 29;
                } else {
                    jourMax = 28;
                }
                break;
            default:
                jourMax = 31;
        }
        return jourMax;
    }

    boolean estBissextile(int annee) {
        return (annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0;
    }

    boolean estPlusRecenteQue(Date d1, Date d2) {
        boolean d1PlusRecente = true;

        if (d2.annee > d1.annee) {
            d1PlusRecente = false;
        } else if (d1.annee == d2.annee) {
            if (d2.mois > d1.mois) {
                d1PlusRecente = false;
            } else if (d1.mois == d2.mois && d2.jour > d1.jour) {
                d1PlusRecente = false;
            }
        }
        return d1PlusRecente;
    }
}
