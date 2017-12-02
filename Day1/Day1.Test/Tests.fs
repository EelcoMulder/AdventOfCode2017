module Tests

open Day1
open Xunit

[<Theory>]
[<InlineData("1122", 3)>]
[<InlineData("1111", 4)>]
[<InlineData("1234", 0)>]
[<InlineData("91212129", 9)>]
let ``Day1_Part1_WhenParsingInput_ItShouldReturnCorrectResult`` (input, expected) =
    let result = calculateCaptchaPart1 input
    Assert.Equal(expected, result)

[<Theory>]
[<InlineData("1212", 6)>]
[<InlineData("1221", 0)>]
[<InlineData("123425", 4)>]
[<InlineData("123123", 12)>]
[<InlineData("12131415", 4)>]
let ``Day1_Part2_WhenParsingInput_ItShouldReturnCorrectResult`` (input, expected) =
    let result = calculateCaptchaPart2 input
    Assert.Equal(expected, result)
