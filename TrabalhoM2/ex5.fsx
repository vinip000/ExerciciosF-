let lista = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]

let rec multiplicaImpares lista1 =
    match lista1 with
    | [] -> 1  
    | head :: tail when head % 2 <> 0 -> head * multiplicaImpares tail
    | head :: tail -> multiplicaImpares tail
       

printfn "Produto dos ímpares: %d" (multiplicaImpares lista)