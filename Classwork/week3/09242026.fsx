let rec factorial n =
    match n with
    | 0
    | 1 -> 1
    | _ -> n * factorial (n - 1)

let rec sumNumbers n =
    match n with
    | 1
    | 0 when n <= 1 -> 1
    | _ -> n + sumNumbers (n - 1)

let rec compoundInterest rate principal nYears =
    match nYears with
    | 0 -> principal
    | _ ->
        let newPrincipal = (1.0 + rate) * principal
        let newYear = nYears - 1
        compoundInterest rate newPrincipal newYear

printf "Input number to calculate factorial of: \n"
let input = 5
printf "\nThe factorial of %d is: %d\n\n" input (factorial input)

printf "Input number to calculate the sum of: \n"
let sumInput = 24
printf "\nThe sum of %d is: %d\n\n" sumInput (sumNumbers sumInput)

printf $"\nThe compound interest is is: {compoundInterest 2 1 2}\n\n"
printf $"\nThe compound interest is is: {compoundInterest 5 2 3}\n\n"

let rec gcd a b =
    match b with
    | 0 -> abs a
    | _ -> gcd b (a % b)

printfn "%d" (gcd 48 18)
printfn "%d" (gcd -24 60)
