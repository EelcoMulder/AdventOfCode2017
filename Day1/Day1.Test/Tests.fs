module Tests

open Day1
open System
open Xunit

[<Theory>]
[<InlineData(1122, 3)>]
[<InlineData(1111, 4)>]
[<InlineData(1234, 0)>]
[<InlineData(91212129, 9)>]
let ``Day1_WhenParsingInput_ItShouldReturnCorrectResult`` (input, expected) =
    let result = calculateCaptcha input
    Assert.Equal(expected, result)
