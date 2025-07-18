let lista = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14; 15; 16; 17; 18; 19; 20]

let rec verificarPrimo numero d = 
    match numero with
    | 1 -> false  // <- regra explícita: 1 não é primo
    | _ ->
        match d with
        | _ when d * d > numero -> true  
        | _ when numero % d = 0 -> false  
        | _ -> verificarPrimo numero (d + 1)

let rec somaDosPrimos lista1 =
    match lista1 with
    | [] -> 0  
    | head :: tail when verificarPrimo head 2 -> head + somaDosPrimos tail
    | head :: tail -> somaDosPrimos tail

printfn "Soma dos números primos na lista: %d" (somaDosPrimos lista)