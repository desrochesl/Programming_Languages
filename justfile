@run project: 
    echo "Running F# project {{project}}\n"
    dotnet run --project {{project}}

@fsi: 
    echo "Running F# interactive terminal\n"
    dotnet fsi

@fsx file_path: 
    echo "Running F# file {{file_path}}\n"
    dotnet fsi {{file_path}}

@new project: 
    echo "Creating new project {{project}}\n"
    dotnet new console -lang "F#" -o {{project}}