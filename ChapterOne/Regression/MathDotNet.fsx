let input = [|1,1.;2,2.;3,2.25;4,4.75;5,5.|]

let x = input |> Array.map(fun (x,y) -> float x)
let y = input |> Array.map(fun(x,y) -> float y)
let mX = Array.average x
let mY = Array.average y

#r "../packages/MathNet.Numerics.3.13.1/lib/net40/MathNet.Numerics.dll"
open MathNet.Numerics.Statistics

let sX = ArrayStatistics.StandardDeviation x
let sY = ArrayStatistics.StandardDeviation y

let r = Correlation.Pearson (x,y)

let b = r*(sY/sX)
let A = mY - b*mX

open MathNet.Numerics
let fit = Fit.Line(x,y) //<- fit is a tuple (intercept,slope)
let i = fst fit //<- fst is "first" as in c# tuple.Item1
let s = snd fit //<- snd is "second" as in c# tuple.Item2