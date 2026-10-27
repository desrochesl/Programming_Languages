// merge sort:
let rec split2 l =
    match l with
    | [] -> [], []
    | h :: [] -> [ h ], []
    | a :: b :: cs ->
        let x, y = split2 cs
        a :: x, b :: y


let rec mergeInOrder l1 l2 =
    match l1, l2 with
    | [], _ -> l2
    | _, [] -> l1
    | h1 :: t1, h2 :: t2 when h1 < h2 -> h1 :: mergeInOrder t1 l2
    | h1 :: t1, h2 :: t2 -> h2 :: mergeInOrder l1 t2


let rec mergeSort l =
    match l with
    | [] -> []
    | [ a ] -> [ a ]
    | _ ->
        let x, y = split2 l
        mergeInOrder (mergeSort x) (mergeSort y)

let l = [ 5; 2; 1; 6; 8 ]
let l2 = [ 1; 2; 3; 6; 8 ]
printfn "Merge Sort of %A: %A\n" l2 (mergeSort l2)


printfn
    """1.
What are the input(s) and output of mergeInOrder function?

Input: two already sorted lists l1 and l2. 
Output: A single sorted list containing all elements from both lists. 
"""

printfn
    """2.
a. Walkthrough of MiO for [1;4] and [2;3]
b. Why we send mio params as mio t1 l2 when h1 < t2?
    why dont we send mio t1 t2 or mio l1 t2?
    
a. mergeInOrder [1; 4] [2; 3]
    1 < 2 -> 1 :: mergeInOrder [4] [2;3]
    4 >=2 -> 1 :: 2 :: mergeInOrder [4] [3]
    4 >= 3 -> 1 :: 2 :: 3 :: mergeInOrder [4] []
    [4], [] -> [4]
    result [1; 2; 3; 4]
    
b. We only placed h1 into the result so only l1 advanced to t1
    Why not t1 t2? t1 t2 would discard h2 without adding to the result.
    Why not l1 t2? It would keep h1 in l1 and drop h2
"""

printfn
    """3. 
mergeSort [4; 3; 1; 2]. Do the walkthrough.
    mergeSort [4; 3; 1; 2]
    x,y = split2 l = ([4;1], [3;2])
    mergeInOrder (mergeSort x) (mergeSort y)

x:  
    mergeSort [4; 1]
    x = 4, y = 1
    mergeInOrder (mergeSort [4]) (mergeSort [1])
        mergeSort [4]
        | [4] -> [4]
        mergeSort [1]
        | [1] -> [1]
    mergeInOrder [4] [1]
    | 4 > 1 -> [1;4]
y: 
    mergeSort [3;2]
    mergeInOrder (mergeSort [3]) (mergeSort [2])
        mergeSort [3]
        | [3] -> [3]
        mergesort [2]
        | [2] -> [2]
    mergeInOrder [3] [2]
    | 3 > 2 -> [2; 3]

mergeInOrder [1; 4] [2; 3]
| 1 :: [4] , 2 :: [3] when 1 < 2 -> mergeInOrder [4] [2; 3]
    

    mergeInOrder [4] [2;3]
    | 4 :: [] , 2 :: [3] 
"""
