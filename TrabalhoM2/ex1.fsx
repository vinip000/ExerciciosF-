let a = 10
let b = 30

let verificarMaior a b =
    if a > b then
        a / b
    else
        b / a

printfn "A divisão do maior pelo menor é: %d" (verificarMaior a b)