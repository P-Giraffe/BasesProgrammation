//
//  File.swift
//  App_Console
//
//  Created by Maxime Britto on 02/05/2017.
//  Copyright © 2017 mbritto. All rights reserved.
//

import Foundation

class Math {
    
    /**
     Genere un nb aléatoire
     - Parameter comprisEntre: nb minimum
     - Parameter et: nb max
     - Returns: un nombre aleatoire compris entremin et max
    */
    static func nombreAleatoire(comprisEntre min:Int, et max:Int) ->Int {
        return Int(arc4random_uniform(UInt32(max + 1)) + UInt32(min))
    }
}
