// 1. Write a program to get List length
printfn "Question 1:"

let rec length myList =
    match myList with
    | [] -> 0
    | h :: t -> 1 + length t

let list = [ 5; 8; 3 ]
let zerolist = []

printfn $"List containing {list} is {length list} long"

// or call list.Length:
printfn $"length list = list.Length is: {length list = list.Length}"

// 2. Show the steps in the table [5;8;3]
printfn "Question 2:"

printfn
    """Step	Active Call	Pattern Matched	Pending Operation	Sub Problem Call	Evaluated Result
1	Length[5;8;3]	5::[8;3]	1+ length[8;3]	Length [8;3]	Waiting…
2	Length[8;3]	8::[3]	1 + length[3]	Length[3]	Waiting…
3	Length[3]	3::[]	1 + length[]	Length[]	Waiting…
4	Length[]	[]	None	None	0
5	Recursive Return	None	None	None	1
6	Recursive Return	None	None	None	2
7	Recursive Return	None	None	None	3
"""

// 3. Write a program for summing the elements of a list

printfn "Question 3:"

let rec sum myList =
    match myList with
    | [] -> 0
    | h :: t -> h + sum t

printfn $"\nList containing: {list}\nHas the sum: {sum list}"


// 4. Use the same table to show sum [5;8;3]
printfn "Question 4:"


printfn
    """
Step	Active Call	Pattern Matched	Pending Operation	Sub Problem Call	Evaluated Result
1	Sum[5;8;3]	5::[8;3]	1+ Sum[8;3]	Sum [8;3]	Waiting…
2	Sum[8;3]	8::[3]	1 + Sum[3]	Sum[3]	Waiting…
3	Sum[3]	3::[]	1 + Sum[]	Sum[]	Waiting…
4	Sum[]	[]	None	None	0
5	Recursive Return	None	None	None	1
6	Recursive Return	None	None	None	2
7	Recursive Return	None	None	None	3

"""

// 5. Double every number in a list code and table for [10;20]

printfn "Question 5:"

let rec double list =
    match list with
    | [] -> []
    | h :: t -> h * 2 :: double t

printfn $"\nList containing: [10;20]\nDoubled is: {double [ 10; 20 ]}"
printfn $"\nList containing: []\nDoubled is: {double []}"

printfn
    """
Step	Active Call	Pattern Matched	Pending Operation	Sub Problem Call	Evaluated Result
1	Double[10;20]	10::[20]	10*2 :: Double[20]	Double [20]	Waiting…
2	Double[20]	20::[]	20*2 :: Double[]	Double[]	Waiting…
4	Double[]	[]	None	None	[]
5	N/A	None	40::[]	None	[40]
6	N/A	None	20::[40]	None	[20;40]
"""
