module Day1

let getIndexValue (index, step, digits : int[]) =
    if (digits.[index] = digits.[index + step]) then digits.[index] else 0

let convertToIntArray d = 
    d |> Seq.map (fun d -> (System.Char.GetNumericValue d) |> int)
    |> Seq.toArray    

let calculateCaptcha digitsString step = 
    let digits = convertToIntArray digitsString 
    let doubleByteArray = Array.append digits digits
    let total =
        digits |> Seq.mapi (fun idx _ -> getIndexValue(idx, step, doubleByteArray))
        |> Seq.sum
    total |> string

let calculateCaptchaPart1 (digitsString : string) =
    calculateCaptcha digitsString 1

let calculateCaptchaPart2 (digitsString : string) = 
    calculateCaptcha digitsString ((String.length digitsString) / 2)
