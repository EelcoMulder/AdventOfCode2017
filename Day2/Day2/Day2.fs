module Day2
open System.IO
let readLines (filePath : string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}
let getDifference digits =    
    Seq.max digits - Seq.min digits

let parseLines lines = 
    let result = Seq.sumBy (fun (x : string) -> x.Split('\t') 
                                             |> Seq.map (string >> int)
                                             |> getDifference) lines
    result |> string
let readInputFile = 
    let lines = readLines(System.IO.Path.Combine(System.Environment.CurrentDirectory, @"Day2\Input.txt"))
    let result = parseLines lines
    printf "Result %s" result
    result
