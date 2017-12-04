module Day2
open System.IO
let readLines (filePath : string) = seq {
    use sr = new StreamReader (filePath)
    while not sr.EndOfStream do
        yield sr.ReadLine ()
}
let getDifference digits =    
    Seq.max digits - Seq.min digits

let parseLines lines calc = 
    let result = Seq.sumBy (fun (x : string) -> x.Split('\t') 
                                             |> Seq.map (string >> int)
                                             |> calc) lines
    result |> string
let readInputFile = 
    Seq.toArray <| readLines(System.IO.Path.Combine(System.Environment.CurrentDirectory, @"Day2\Input.txt"))

let part1 =
    parseLines readInputFile getDifference

let part2 = 
    parseLines readInputFile getDifference
     