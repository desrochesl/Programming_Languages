let myMin a b = if a < b then a else b

let m1 = myMin 13 20

let m2 = myMin 9.5 3.0

printfn $"m1: {m1} \nm2: {m2}"
