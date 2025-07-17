//faça uma função em F# que dado um valor escreve seu valor absoluto (sem sinal)

let a = -5
let valorAbsoluto a =
    if a < 0 then a * -1 else a

let resultado = valorAbsoluto a

printfn "O valor absoluto é %d" resultado  