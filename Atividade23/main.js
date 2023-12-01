function procura(texto) {
    let contagem = 0;
    for (let i = 0; i < texto.length; i++) {
        if (texto[i] === 'A' || texto[i] === 'a') {
            contagem++;
        }
    }
    return contagem;
}
console.log(procura("A cara vermelha."));
console.log(procura("Bruna Caraça, cheia de confiança."));
console.log(procura("E eu fui o A em meu novo job."));
