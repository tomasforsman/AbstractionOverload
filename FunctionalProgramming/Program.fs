open System
open System.IO

[<EntryPoint>]
let main argv =
    let filePath = "example.txt"
    
    let readFile path =
        try
            if File.Exists(path) then
                Some(File.ReadAllText(path))
            else
                None
        with
        | :? IOException as ex -> 
            printfn "An I/O error occurred: %s" ex.Message
            None

    let printContent content =
        match content with
        | Some text -> printfn "%s" text
        | None -> printfn "File not found."

    filePath
    |> readFile
    |> printContent
    
    0 // return an integer exit code
