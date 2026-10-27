"""1. 
Factorial with tail recursion
"""

let factorial n =
    let rec factHelper n acc =
        match n with
        | n when n <= 1 -> n
        | _ -> factHelper (n - 1) (acc * n)

    factHelper n 1

let n = 4

printf
    $"""Factorial of {n} is: {factorial n}
"""


"""2. 
What is the difference between recursion and tail recursion

The difference between recursion and tail recursion is:
- Recursion adds after the recursive call ends. 
- Tail-recursion carries the running total in an accumulator. 
"""

"""3.
Length of a list with tail recursion"""

let len l =
    let rec lenHelper l acc =
        match l with
        | [] -> acc
        | _ :: t -> lenHelper t acc + 1

    lenHelper l 0

let l = [ 1; 2; 5 ]

printf
    $"""
The length of list {l} is: {len l} entries long
"""


"""4.
Reversing a list with tail recursion
"""

let reverse l =
    let rec helper l0 acc =
        match l0 with
        | [] -> acc
        | h :: t -> helper t (h :: acc)

    helper l []

let revl = reverse l

printf
    """
The list %A reversed is: %A
""" l revl
