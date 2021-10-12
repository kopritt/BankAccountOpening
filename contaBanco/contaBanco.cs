using System;

namespace conta
{
    public class contaBanco
    {
        //ATRIBUTOS
        public int numConta;
        protected String tipo;
        private String dono;
        private double saldo;
        private bool status;

        //MÉTODOS

        public void estadoAtual(){
            Console.WriteLine("------------------------------");
            Console.WriteLine("Conta: " + this.getNumConta());
            Console.WriteLine("Dono: " + this.getDono());
            Console.WriteLine("Tipo: " + this.getTipo());
            Console.WriteLine("Status: " + this.getStatus());
            Console.WriteLine("Saldo:" + this.getSaldo());
        }


        public void abrirConta(String t){
            this.setTipo(t);
            this.setStatus(true);
            if(t == "cc"){
                this.setSaldo(50);
            }else if(t == "cp") {
                this.setSaldo(150);
            }
            Console.WriteLine("Conta Aberta com Sucesso!");


        }

        public void fecharConta(){
            if(this.getSaldo() > 0){
                Console.WriteLine("Conta com Dinheiro");
            }else if(getSaldo() < 0){
                Console.WriteLine("Conta em Débito");
            }else{
                this.setStatus(false);
            }
             Console.WriteLine("Conta Fechada com Sucesso!");
        }

        public void depositar(double v){
            if(this.getStatus() is true){
                this.setSaldo(getSaldo() + v);
                Console.WriteLine("Depósito Realizado");
            }else{
                Console.WriteLine("Impossível depositar");
            }
            
        }

        public void sacar(double v){
            if(this.getStatus() is true){
                if(this.getSaldo() >= v){
                     this.setSaldo(this.getSaldo() - v);
                }else{
                    Console.WriteLine("Saldo Insuficiente");
                }
            }else{
                Console.WriteLine("Conta Fechada, impossível sacar");
            }
            
        }

        public void pagarMensal(){
            int v = 0;
            if(this.getTipo() == "cc"){
                v = 12;
            }else if(this.getTipo() == "cp"){
                v = 20;
            }
            if(this.getStatus() == true){
                if(this.getSaldo() > v){
                    this.setSaldo(this.getSaldo() - v);
                }else{
                    Console.WriteLine("Saldo Insuficiente");
                }
            }else{
                Console.WriteLine("Impossível pagar");
            }
        }

        //////////////////////////////////////Construtor/////////////////////////////////////////////
        public contaBanco(){

        }

        ////////////////////////////////////Getters e Setters///////////////////////////////////////
        public void setNumConta(int n){
            this.numConta = n;
        }
        public int getNumConta(){
            return this.numConta;
        }

        public void setTipo(String t){
            this.tipo = t;
        }
        public String getTipo(){
            return this.tipo;
        }

        public void setDono(String d){
            this.dono = d;
        }
        public String getDono(){
            return this.dono;
        }
        
        public void setSaldo(double s){
            this.saldo = s;
        }
        public double getSaldo(){
            return this.saldo;
        }
        
        public void setStatus(bool st){
            this.status = st;
        }
        public bool getStatus(){
            return this.status;
        }




        
    }
}