class Retangulo {
    constructor(x, y) {
       this.x = x;
       this.y = y;
    }
   
    calcularArea() {
       return this.x * this.y;
    }
   }
   
   let retangulo = new Retangulo(4, 5);
   console.log(retangulo.calcularArea()); 