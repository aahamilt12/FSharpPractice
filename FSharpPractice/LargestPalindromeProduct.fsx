// Practice Problem 4 https://projecteuler.net/problem=4

let ReverseString (s: string) =
     (System.String (Array.rev (s.ToCharArray()))).ToString()
let IsPalindrome num = ReverseString(num.ToString()) = num.ToString()

IsPalindrome 1111