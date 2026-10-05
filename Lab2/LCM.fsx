let rec gcd a b =
    match b with
    | 0 -> abs a
    | _ -> gcd b (a % b)

let lcm a b =
    match (a, b) with
    | 0, _
    | _, 0 -> 0
    | _, _ -> a * b / gcd a b


let length = 2
let a = [ 12; 5; 23 ]
let b = [ 18; 7; 0 ]

for i in 0..length do
    printfn $"lcm of: {a[i]} and {b[i]}: \n{lcm a[i] b[i]}"
