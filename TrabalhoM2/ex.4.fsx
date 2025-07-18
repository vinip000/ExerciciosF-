
let resultadoNotas () =

    let calcularMedia (n1: float) (n2: float) (n3: float) =
        (n1 + n2 + n3) / 3.0

    let verificarAprovacao (media: float) =
        media >= 6.0

   
    let exibirResultado (media: float) (aprovado: bool) =
        let status = if aprovado then "APROVADO" else "REPROVADO"
        printfn "Média: %.2f - Status: %s" media status

    
    printf "Digite a primeira nota: "
    let nota1 = System.Console.ReadLine() |> float

    printf "Digite a segunda nota: "
    let nota2 = System.Console.ReadLine() |> float

    printf "Digite a terceira nota: "
    let nota3 = System.Console.ReadLine() |> float

    
    let media = calcularMedia nota1 nota2 nota3
    let aprovado = verificarAprovacao media


    exibirResultado media aprovado

resultadoNotas ()