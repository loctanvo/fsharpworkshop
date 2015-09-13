//open System

//--- FUNCTIONS ---

//let sum num1 num2 = num1 + num2
//let summed = sum 1 2

//--- TUPLES ---

//let divide dividend divisor =
//    let quotient = dividend / divisor
//    let remainder = dividend % divisor
//    (quotient, remainder)
//
//let quotient, remainder = divide 10 3
//
//let success, value = Int32.TryParse("42")

//--- RECORDS ---

//type DivisionResult =
//    { Quotient:int
//      Remainder:int }
//
//let result = { Quotient = 3; Remainder = 1 }
//let newResult = { Quotient = result.Quotient; Remainder = 0 }
//let antoherNewResult = { result with Remainder = 0 }
//
//let result1 = { Quotient = 3; Remainder = 1 }
//let result2 = { Quotient = 3; Remainder = 1 }
//result1 = result2
