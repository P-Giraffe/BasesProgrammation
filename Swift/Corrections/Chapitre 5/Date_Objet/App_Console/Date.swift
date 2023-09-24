//
//  Date.swift
//  App_Console
//
//  Created by Maxime Britto on 04/05/2017.
//  Copyright © 2017 mbritto. All rights reserved.
//

import Foundation

class MyDate {
    let ANNEE_MINIMUM = 1969
    private var _jour:Int = 1, _mois:Int = 1, _annee:Int = 1970
    
    init() {
        remplirDateParUtilisateur()
    }
    
    init(jour j:Int,mois m:Int,annee a:Int) {
        self._annee = max(ANNEE_MINIMUM, a)
        self.mois = m
        self.jour = j
    }
    
    var jour:Int {
        get {
            return _jour
        }
        set {
            var nvJour = max(1, newValue)
            nvJour = min(obtenirJourMax(), nvJour)
            _jour = nvJour
        }
    }
    
    var mois:Int {
        get {
            return _mois
        }
        set {
            var nvMois = max(1,newValue)
            nvMois = min(12, nvMois)
            _mois = nvMois
        }
    }
    
    func remplirDateParUtilisateur() {
        repeat {
            print("Année : ")
            self._annee = Utilisateur.saisirEntier()
        } while self._annee <= ANNEE_MINIMUM
        
        repeat {
            print("Mois : ")
            self._mois = Utilisateur.saisirEntier()
        } while self._mois < 1 || self._mois > 12
        
        
        repeat {
            print("Jour : ")
            self._jour = Utilisateur.saisirEntier()
        } while self._jour < 1 || self._jour > obtenirJourMax()
    }
    
    func estBissextile() -> Bool {
        var estBissextile = false
        if (_annee % 4 == 0 && _annee % 100 != 0) || _annee % 400 == 0 {
            estBissextile = true
        }
        return estBissextile
    }
    
    private func obtenirJourMax() -> Int {
        var jourMax = 31
        if _mois == 4 || _mois == 6 || _mois == 9 || _mois == 11 {
            jourMax = 30
        } else if _mois == 2 {
            if estBissextile() {
                jourMax = 29
            } else {
                jourMax = 28
            }
        }
        return jourMax
    }

    func afficheToi() {
        print("Date : \(self._jour)/\(self._mois)/\(self._annee)")
    }
    
    func estPlusRecenteQue(_ date2:MyDate) -> Bool {
        let d1EstPlusRecente:Bool
        if self._annee > date2._annee {
            d1EstPlusRecente = true
        } else if self._annee < date2._annee {
            d1EstPlusRecente = false
        } else {
            if self._mois > date2._mois {
                d1EstPlusRecente = true
            } else if self._mois < date2._mois {
                d1EstPlusRecente = false
            } else {
                d1EstPlusRecente = (self._jour > date2._jour)
            }
        }
        
        return d1EstPlusRecente
    }
    
    func estPlusRecenteQueV2(_ date2:MyDate) -> Bool {
        let d1Hash = self._annee * 10000 + self._mois * 100 + self._jour
        let d2Hash = date2._annee * 10000 + date2._mois * 100 + date2._jour
        return d1Hash > d2Hash
    }
}
