let lista = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14; 15; 16; 17; 18; 19; 20]

let pares lista =
    let par numero = numero % 2 = 0
    lista |> List.filter par

let paresMultiplicadosPor2 lista =
    pares lista |> List.map (fun x -> x * 2)

let divisivelPor6 numero =
    numero % 6 = 0

printfn "Pares na lista: %A" (pares lista)
printfn "Pares multiplicados por 2: %A" (paresMultiplicadosPor2 lista)
printfn "Números pares divisíveis por 6: %A" (pares lista |> List.filter divisivelPor6)