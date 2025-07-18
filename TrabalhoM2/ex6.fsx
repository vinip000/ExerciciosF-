let a = 3
let b = 2

let rec potencia baseNum expoente =
    match expoente with
    | 0 -> 1  
    | 1 -> baseNum  
    | n when n > 0 -> baseNum * potencia baseNum (n - 1)  
    | _ -> 0  // Caso expoente seja negativo, retorna 0
let compararEElevar valor1 valor2 =
    match (valor1, valor2) with
    | (a, b) when a = b -> potencia (a * 2) 2 
    | (a, b) when a <> b -> potencia a b  
    | _ -> 0  

printfn "Resultado: %d" (compararEElevar a b)