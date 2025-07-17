let numeros = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]  // ponto e vírgula é ok em F#

let somaDosQuadrados numeros =
    numeros
    |> List.map (fun x -> x * x)
    |> List.sum

let resultado = somaDosQuadrados numeros

printfn "A soma dos quadrados de 1 a 10 é %d" resultado
