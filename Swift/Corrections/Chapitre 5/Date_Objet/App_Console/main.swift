//
//  main.swift
//  AppConsole
//
//  Created by Maxime Britto on 02/05/2017.
//  Copyright © 2017 mbritto. All rights reserved.
//

import Foundation

let d1 = MyDate(jour: 30, mois: 2, annee: 1500)
let d2 = MyDate(jour: 40, mois: 12, annee: 2000)


print("Quel est votre nom ?")
let nom = Utilisateur.saisirTexte()

print("Quel est votre date de naissance ?")
let dateNaissance = MyDate()

print("Quel est votre date d'embauche ?")
var dateEmbauche:MyDate
repeat {
    dateEmbauche = MyDate()
} while dateNaissance.estPlusRecenteQue(dateEmbauche)

print("Bonjour \(nom), voici votre date de naissance :")
dateNaissance.afficheToi()

print("et votre date d'embauche :")
dateEmbauche.afficheToi()




