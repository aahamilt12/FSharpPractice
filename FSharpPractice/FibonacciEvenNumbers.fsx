// Practice Problem 2 Even Fibonacci numbers https://projecteuler.net/problem=2
    
let fib = List.unfold (fun num ->
    if (fst num > 4000000) then None
    else Some(fst num + snd num, (snd num, fst num + snd num))) (1,1)

let evens = List.filter (fun x -> x % 2 = 0) fib
let sum = List.sum evens