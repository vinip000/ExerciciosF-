//faça uma função em F# que dado um valor escreve seu valor absoluto (sem sinal)

let a = -10
let valorAbsoluto x =
    if x < 0 then -x else x

let resultado = valorAbsoluto a

printfn "O valor absoluto é %d" resultado  