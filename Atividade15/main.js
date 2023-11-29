function inicio(){
    document.getElementById("texto").innerHTML = "Janela Fechada";
    document.getElementById('imagem').src = "janela-fechada.jpeg";
}

function abre(){
    document.getElementById('imagem').src = "janela-aberta.jpeg";
    document.getElementById("texto").innerHTML = "Janela aberta";
}
function fecha(){
    document.getElementById('imagem').src = "fechada.jpeg";
    document.getElementById("texto").innerHTML = "Janela Fechada";
}
function quebra(){
    document.getElementById('imagem').src = "janela-quebrada.jpeg";
    document.getElementById("texto").innerHTML = "Janela Quebrada";
}