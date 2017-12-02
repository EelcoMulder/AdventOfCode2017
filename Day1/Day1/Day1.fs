module Day1
open System.Text

let getIndexValue index step digits =
    match (index < Array.length digits - 1) && digits.[index] = digits.[index + step] with
    | true -> digits.[index]
    | false -> 0

let convertToIntArray d = 
    d |> Seq.map (fun d -> (System.Char.GetNumericValue d) |> int)
    |> Seq.toArray    

let calculateCaptchaPart1 (digitsString : string) =
    let digits = convertToIntArray digitsString 

    let cv = getIndexValue 0 ((Array.length digits) - 1) digits |> int
    
    let total =
        digits |> Seq.mapi (fun idx _ -> getIndexValue idx 1 digits)
        |> Seq.sum |> int
    total + cv

// use local functions
let calculateCaptchaPart2 (digitsString : string) = 
    let digits = convertToIntArray digitsString 
    let step = (Array.length digits) / 2
    let doubleByteArray = Array.append digits digits
    let total =
        digits |> Seq.mapi (fun idx _ -> getIndexValue idx step doubleByteArray)
        |> Seq.sum
    total

