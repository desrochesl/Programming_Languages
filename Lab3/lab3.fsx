let addTuples (a, b) (c, d) = a + c, b + d

let a, b = addTuples (1, 1) (2, 2)

printfn $"({a}, {b})"

let quadratic p =
    let n1, n2 = p
    (int) (n1 + n2) * (n1 + n2)

printfn $"{quadratic (5, 2)}"

let hypot (p: float * float * float) =
    let n1, n2, n3 = p
    let squared: float = pown n1 2 + pown n2 2 + pown n3 2
    sqrt squared

printfn $"{hypot (2, 4, 5)}"


let classify a =
    match List.partition (fun x -> x % 2 = 0) a with
    | [], [] -> "EMPTY"
    | _, [] -> "ALL EVEN"
    | [], _ -> "ALL ODD"
    | _ -> "MIXED"

printfn $"{classify []}"
printfn $"{classify [ 1; 5 ]}"
printfn $"{classify [ 2; 4 ]}"
printfn $"{classify [ 1; 3; 2; 5; 8 ]}"
