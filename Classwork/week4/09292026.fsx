let getMax1 p =
    let n1, n2 = p
    if n1 < n2 then n2 else n1

printfn ($"{getMax1 (1, 5)}")


let getMax2 (n1, n2) = if n1 < n2 then n2 else n1

printfn $"{getMax2 (1, 5)}"

printfn $"{fst (1, 2)}"


let rec gcd (a, b) =
    match (a, b) with
    | (_, 0) -> abs a
    | (_, _) -> gcd (b, a % b)


printfn $"\nThe gcd of 5 and 10 is: {gcd (5, 10)}"


let analyzeCoOrdinates point =
    // Point is a tuple of 2 elements
    match point with
    | 0, 0 -> "it is origin"
    | 0, _ -> "it is in the y axis"
    | _, 0 -> "it is in the x axis"
    | x, y when x = y -> "diagonal line"
    | _ -> "anywhere"

printfn $"{analyzeCoOrdinates (1, 5)}"

10 :: [ 20; 30 ]

[ 5; 1 ] @ [ 5; 62 ]
