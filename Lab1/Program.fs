// adds numbers a and b together, then returns the result
let addTwo a b= a + b

// Uses comparison operator to check if a is less than 0
let isNonPositive a = a <= 0

// using an if statement, we can output the result in a string format
let isEven a = if a % 2 = 0 then "even" else "odd"

// Using the `not` keyword, we can check if a = 0, then we can invert the result to get if it is not 0. 
let isNonZero a = not (a = 0)

[<EntryPoint>]
let main argv = 

    printf "Enter first number: " 
    // Using System.Console.ReadLine() we can gather user input to allow the user to input numbers. 
    let firstNum =  int (System.Console.ReadLine())

    printf "Enter second number: " 
    let secondNum =  int (System.Console.ReadLine())

    printfn "Sum = %d\n" (addTwo firstNum  secondNum)

    printf "Enter a number to test non-positive: "
    let nonPos = int (System.Console.ReadLine())

    printfn "%b\n" (isNonPositive nonPos)

    printf "Enter a number to test even/odd: "
    let evenOdd = int (System.Console.ReadLine())

    printfn "%s\n" (isEven evenOdd)

    printf "Enter a number to test non-zero: "
    let nonZero = int (System.Console.ReadLine())

    printfn "%b\n" (isNonZero nonZero)

    0
