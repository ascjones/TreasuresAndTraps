namespace Game

open System
open Game.Domain

module Brains =

    let rand = new Random();

    let randomDecide () =
        match rand.Next(3) with
        | 0 -> Straight
        | 1 -> Left
        | 2 -> Right
        | x -> failwithf "Random too bif %i" x