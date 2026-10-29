# Programming Languages Exam Review

## Format

• The exam will be 5-6 problems, with some problems
having multiple sub-questions
• You are allowed a single `8.5 x 11"` piece of paper with
whatever notes you want on it
• Can be handwritten or computer printed
• You may use both the front and back
• No calculators, books, laptops, phones, or anything
besides your single page of notes may be used

• Kinds of questions to expect:
• Explain a program or part of a program
• Translate between "normal" expressions and their F#
equivalents
• Write your own code
• Fix incorrect code / find bugs in code
• Fill in the blank (in a program)
• Recursive walk-through step by step or step table fill-up

## Content

• Essentially, everything we've covered so far in the
semester, including:
• Basic syntax, arithmetic, string, and boolean operation
• Conditional branches in F#
• Variables and Functions
• Tuples and Lists
• Pattern Matching
• Recursive functions with pattern matching
• Tail Recursion

## Exercise 1

```F#
let evenOrOdd n =
  if n % 2 = 0 then
    "The number is even."
  else
    "The number is odd."
```

What is the above code doing? What is the input and
return type ? Give an example on how you call the
above function? What should the output look like in
terms of type of input and output?

The code above is evaluating if n is an odd or even number
using the modulus (%) operator.
The input is an integer and the output is a string.
To call the function: `evenOrOdd 5`.
If i were to input `2`, the output would be `"The number is even."`.
If I were to input 5, the output would be `"The number is odd."`.

## Exercise 2

The function should return the sum of all even integers in a
given list.

```F#
let rec sumEven list =
  match list with
  | [_] -> 0
  | h::t ->
    if h % 2 = 0 then
      h + sumEven t
    else
      sumEven h
```

What are the problems with the above code? Fix the errors.

1. The function calls an integer instead of the tail of the list. Causing an error.
2. The match statement never checks for an empty list.
   Add `| [] -> 0` to the start of the match statement.
3. In the match statement. `| [_] -> 0` does not check if
   the only value is an odd or even number.
   This can completely miss an even number from getting added to the result.
   Because we added `| [] -> 0` above.
   We can fix this issue by completely removing this line.

```F#
let rec sumEven list =
  match list with
  | [] -> 0
  | h :: t ->
    if h % 2 = 0 then
      h + sumEven t
    else
      sumEven t
```

## Exercise 3

What is wrong with the following code? Fix it.

```F#
// Recursive Fibonacci function with pattern matching
let rec fibonacci n =
  match n with
  | 0 -> 0
  | _ -> fibonacci (n-1) + fibonacci (n-2) // Recursive case
```

This code never adds any numbers, it is missing a case where n = 1.
Fix this by adding this line below the case n = 0:
`| 1 -> 1`
Leaving this unfixed will cause a stack overflow error.
If n = 1, Fibonacci (n-2) will result in -1. Which will never encounter 0.

## Exercise 4

Fill in the blank:

```F#
let rec sumPositive lst =
  match lst with
  | [] -> 0
  | head :: tail when _X_ > 0 -> _X_ + _X_tail // head is positive
  | _X_ :: tail -> sumPositive tail // head is 0 or negative
```

Result:

```F#
let rec sumPositive lst =
  match lst with
  | [] -> 0
  | head :: tail when head > 0 -> head + sumPositive tail // head is positive
  | _ :: tail -> sumPositive tail // head is 0 or negative
```

## Exercise

• Check if a list is sorted (ascending or descending)
• Remove an element from the list
• Concatenate two lists
• Count elements greater than average
• Write a function that takes two tuples (a, b) and (c, d)
and returns true if both have equal sums.
• Write a function that takes a 3-tuple (a, b, c) and
returns only the first and last elements.
• Given two pairs (a, b) and (c, d), return the larger sum
pair.

• swaps the two elements of a tuple
• Find if a element is present in the list
• Find maximum value in the list
• Sum of even numbers only
• Remove duplicates. Keep first occurrence ( you can use
List.contains
• Given a list of integers, return a new list where every 0
is replaced with 1.
• Given a list of strings, return how many strings have
length > 3.

## Wrap Up

• Review the previous slides and assignments
• Work through all the examples and exercises
• Use the page of notes as a study guide to help you prepare
for the exam
