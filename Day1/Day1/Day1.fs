module Day1
open System.Text

let getIndexValue index step digits =
    match (index < Array.length digits - 1) && digits.[index] = digits.[index + step] with
    | true -> digits.[index]
    | false -> 0uy

let calculateCaptcha (digitsString) =
    let bytes = digitsString 
                |> Seq.map (fun d -> (System.Char.GetNumericValue d) |> byte)
                |> Seq.toArray

    let cv = getIndexValue 0 ((Array.length bytes) - 1) bytes
    
    let total =
        bytes |> Seq.mapi (fun idx _ -> getIndexValue idx 1 bytes)
        |> Seq.sum
    (total + cv)

// use local functions
// Part 2!!



