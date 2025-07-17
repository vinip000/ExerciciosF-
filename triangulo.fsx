//Faça uma função que receba 3 numeros e retorne se eles formam um triângulo isósceles, equilátero ou escaleno
let a = 5   
let b = 5
let c = 5

let tipoTriangulo x y z =
    if x = y && y = z then
        "Equilátero"
    elif x = y || y = z || x = z then
        "Isósceles"
    else
        "Escaleno"

let resultado = tipoTriangulo a b c

printfn "Os lados %d, %d e %d formam um triângulo %s" a b c resultado