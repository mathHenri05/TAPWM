   function dividir(a, b) {
    if (isNaN(a / b)) {
        console.log("Divisão resultou NaN");
    } else if (!isFinite(a / b)) {
        console.log("Divisão de Infinity");
    } else {
        return a / b;
    }
}

console.log(dividir(1, 0));      // Deve imprimir "Divisão de Infinity"
console.log(dividir(0, 0));      // Deve imprimir "Divisão deu NaN"
console.log(dividir(1, Infinity)); // Deve imprimir "Divisão de Infinity"
console.log(dividir(1, 2));      // Deve imprimir o resultado da divisão
