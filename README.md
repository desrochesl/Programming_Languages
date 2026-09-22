# Operating Systems

This is a compilation of my classwork in Programming Languages. 

We are using F# to learn about different types of programming languages. In my opinion, F# has an incredibly weird syntax. 

the `let` keyword is used to create variables, and functions. 

## Usage

### dotnet
```sh
dotnet run --project {{project_dir}} # dotnet run gives the user more options than the justfile. Use justfile if you just need to run the project. 

dotnet fsi

# Create a new F# project
dotnet new console -lang "F#" -o {{project_name}}
```

### Justfile
```sh
# Run the project file using dotnet
just run {{project_dir}}

# Open F# interactive cli  
just fsi

# Create a new F# project
just new {{project_name}}
```

## Projects
### Lab 1
**Functions**:
- addTwo
- isNonPositive
- isEven
- isNonZero

These functions are simple programming exercises to get used to a language. We use mathematical and boolean operators to solve simple problems in F#. 

**Function Syntax**:
```F#
let addTwo a: int b: int = a + b

[<EntryPoint>]
let main argv = 
    addTwo 1 5
    0
```