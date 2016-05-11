// Practice Problem 3 https://projecteuler.net/problem=3

// todo: this works for the example problem, however the real problem uses 600851475143
// which won't fit in a regular int, update this later to use int64?
let FindHalf num = int(floor ((double)(num / 2)))
let GenerateCandidateList num = [1 .. num]
let IsFactor numerator denom = numerator % denom = 0
let IsPrime num = 
                 let highest = (FindHalf num)
                 let rec findFactor x = 
                     if x = highest then true
                     elif num % x = 0 then false
                     else findFactor (x + 1)
                 findFactor 2
                    
                      
let GetFactors candList num = List.filter (fun x -> IsFactor num x) candList
let GetPrimes candList = List.filter IsPrime candList
let rec GetLast list = 
                    if (List.length list) = 1 then list
                    else GetLast (List.tail list)

let Eval num = GetLast(GetPrimes(GetFactors(GenerateCandidateList(FindHalf num)) num))
Eval 13195

