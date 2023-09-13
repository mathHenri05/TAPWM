while (true) {
    var jogador1 = prompt("Jogador 1: Digite pedra, papel ou tesoura");
    var jogador2 = prompt("Jogador 2: Digite pedra, papel ou tesoura");
  
    jogador1 = jogador1.toLowerCase(); // Converter para minúsculas para tornar a comparação não sensível a maiúsculas
  
    if (jogador1 === jogador2) {
      alert("Empate");
    } else if (
      (jogador1 === "pedra" && jogador2 === "tesoura") ||
      (jogador1 === "tesoura" && jogador2 === "papel") ||
      (jogador1 === "papel" && jogador2 === "pedra")
    ) {
      alert("Jogador 1 vence!");
    } else {
      alert("Jogador 2 vence!");
    }
  
    var continuar = prompt("Deseja jogar novamente? (s/n)").toLowerCase();
    if (continuar !== "s") {
      break; 
    }
  }
  
