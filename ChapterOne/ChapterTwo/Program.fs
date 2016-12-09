type Point = 
    | X

type Shape =
    | Rectangle of Point * Point
    | Ellipse of Point * Point
    | Composed of Shape * Shape

match shape with
| Rectangle(pfrom, pto) ->
    rectangleArea