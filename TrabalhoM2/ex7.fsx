
let a = 17

let rec verificarPrimo numero d = 
    match numero with
    | 1 -> false  // <- regra explícita: 1 não é primo
    | _ ->
        match d with
        | _ when d * d > numero -> true  
        | _ when numero % d = 0 -> false  
        | _ -> verificarPrimo numero (d + 1)

   
printfn "O número %d é primo? %b" a (verificarPrimo a   2)