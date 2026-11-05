// Parameterized Types:
type Shape<'a> =
    | Circle of 'a
    | Square of 'a

type Option<'a> =
    | Some of 'a
    | None

// Use Option to skip unavailable values
let rec sum l =
    match l with
    | [] -> 0
    | None :: t -> sum t
    | Some x :: t -> x + sum t

let s = sum [ Some 10; None; Some 12; Some 13 ]

// 1. Provide step by step to find the sum s
"""
match [Some 10; None; Some 12; Some 13] with
| Some 10 :: [None; Some 12; Some 13] -> 10 + sum [None; Some 12; Some 13]

match [None; Some 12; Some 13] with
| None :: [Some 12; Some 13] -> sum [Some 12; Some 13]

match [Some 12; Some 13] with
| Some 12 :: [Some 13] -> 12 + sum [Some 13]

match [Some 13] with
| some 13 :: [] -> 13 + sum []

match [] with
| [] -> 0

10 + 12 + 13 + 0

35

"""

let rec list_max l =
    match l with
    | [] -> None
    | h :: t ->
        match list_max t with
        | None -> Some h
        | Some m when m < h -> Some h
        | Some m -> Some m


type Tree<'a> =
    | Empty
    | Node of Tree<'a> * 'a * Tree<'a>


// Binary Trees Using Union Types

let in1 = Node(Empty, 10, Empty)
let in2 = Node(in1, 12, Empty)
let in3 = Node(Empty, 19, Empty)

let rt = Node(in2, 13, in3)

let rec exists t x =
    match t with
    | Empty -> false
    | Node (Empty, i, Empty) -> i = x
    | Node (c1, i, c2) -> i = x || exists c1 x || exists c2 x


"""2. How do you explain the inductive step?
    the inductive steps check if the Tree is empty
b. Program it so that we need all 3 patterns
The first pattern is used to check if we reach the end, or if we have no tree to start with. 

Pattern 2 is used to check if the tree only has 1 node and the singular node contains the value we are looking for. 

Pattern 3 checks for 3 things, If we found x, or we search the tree to the left if we find the value all the way to the end. From there we check the right branch all the way back to the root

If it is not in the left side, we then do the same thing for the right side, checking the right side going from the left branch to the right side. 
"""

let rec height t =
    match t with
    | Empty -> 0
    | Node (cl, _, cr) ->
        let lh = height cl
        let lr = height cr
        1 + max lh lr
