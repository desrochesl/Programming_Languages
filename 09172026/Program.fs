[<EntryPoint>]
let main argv =
    let temp = 0

    let weatherReport =
        match temp with
        | t when t < 0 -> "freezing"
        | t when t < 15 -> "cold"
        | t when t < 35 -> "warm"
        | _ -> "hot"

    let dayNumber = 4

    let dayName =
        match dayNumber with
        | 1 -> "Monday"
        | 2 -> "Tuesday"
        | 3 -> "Wednesday"
        | 4 -> "Thursday"
        | 5 -> "Friday"
        | 6 -> "Saturday"
        | 7 -> "Sunday"
        | _ -> "Unknown"

    let grade = 95

    let gradeChecker =
        match grade with
        | g when g > 100 -> "Invalid Grade"
        | g when g >= 90 -> "A"
        | g when g >= 80 -> "B"
        | g when g >= 70 -> "C"
        | g when g >= 60 -> "D"
        | _ -> "Fail"

    let password = "abd"
    let username = "desrochesl"

    let access =
        match (username, password) with
        | (u, p) when u = "desrochesl" && p = "abd" -> "access granted"
        | (u, _) when u = "desrochesl" -> "access denied: password doesn't match"
        | (_, _) -> "Access Denied"


    printfn "It is %s outside today\n\n" weatherReport


    printfn "Today is %s\n\n" dayName

    printfn "Your grade is %s\n\n" gradeChecker

    printfn "%s\n\n" access

    0
