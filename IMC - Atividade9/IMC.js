function calcularImc(altura, peso) {
    return (Math.round(10 * peso / (altura ** 2))) / 10;
}

var altura = prompt("Qual a sua altura: ");
var peso_atual = prompt("Qual o seu peso: ");

var imc = calcularImc(altura, peso_atual);

if (imc <= 18.5) {
    alert("Seu IMC é " + Math.round(imc) + ". Você está abaixo do peso!");
} else if (imc >= 18.5 && imc <= 24.9) {
    alert("Seu IMC é " + Math.round(imc) + ". Você está com o peso ideal!");
} else if (imc >= 25 && imc <= 29.9) {
    alert("Seu IMC é " + Math.round(imc) + ". Você está acima do peso ideal!");
} else if (imc >= 30) {
    alert("Seu IMC é " + Math.round(imc) + ". Você está obeso!");
}
