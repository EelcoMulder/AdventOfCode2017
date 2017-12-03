module Tests

open Xunit
open Day2

[<Fact>]
let ``My test`` () =
    let file = [|"5\t1\t9\t5"; "7\t5\t3"; "2\t4\t6\t8"|]
    let result = parseLines file
    let a = result = "18"
    Assert.True(a)
