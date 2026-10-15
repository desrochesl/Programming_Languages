// Playground:
let days2Seconds d =
    let h = d * 24

    let m = h * 60

    m * 60

// let s = (days2Seconds 1)

// printfn $"days2Seconds: {s}\n"

let add3 (x, y, z) =
    let add2 n1 n2 = n1 + n2

    x + add2 y z

// printfn $"add3: {add3 (1, 2, 3)}\n"

// Classwork:
// 1.
printfn
    """1. 
Write a recursive program that will triple each element of a list. 
Do it without a nested function and with a nested function.
Your nested function is a helper function that triples a value only:
"""

let rec triple a =
    match a with
    | [] -> []
    | h :: t -> h * 3 :: triple t

let rec tripleNest a =
    let triple b = b * 3

    match a with
    | [] -> []
    | h :: t -> triple h :: tripleNest t

let l = [ 3; 1; 5 ]

printfn
    $"""Results:
triple {l}: {triple l}
tripleNest {l}: {tripleNest l}
"""

// 2.
printfn
    $"""2.
Write a program to which reverses a list:
"""

let rec reverse l =
    match l with
    | [] -> []
    | h :: t -> reverse t @ [ h ]

let s = [ 1; 2; 3; 4; 5 ]

printfn
    """Results:
reverse %A: %A
"""
    s
    (reverse s)

// 3.
printfn
    """3.
Create split2, a function that divides a list into 2 separate lists as a tuple:
"""

let rec split2 a =
    match a with
    | [] -> [], []
    | [ x ] -> [ x ], []
    | a :: b :: cs ->
        let x, y = split2 cs
        a :: x, b :: y

let spl = [ 1; 2; 3; 4; 5 ]

printfn
    """Results:
split2 %A: %A
"""
    spl
    (split2 spl)
