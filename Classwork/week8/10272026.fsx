let e =
    [ "John", 100
      "Amanda", 110
      "Chris", 80 ]

let byName = List.sortBy (fun (name, salary) -> name) e

let bySalary = List.sortBy (fun (name, salary) -> salary) e

// printfn "Sort by name: %A\n" byName

// printfn "Sort by salary: %A\n" bySalary




let nums = [ 1; 6; 2; 3 ]

let sorted =
    List.sortWith
        (fun x y ->
            if x < y then -1
            elif x > y then 1
            else 0)
        nums

// printfn "nums: %A\nSorted: %A\n" nums sorted


let addOne x = x + 1
let timesTwo x = x * 2
let subtractTen x = x - 10

let pipeExOne = 5 |> addOne |> timesTwo |> subtractTen

// printfn "Pipe Ex1: (((5 + 1) * 2) - 10).\nResult: %d\n" pipeExOne


let add x y = x + y
let times x y = x * y
let subtract x y = x - y

let pipeExTwo = (5, 10) ||> add

// printfn "Pipe Ex2: (5 + 10).\nResult: %d\n" pipeExTwo

"""1.

Table fillup sortwith where: e = [1; 6; 2; 3]

| Step | Pair Evaluated (x , y) | Condition Triggered | Return Value | Action Taken | List State   |
| ---- | ---------------------- | ------------------- | ------------ | ------------ | ------------ |
| 1    | 1 , 6                  | 1 < 6               | -1           | Keep order   | [1; 6; 2; 3] |
| 2    | 6 , 2                  | 6 > 2               | 1            | Swap 6 and 2 | [1; 2; 6; 3] |
| 3    | 6 , 3                  | 6 > 3               | 1            | Swap 6 and 3 | [1; 2; 3; 6] |
| 4    | 2, 3                   | 2 < 3               | -1           | Keep order   | [1; 2; 3; 6] |
| 5    | 1; 2                   | 1 < 2               | -1           | Keep order   | [1; 2; 3; 6] |
"""


let a = [ 11; 13; 9; 14; 6 ]

let s2 =
    a
    |> List.sortBy (fun x -> -x)
    |> List.filter (fun x -> x > 11)
    |> List.map (fun x -> (float x) / 2.)

// printfn "Pipelines; Sort, Filter, Map: %A \nResult: %A\n" a s2

"""------------------------------------------------------------------------ """

let cardMap x =
    match x with
    | "King" -> 13
    | "Queen" -> 12
    | "Jack" -> 11
    | _ -> int x

let hand =
    [ "Queen"
      "3"
      "King"
      "5"
      "4"
      "1"
      "Jack" ]

let handSorted = hand |> List.sortBy cardMap


"""2. 
Function to filter by face card: """

let faceCards = hand |> List.filter (fun x -> (cardMap x) > 10)

"""3. Get the card values in a list"""
let handScore = hand |> List.map cardMap

"""4. Get total score by summing all values"""
let totalScore = handScore |> List.fold (fun acc score -> acc + score) 0

printfn"""2. 3. 4.f
Hand: %A
Sorted: %A
Face Cards: %A
Hand Score: %A
Total Score: %A
"""
    hand
    handSorted
    faceCards
    handScore
    totalScore
