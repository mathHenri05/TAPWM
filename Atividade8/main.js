var somaIdades = 0;
var idadeMaisVelha = -1;
var idadeMaisNova = 999;
var quantidadePessimo = 0;
var quantidadeOtimoBom = 0;
var quantidadeMulheres = 0;
var quantidadeHomens = 0;

var numeroPessoas = parseInt(prompt("Quantas pessoas responderam ao questionário?"));

for (var i = 0; i < numeroPessoas; i++) {
    var idade = parseInt(prompt("Informe a idade da pessoa " + (i + 1)));
    var sexo = prompt("Informe o sexo da pessoa " + (i + 1) + " (M/F)").toUpperCase();
    var opiniao = parseInt(prompt("Informe a opinião da pessoa " + (i + 1) + " (Ótimo=4, Bom=3, Regular=2, Péssimo=1)"));

    somaIdades += idade;

    if (idade > idadeMaisVelha) {
        idadeMaisVelha = idade;
    }
    if (idade < idadeMaisNova) {
        idadeMaisNova = idade;
    }

    if (opiniao === 1) {
        quantidadePessimo++;
    }

    if (opiniao === 3 || opiniao === 4) {
        quantidadeOtimoBom++;
    }

    if (sexo === 'F') {
        quantidadeMulheres++;
    } else if (sexo === 'M') {
        quantidadeHomens++;
    }
}

var mediaIdades = somaIdades / numeroPessoas;
var porcentagemOtimoBom = (quantidadeOtimoBom / numeroPessoas) * 100;

alert('Média das idades: ' + mediaIdades);
alert('Idade da pessoa mais velha: ' + idadeMaisVelha);
alert('Idade da pessoa mais nova: ' + idadeMaisNova);
alert('Quantidade de pessoas que responderam péssimo: ' + quantidadePessimo);
alert('Porcentagem de pessoas que responderam ótimo e bom: ' + porcentagemOtimoBom + '%');
alert('Número de mulheres que responderam ao questionário: ' + quantidadeMulheres);
alert('Número de homens que responderam ao questionário: ' + quantidadeHomens);
