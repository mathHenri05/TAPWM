function Retangulo(base, altura) {
    this.base = base;
    this.altura = altura;
    this.area = function() {
      return this.base * this.altura;
    };
  }
  
  var retangulo1 = new Retangulo(5, 10);
  console.log(retangulo1.area()); // Output: 50
  