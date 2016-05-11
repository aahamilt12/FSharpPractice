// Practice Problem 2 Even Fibonacci numbers https://projecteuler.net/problem=2

let rec NextFibNum n = if n <= 2 then 1
                       elif n >= 4000000 then -1
                       else NextFibNum (n - 1) + NextFibNum (n - 2)

// still needs work
let mutable KeepGoing = true
let mutable n = 0
let FibList = []
while KeepGoing do
    let fibAppend = NextFibNum n
    if fibAppend > -1 then List.append FibList fibAppend
    n <- n + 1
