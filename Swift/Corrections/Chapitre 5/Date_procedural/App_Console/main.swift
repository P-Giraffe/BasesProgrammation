//
//  main.swift
//  AppConsole
//
//  Created by Maxime Britto on 02/05/2017.
//  Copyright © 2017 mbritto. All rights reserved.
//

import Foundation

let ANNEE_MINIMUM = 1969

func estBissextile(annee:Int) -> Bool {
    var estBissextile = false
    if (annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0 {
        estBissextile = true
    }
    return estBissextile
}

func obtenirJourMax(mois:Int, annee:Int) -> Int {
    var jourMax = 31
    if mois == 4 || mois == 6 || mois == 9 || mois == 11 {
        jourMax = 30
    } else if mois == 2 {
        if estBissextile(annee:annee) {
            jourMax = 29
        } else {
            jourMax = 28
        }
    }
    return jourMax
}

func creerDate() -> Date {
    let newDate = Date()
    
    repeat {
        print("Année : ")
        newDate._annee = Utilisateur.saisirEntier()
    } while newDate._annee <= ANNEE_MINIMUM
    
    repeat {
        print("Mois : ")
        newDate._mois = Utilisateur.saisirEntier()
    } while newDate._mois < 1 || newDate._mois > 12
    
    
    repeat {
        print("Jour : ")
        newDate._jour = Utilisateur.saisirEntier()
    } while newDate._jour < 1 || newDate._jour > obtenirJourMax(mois: newDate._mois, annee: newDate._annee)
    
    return newDate
}

func afficherDate(date:Date) {
    print("Date : \(date._jour)/\(date._mois)/\(date._annee)")
}

func estPlusRecenteQue(date1:Date, date2:Date) -> Bool {
    let d1EstPlusRecente:Bool
    if date1._annee > date2._annee {
        d1EstPlusRecente = true
    } else if date1._annee < date2._annee {
        d1EstPlusRecente = false
    } else {
        if date1._mois > date2._mois {
            d1EstPlusRecente = true
        } else if date1._mois < date2._mois {
            d1EstPlusRecente = false
        } else {
            d1EstPlusRecente = (date1._jour > date2._jour)
        }
    }
    
    return d1EstPlusRecente
}

func estPlusRecenteQueV2(date1:Date, date2:Date) -> Bool {
    let d1Hash = date1._annee * 10000 + date1._mois * 100 + date1._jour
    let d2Hash = date2._annee * 10000 + date2._mois * 100 + date2._jour
    return d1Hash > d2Hash
}


print("Quel est votre nom ?")
let nom = Utilisateur.saisirTexte()

print("Quel est votre date de naissance ?")
let dateNaissance = creerDate()

print("Quel est votre date d'embauche ?")
var dateEmbauche:Date
repeat {
    dateEmbauche = creerDate()
} while estPlusRecenteQue(date1: dateNaissance, date2: dateEmbauche)

print("Bonjour \(nom), voici votre date de naissance :")
afficherDate(date: dateNaissance)

print("et votre date d'embauche :")
afficherDate(date: dateEmbauche)



for i in 0...100 {
    print(Math.nombreAleatoire(comprisEntre: 1, et: 100))
}

let texte:String
texte = Utilisateur.saisirTexte()
print("Hello, World!")

let age:Int
age = Utilisateur.saisirEntier()
print("Age : \(age)")

let note:Double
note = Utilisateur.saisirReel()
print("Note : \(note)")



