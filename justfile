@run project: 
    echo "Running F# project {{project}}\n\n"
    dotnet run --project {{project}}

@fsi: 
    echo "Running F# interactive terminal"
    dotnet fsi

@new project: 
    echo "Creating new project {{project}}"
    dotnet new console -lang "F#" -o {{project}}