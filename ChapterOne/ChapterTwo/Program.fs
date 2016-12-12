type Point = 
    | X

type Shape =
    | Rectangle of Point * Point
    | Ellipse of Point * Point
    | Composed of Shape * Shape

match shape with
| Rectangle(pfrom, pto) ->
    rectangleArea

let withItem2 newItem2 tuple =
    let (origItem1, origItem2) = tuple
    (origItem1,newItem2)

let old = ("old",1)
let nw = withItem2 (snd(old) + 1) old

let withItm2 newItem2 (origItem1, _) = (origItem1, newItem2)

let newest = withItm2 12 nw

let withAitum2 newIteme2 tuple =
    match tuple with
    | (origItem1, _) -> (origItem1, newIteme2)

let future = withAitum2 1337 newest

//different list initializations

let lst1 = []

let lst2 = 6::2::7::3::[]

let lst3 = [6;2;7;3]

let lst4 = [1..5]

let lst5 = 0::lst4
