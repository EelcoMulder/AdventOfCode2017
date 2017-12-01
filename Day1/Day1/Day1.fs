module Day1

let determineValue (index : int, numberArray : string) =
    match (index < String.length numberArray - 1) && numberArray.[index] = numberArray.[index + 1] with
    | true -> System.Char.GetNumericValue numberArray.[index]
    | false -> 0.0

let calculateCaptcha (i : string) =
    let cv = 
        match i.[0] = i.[String.length i - 1] with
        | true ->  (System.Char.GetNumericValue i.[0])
        | false -> 0.0

    let total =
        i |> Seq.mapi (fun idx _ -> determineValue(idx, i)) 
        |> Seq.sum
    (total + cv) |> string