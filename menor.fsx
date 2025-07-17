//Faça uma que receba 3 valores e retorne o menor deles
let a = 1
let b = 5
let c = 20

let menor x y z =
    if x < y && x < z then
        x
    elif y < x && y < z then
        y
    else
        z

let resultado = menor a b c

printfn "O menor valor entre %d, %d e %d é %d" a b c resultado