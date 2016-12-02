open System

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    let x = "Hello World"
    Console.WriteLine(x)
    let y = Console.ReadKey()
    0 // return an integer exit code
