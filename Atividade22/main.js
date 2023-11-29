function ordena(num1, num2, num3, num4, num5) {
    var numeros = [num1, num2, num3, num4, num5];
    numeros.sort(function(a, b) {
        return b - a;
    });
    return numeros;
}
console.log(ordena(3, 1, 5, 8, 4));