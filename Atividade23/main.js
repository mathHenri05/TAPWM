function reverso(texto) {
    var caracteres = texto.split("");
    var caracteresInvertidos = caracteres.reverse();
    var textoInvertido = caracteresInvertidos.join("");
    return textoInvertido;
}
console.log(reverso("A rua sinuosa da colina morena, conduzia até a cena perfeita."));