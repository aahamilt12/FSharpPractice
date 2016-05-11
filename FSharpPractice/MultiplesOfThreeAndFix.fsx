// Practice Problem 1 Multiple of 3 and 5: https://projecteuler.net/problem=1
// Solved
let IsMultipleThree num = num % 3 = 0 
let IsMultipleFive num = num % 5  = 0

let MultipleThreeOrFive num = List.choose (fun elem ->
                                        match elem with
                                        | elem when IsMultipleThree elem -> Some(elem)
                                        | elem when IsMultipleFive elem -> Some(elem)
                                        | _ -> None) [1 .. num]

let Eval = List.sum (MultipleThreeOrFive 999)
