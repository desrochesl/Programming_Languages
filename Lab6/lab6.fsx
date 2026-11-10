type SET =
    | I of int list
    | S of string list
    | IS of (int * string) list
    | SI of (string * int) list
    | SS of (string * string) list
    | II of (int * int) list
    | SISI of ((string * int) * (string * int)) list
    | SIIS of ((string * int) * (int * string)) list

let rec distribute dis lis =
    match dis, lis with
    | _, [] -> []
    | x, h :: t -> (x, h) :: distribute x t


let rec pairs (s1: 'a list) (s2: 'b list) =
    match s1, s2 with
    | [], _ -> ([])
    | h1 :: t1, _ -> distribute h1 s2 @ pairs t1 s2


let product s1 s2 =
    match s1, s2 with
    | I s1, I s2 -> II(pairs s1 s2)
    | S s1, S s2 -> SS(pairs s1 s2)
    | I s1, S s2 -> IS(pairs s1 s2)
    | S s1, I s2 -> SI(pairs s1 s2)
    | SI s1, SI s2 -> SISI(pairs s1 s2)
    | SI s1, IS s2 -> SIIS(pairs s1 s2)

let i1 = I [ 1000; 1050 ]
let i2 = I [ 5555; 6666 ]
let s1 = S [ "COMP"; "HIST"; "PHYS" ]
let s2 = S [ "CHEM"; "MATH" ]

let is = product i1 s1
let si1 = product s1 i1
let si2 = product s2 i2
let sisi = product si1 si2
let siis1 = product si1 is

printfn "SISI:\n%A\n\n" sisi
printfn "SIIS:\n\n%A\n\n" siis1
