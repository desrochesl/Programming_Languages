let a = [ 10; 11; 12 ]

let b = [ for elem in a -> elem * 2 ]

printfn "A is: %A\n\nB is: %A\n\n" a b

type Person = { Name: string; Age: int }
let p1 = { Name = "Alice"; Age = 25 }
let p2 = { Name = "Bob"; Age = 30 }
printfn "%s is %d years old" p1.Name p1.Age
printfn "%s is %d years old" p2.Name p2.Age


type Result =
    | Success
    | FailureMsg of string

let r1 = Success
let r2 = FailureMsg "User not found"

printfn "Result 1: %A\n\nResult 2: %A\n" r1 r2


type Shape =
    | Circle of float
    | Square of float

let area s =
    match s with
    | Circle r -> 3.14 * r * r
    | Square sd -> sd * sd

let aCircle = Circle 3.
let aSquare = Square 3.

// Areas:
let cArea = area aCircle
let sqArea = area aSquare

printfn
    """Shapes: 
A Circle: %A
Circle Area: %A
A Square: %A
Square Area: %A
"""
    aCircle
    cArea
    aSquare
    sqArea

type CardDetails = { CardNumber: string; Expiry: string }

type CryptoDetails =
    { WalletAddress: string
      Protocol: string }

type PaymentMethod =
    | CreditCard of CardDetails
    | Crypto of CryptoDetails
    | BankTransfer of routerNumber: string * accountNumber: string

type OrderItem = { Name: string; Price: float }

type TransactionStatus =
    | Pending
    | Approved of authorizationCode: string
    | FlaggedForReview of reason: string
    | Rejected of errorCode: int

type Order =
    { OrderID: int
      Items: OrderItem list
      Payment: PaymentMethod
      ShippingCountry: string }

let orders =
    [ { OrderID = 1001
        Items =
          [ { Name = "Keyboard"; Price = 15 }
            { Name = "Laptop"; Price = 15 } ]
        Payment = BankTransfer("123", "456")
        ShippingCountry = "USA" }
      { OrderID = 1002
        Items =
          [ { Name = "Perfume"; Price = 14 }
            { Name = "Eyeliner"; Price = 20 } ]
        Payment =
          CreditCard
              { CardNumber = "2500200020002152"
                Expiry = "12/28" }

        ShippingCountry = "Italy" } ]

printfn
    """Orders: %A
"""
    orders


let evaluateRisk (order: Order) : int * TransactionStatus =
    let status =
        match order.Payment, order.ShippingCountry with
        | BankTransfer _, country when country <> "USA" -> Rejected 101
        | _, _ -> Rejected 100

    order.OrderID, status

printfn $"{evaluateRisk orders[1]}"
