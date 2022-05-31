using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///Classe com os metodos (1=Inicializar,2=Entrar,3=Sair,4=Subir,5=Descer, menu,tela)
/// </summary>
namespace ProjetoElevador.Models
{
    public class Elevador
    {
        public int AndarAtual { get; set; }
        public int QuantidadePessoas { get; set; }
        public int CapacidadePessoas { get; set; }
        public int QuantidadeAndares { get; set; }
        public string Opcao { get; set; }

        /// <summary>
        /// INICIAR ELEVADOR VAZIO DO TÉRREO.
        /// </summary>
       


            public void Inicializar()
        {
           

            this.AndarAtual = 0;
            this.QuantidadePessoas = 0;
                        
            //Tela 1           
            Tela();

        }

        public void Tela()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ PAINEL DO ELEVADOR ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("            ╔════════════════════════════════════╗");
            Console.WriteLine("            ║ ANDAR ATUAL =                   {0}  ║", this.AndarAtual);
            Console.WriteLine("            ║ QUANTIDADE PESSOAS  =           {0}  ║", this.QuantidadePessoas);
            Console.WriteLine("            ╚════════════════════════════════════╝");
            Console.WriteLine("");            
            Console.WriteLine("            ╔════════════════════════════════════╗");
            Console.WriteLine("            ║ CAPACIDADE NO ELEVADOR  =       {0}  ║", this.CapacidadePessoas);
            Console.WriteLine("            ║ TOTAL DE ANDARES DO PREDIO  =   {0}  ║", this.QuantidadeAndares);
            Console.WriteLine("            ╚════════════════════════════════════╝");
            Console.WriteLine("");
        }
        /// <summary>
        ///Somar +1 ENTRAR NO ELEVADOR
        /// </summary>
        public void Entrar()
        {

            if (this.QuantidadePessoas < this.CapacidadePessoas)
            {
                
                this.QuantidadePessoas += 1;
                //Tela 2
                Tela();


            }
            else
            {                
                Tela();                
                Console.WriteLine("QUANTIDADE DE PESSOAS NO ELEVADOR: {0}", this.QuantidadePessoas);
                Console.WriteLine("ERRO!,O ELEVADOR ESTÁ NA CAPACIDADE MÁXIMA: {0}", this.CapacidadePessoas);
                Console.WriteLine("");
            }

        }

        /// <summary>
        /// Somar -1 SAIR DO ELEVADOR
        /// </summary>
        public void Sair()
        {

            if (this.QuantidadePessoas > 0)
            {
                
                this.QuantidadePessoas -= 1;
                //Tela 3
                Tela();

            }
            else
            {
                Tela();
                Console.WriteLine("QUANTIDADE DE PESSOAS: {0}", this.QuantidadePessoas);
                Console.WriteLine("ERRO!,ELEVADOR VAZIO");
                Console.WriteLine("");
            }
        }
        /// <summary>
        /// Somar +1 SUBIR ELEVADOR
        /// </summary>
        public void Subir()

        {

            if (this.AndarAtual < this.QuantidadeAndares)
            {

                
                this.AndarAtual += 1;
                //Tela 4
                Tela();


            }
            else
            {
                Tela();
                Console.WriteLine("ERRO!,O ELEVADOR CHEGOU NO ULTIMO ANDAR! ({0})", this.QuantidadeAndares);
                Console.WriteLine("");
                

            }

        }

        /// <summary>
        /// Soma -1 DESCER ELEVADOR
        /// </summary>
        public void Descer()
        {
            if (this.AndarAtual > 0)
            {

                this.AndarAtual -= 1;
                //Tela 5
                Tela();


            }
            else
            {
                Tela();
                Console.WriteLine("ERRO!, ESTE ANDAR É O TERREO! (0)");
                Console.WriteLine("");
                
            }

        }

        /// <summary>
        /// MENU DE INTERFACE DO USUARIO
        /// </summary>
        public void Menu()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ELEVADOR-PROJETO OCEAN 2022 ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("            ╔════════════════════════════════════╗");
            Console.WriteLine("            ║ INSIRA A QUANTIDADE DE ANDARES     ║");
            Console.WriteLine("            ║             DO PREDIO              ║");
            Console.WriteLine("            ╚════════════════════════════════════╝");
            Console.WriteLine("");
            Console.Write("DIGITE UM NUMERO : ");
            this.QuantidadeAndares = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ELEVADOR-PROJETO OCEAN 2022 ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("            ╔════════════════════════════════════╗");
            Console.WriteLine("            ║ INSIRA A CAPACIDADE DE PESSOAS     ║");
            Console.WriteLine("            ║             DO ELEVADOR            ║");
            Console.WriteLine("            ╚════════════════════════════════════╝");
            Console.WriteLine("");
            Console.Write("DIGITE UM NUMERO : ");
            this.CapacidadePessoas = int.Parse(Console.ReadLine());
            Console.Clear();



            bool continuar = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ ELEVADOR-PROJETO OCEAN 2022 ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");

                Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");

                Console.WriteLine("║ 1 - INICIAR                                   ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 2 - ENTRAR                                    ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 3 - SAIR                                      ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 4 - SUBIR                                     ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 5 - DESCER                                    ║    ");

                Console.WriteLine("║                                               ║    ");

                Console.WriteLine("║ 6 - FINALIZAR PROGRAMA                        ║    ");

                Console.WriteLine("╚═══════════════════════════════════════════════╝    ");

                Console.WriteLine(" ");


                Console.Write("DIGITE UMA OPÇÃO : ");

                this.Opcao = Console.ReadLine();

                Console.Clear();

                switch (this.Opcao)
                {
                    case "1":
                        this.Inicializar();
                        break;

                    case "2":
                        this.Entrar();
                        break;

                    case "3":
                        this.Sair();
                        break;

                    case "4":
                        this.Subir();
                        break;

                    case "5":
                        this.Descer();
                        break;

                    case "6":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("ERRO!,NÃO EXISTE ESSA OPÇÃO , Escolher somente entre 1 e 6.");
                        break;


                }


            }

            while (continuar);
        }
    }
}