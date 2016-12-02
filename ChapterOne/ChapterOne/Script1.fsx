let ints = [|1;2;3;4;5;6|]
let summedValue = ints |> Array.sum
let multiplied = ints |> Array.map (fun i -> i*2)
let multiplyByTwo x =
    x * 2
let multiplied' = ints |> Array.map (fun i -> multiplyByTwo i)
let isEven x = 
    match x % 2 = 0 with
    | true -> "even"
    | false -> "odd"
isEven 2
isEven 3
let multipliedAnIsEven =
    ints
    |> Array.map (fun i -> multiplyByTwo i)
    |> Array.map (fun i -> isEven i)