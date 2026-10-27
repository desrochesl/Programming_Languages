// Bubble Sort in F#:

let rec bubbleSort = function
    | [] -> []
    | list -> 
        let rec bubble = function
            | [] -> []
            | [x] -> [x]
            | x :: y :: tail -> 
                if x > y then
                    y :: bubble (x :: tail)
                else
                    x :: bubble (y :: tail)
        
        let bubbled = bubble list
        match List.rev bubbled with
        | [] -> []
        | largest :: rest -> 
            (bubbleSort (List.rev rest)) @ [largest]

let listsort = [1;5;2;5;7;2]
printf "%A: \nSorted: %A\n" listsort (bubbleSort listsort)