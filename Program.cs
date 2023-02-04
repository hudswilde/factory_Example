using System;

namespace PadraoProjetos.FactoryMethods.Exemplo
{

    abstract class Criador{
        public abstract IProduto FactoryMethod();

        public string AlgumaOperacao()
        {
            var produto = FactoryMethod();
            var resultado = "criador : o codigo do mesmo criador acabou de trabalhar com  " + product.Operation();
            return resultado;
        }

    }

    public class CriadorConcreto1 : Criador
    {
        public override IProduto FactoryMethod()
        {
            return ProdutoConcreto1();
        }
    }

      public class CriadorConcreto2 : Criador
    {
        public override IProduto FactoryMethod()
        {
            return ProdutoConcreto2();
        }
    }

    public interface IProduto{
        string Operacao();
    }

    public ProdutoConcreto1 : produto{
        
        public string Operacao(){
            return "Resultado do produto concreto 1";
        }
    }

     public ProdutoConcreto2 : produto{
        
        public string Operacao(){
            return "Resultado do produto concreto 2";
        }
    }

    class Cliente{
        
        public void Main()
        {
            Console.WriteLine("Rodando Criador Conreto 1.");
            ClientCode(new CriadorConcreto1());
            
            Console.WriteLine("");

            Console.WriteLine("Rodando Criador Concreto 2");
            ClientCode(new CriadorConcreto2());
        }

        public void ClientCode(Criador criador)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + criador.AlgumaOperacao());
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }

}