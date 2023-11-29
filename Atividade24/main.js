function dividir(a, b) {
    let divisao = a / b;
   
    if (IsNan(divisao)) {
       console.log("Divisão deu NaN");
    } else if (!IsFinite(divisao)) {
       console.log("Divisão de Infinity");
    } else {
       return divisao;
    }
   }
   
   // Testes
   console.log(dividir(10, 2)); // Retorna 5
   console.log(dividir(5, 0)); // Retorna "Divisão de Infinity"
   console.log(dividir(5, "")); // Retorna "Divisão deu NaN"
   console.log(dividir(0, 0)); // Retorna 0
   console.log(dividir(null, 5)); // Retorna 0
   console.log(dividir(5, null)); // Retorna Infinity
   console.log(dividir(null, null)); // Retorna NaN