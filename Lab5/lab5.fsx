let cardMap x =
    match x with
    | "King" -> 13
    | "Queen" -> 12
    | "Jack" -> 11
    | _ -> int x

let rec doublePoints l1 =
    match l1 with
    | [] -> []
    | h :: t ->
        let card = cardMap h

        if card % 2 = 0 then
            card :: doublePoints t
        else
            card * 2 :: doublePoints t

let hand = [ "Jack"; "3"; "6" ]

// printf "Hand: %A\n\nDouble Points: %A\n\n" hand (doublePoints hand)


let rec handToInt l1 =
    match l1 with
    | [] -> []
    | h :: t -> cardMap h :: handToInt t

let maxConsecutiveIncrease l1 =
    match l1 with 
    | [] -> 0
    | head :: tail ->
        let _, maxStreak, _ = 
            List.fold 
                (fun (current, maxSoFar, prev) x ->
                    if x > prev then
                        let nextCurrent = current + 1
                        nextCurrent, max maxSoFar nextCurrent, x
                    else
                        0, maxSoFar, x)
                    (1, 0, head) tail
        maxStreak

let handTwo = [3; 5; 6; 4; 13; 2]

printfn $"{maxConsecutiveIncrease handTwo}"
