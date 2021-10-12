using System;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            contaBanco p1 = new contaBanco();
            p1.setNumConta(1111);
            p1.setDono("Jubileu");
            p1.abrirConta("cc");

            contaBanco p2 = new contaBanco();
            p2.setNumConta(2222);
            p2.setDono("Creuza");
            p2.abrirConta("cp");

            p1.depositar(100);
            p2.depositar(500);

            p2.sacar(100);

            p1.estadoAtual();
            p2.estadoAtual();
        }
    }
}
