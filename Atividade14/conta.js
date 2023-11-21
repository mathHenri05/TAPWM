//Classe base Conta
class Conta {
    constructor(nomecorrentista, banco, numeroDaConta, saldo) {
       this.nomecorrentista = nomecorrentista;
       this.banco = banco;
       this.numeroDaConta = numeroDaConta;
       this.saldo = saldo;
    }
   
    //Métodos get e set
    get nomecorrentista() {
       return this._nomecorrentista;
    }
   
    set nomecorrentista(nomecorrentista) {
       this._nomecorrentista = nomecorrentista;
    }
   
    get banco() {
       return this._banco;
    }
   
    set banco(banco) {
       this._banco = banco;
    }
   
    get numeroDaConta() {
       return this._numeroDaConta;
    }
   
    set numeroDaConta(numeroDaConta) {
       this._numeroDaConta = numeroDaConta;
    }
   
    get saldo() {
       return this._saldo;
    }
   
    set saldo(saldo) {
       this._saldo = saldo;
    }
   }
   
   //Classe Corrente
   class Corrente extends Conta {
    constructor(nomecorrentista, banco, numeroDaConta, saldo, saldoEspecial) {
       super(nomecorrentista, banco, numeroDaConta, saldo);
       this.saldoEspecial = saldoEspecial;
    }
   
    get saldoEspecial() {
       return this._saldoEspecial;
    }
   
    set saldoEspecial(saldoEspecial) {
       this._saldoEspecial = saldoEspecial;
    }
   }
   
   //Classe Poupanca
   class Poupanca extends Conta {
    constructor(nomecorrentista, banco, numeroDaConta, saldo, juros, dataVencimento) {
       super(nomecorrentista, banco, numeroDaConta, saldo);
       this.juros = juros;
       this.dataVencimento = dataVencimento;
    }
   
    get juros() {
       return this._juros;
    }
   
    set juros(juros) {
       this._juros = juros;
    }
   
    get dataVencimento() {
       return this._dataVencimento;
    }
   
    set dataVencimento(dataVencimento) {
       this._dataVencimento = dataVencimento;
    }
   }
   
   //Criando objetos de cada classe
   const corrente = new Corrente('João', 'Banco do Brasil', '1234-5', 1000, 500);
   const poupanca = new Poupanca('Maria', 'Caixa Econômica', '5678-9', 2000, 2, '15/08/2023');
   
   //Mostrando os dados dos objetos
   console.log('Corrente: ', corrente);
   console.log('Poupanca: ', poupanca);