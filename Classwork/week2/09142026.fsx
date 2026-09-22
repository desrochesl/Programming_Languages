let square x = x * x


let equality_checker () =
    let x = 10
    let y = 20

    let result =
        if (x < y) then "less"
        elif (x = y) then "equal"
        else "greater"

    printfn "%s" result

let temperature_checker (temp: int) =
    let weatherStatus =
        if (temp <= 0) then "freezing"
        else if (temp < 15) then "cold"
        else if (temp < 35) then "warm"
        else "hot"

    printfn "It is %s today" weatherStatus

let grade_checker (grade: int) =
    let gradeStatus =
        if (grade >= 90) then "A"
        else if (grade >= 80) then "B"
        else if (grade >= 70) then "C"
        else if (grade >= 60) then "D"
        else "Fail"

    printfn "Your grade is: %s" gradeStatus

// 09-14-2026
printfn "%d squared is: %d!" 12 (square 12)

// 09-15-2026
equality_checker ()

temperature_checker (2)

grade_checker (87)

0
