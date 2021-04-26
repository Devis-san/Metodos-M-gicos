using System;
using System.Collections.Generic;


public class Item
{
    public string INome;
    public int Identificador;
    public int Valor;
    public string Detalhes;
}


public class Player
{
    public string PNome;
    public int EXP;
    public int Ouro;
    public List<Item> Itens = new List<Item>();
}



public class Trabalho
{



    static List<Player> Players = new List<Player>();






    public static void Main(string[] args)
    {


        bool MostrarMenu = true;
        while (MostrarMenu)
        {
            MostrarMenu = MenuPrincipal();
        }

    }




    private static void CriarPlayer()
    {

        Console.Clear();
        Console.Write("Insira um Nickname : ");
        var NomePlayer = Console.ReadLine();
        NomePlayer = NomePlayer.ToLower();


        Console.Write("Insira uma quantidade de experiência: ");
        var EXPPlayer = Console.ReadLine();

        Random GetEXP = new Random();
        var OuroPlayer = GetEXP.Next(50, 350);


        Players.Add(new Player { PNome = NomePlayer, EXP = Convert.ToInt32(EXPPlayer), Ouro = OuroPlayer });
        Console.Clear();
        Console.WriteLine("Jogador criado com sucesso");
        Console.WriteLine("");
        Console.WriteLine("Adicionamos $" + OuroPlayer + " de ouro na sua conta");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.Read();

    }




    private static void VerPlayer()
    {

        Console.Clear();
        for (int i = 0; i < Players.Count; i++)
        {

            Console.WriteLine("");
            Console.WriteLine("Jogador:");
            Console.WriteLine("Nickname : " + Players[i].PNome);
            Console.WriteLine("Experiência : " + Players[i].EXP);
            Console.WriteLine("Ouro : " + Players[i].Ouro);
            Console.WriteLine("");
        }//END FOR

        Console.WriteLine("");
        Console.Write("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }






    private static void OlharInventário()
    {

        Console.Clear();
        Console.WriteLine("Digite o nome do jogador para verificar o iventário:");
        var NomePlayer = Console.ReadLine();
        NomePlayer = NomePlayer.ToLower();
        foreach (Player p in Players)
        {
            if (p.PNome == NomePlayer)
            {
                Console.WriteLine("");
                Console.WriteLine("Itens:");
                Console.WriteLine("");
                for (int i = 0; i < p.Itens.Count; i++)
                {
                    Console.WriteLine("Item: " + p.Itens[i].INome);
                }//END FOR
                Console.WriteLine("");
                Console.WriteLine("Entre com qualquer tecla para continuar");
                Console.Read();
            }//END IF
            else
            {
                Console.Clear();
                Console.WriteLine("Nenhum jogador encontrado... Retornando ao menu principal");
                Console.Read();
            }//END ELSE
        }//END FOREACH

    }



    private static void Gerência(

        Item Punhal_Do_Louco_Manager,
        Item Manoplas_Do_Dragão_Manager,
        Item Cetro_De_Rá_Manager,
        Item Lemegeton_Manager,
        Item Espada_Matadora_De_Deuses_Manager,
        Item Lâminas_Do_Caos_Manager,
        Item Lanche_Da_Mamãe_Manager

        )
    {




        Console.Clear();
        Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
        var NomePlayer = Console.ReadLine();
        NomePlayer = NomePlayer.ToLower();


        foreach (Player p in Players)
        {
            if (p.PNome == NomePlayer)
            {
                Console.WriteLine("- Insira o ID do item que você espera comprar:");
                Console.WriteLine("");
                Console.WriteLine(Punhal_Do_Louco_Manager.Identificador + " - " + Punhal_Do_Louco_Manager.INome + " " + Punhal_Do_Louco_Manager.Detalhes);
                Console.WriteLine("");
                Console.WriteLine(Manoplas_Do_Dragão_Manager.Identificador + " - " + Manoplas_Do_Dragão_Manager.INome + " " + Manoplas_Do_Dragão_Manager.Detalhes);
                Console.WriteLine("");
                Console.WriteLine(Cetro_De_Rá_Manager.Identificador + " - " + Cetro_De_Rá_Manager.INome + " " + Cetro_De_Rá_Manager.Detalhes);
                Console.WriteLine("");
                Console.WriteLine(Lemegeton_Manager.Identificador + " - " + Lemegeton_Manager.INome + " " + Lemegeton_Manager.Detalhes);
                Console.WriteLine("");
                Console.WriteLine(Espada_Matadora_De_Deuses_Manager.Identificador + " - " + Espada_Matadora_De_Deuses_Manager.INome + " " + Espada_Matadora_De_Deuses_Manager.Detalhes);
                Console.WriteLine("");
                Console.WriteLine(Lâminas_Do_Caos_Manager.Identificador + " - " + Lâminas_Do_Caos_Manager.INome + " " + Lâminas_Do_Caos_Manager.Detalhes);
                Console.WriteLine("");
                Console.WriteLine(Lanche_Da_Mamãe_Manager.Identificador + " - " + Lanche_Da_Mamãe_Manager.INome + " " + Lanche_Da_Mamãe_Manager.Detalhes);
                Console.WriteLine("");
                var ic = Console.ReadLine();






                if (ic == Punhal_Do_Louco_Manager.Identificador.ToString())
                {

                    Console.WriteLine("Você gostaria de comprar " + Punhal_Do_Louco_Manager.INome + " por " + Punhal_Do_Louco_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Punhal_Do_Louco_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Punhal_Do_Louco_Manager.Valor;
                            p.Itens.Add(Punhal_Do_Louco_Manager);
                            Console.Clear();
                            Console.WriteLine("Punhal do Louco comprado e adicionado ao inventário com sucesso!");
                            Console.WriteLine("Espero que não enlouqueça como o dono antigo ok?");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {
                            Console.WriteLine("Hmm, parece que você não tem dinheiro suficiente hein..");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF





                else if (ic == Manoplas_Do_Dragão_Manager.Identificador.ToString())
                {
                    Console.WriteLine("Você gostaria de comprar " + Manoplas_Do_Dragão_Manager.INome + " por " + Manoplas_Do_Dragão_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Manoplas_Do_Dragão_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Manoplas_Do_Dragão_Manager.Valor;
                            p.Itens.Add(Manoplas_Do_Dragão_Manager);
                            Console.Clear();
                            Console.WriteLine("Manoplas do Dagrã-Digo, Manoplas do Dragrã-... Ah você sabe que foi comprado e adicionado ao inventário com sucesso!");
                            Console.WriteLine("Cuidado para não destruir essa manopla, quem criou isso choraria se soubesse disso.");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {
                            Console.WriteLine("Espera comprar essas manoplas só com isso? Acha que vou deixar?");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF





                else if (ic == Cetro_De_Rá_Manager.Identificador.ToString())
                {

                    Console.WriteLine("Você gostaria de comprar " + Cetro_De_Rá_Manager.INome + " por " + Cetro_De_Rá_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    resp = resp.ToLower();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Cetro_De_Rá_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Cetro_De_Rá_Manager.Valor;
                            p.Itens.Add(Cetro_De_Rá_Manager);
                            Console.Clear();
                            Console.WriteLine("(possível)Cetro de Rá comprado e adicionado ao inventário com sucesso!");
                            Console.WriteLine("Então você quer tentar a sorte de ser o legítimo Cetro de Rá hein? Bem, boa sorte com isso!");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {
                            Console.WriteLine("No Egito todos são ricos, por que acha que eu venderia por essa quantidade minúscula de ouro?");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF





                else if (ic == Lemegeton_Manager.Identificador.ToString())
                {
                    Console.WriteLine("Você gostaria de comprar " + Lemegeton_Manager.INome + " por " + Lemegeton_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    resp = resp.ToLower();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Lemegeton_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Lemegeton_Manager.Valor;
                            p.Itens.Add(Lemegeton_Manager);
                            Console.Clear();
                            Console.WriteLine("O Grimório Lemegeton foi comprado e adicionado ao inventário com sucesso!");
                            Console.WriteLine("Cultista? Sério mesmo? Com essa cara?");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {
                            Console.WriteLine("Não esqueça que Salomão era rei, ele tinha dinheiro, você não..");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF



                else if (ic == Espada_Matadora_De_Deuses_Manager.Identificador.ToString())
                {

                    Console.WriteLine("Você gostaria de comprar " + Espada_Matadora_De_Deuses_Manager.INome + " por " + Espada_Matadora_De_Deuses_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    resp = resp.ToLower();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Espada_Matadora_De_Deuses_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Espada_Matadora_De_Deuses_Manager.Valor;
                            p.Itens.Add(Espada_Matadora_De_Deuses_Manager);
                            Console.Clear();
                            Console.WriteLine("A Espada Matadora de Deuses foi comprada e adicionada ao seu inventário com sucesso!");
                            Console.WriteLine("Você não vai sair matando deuses não é mesmo? Me diz que não, por favor!");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {

                            Console.WriteLine("Essa espada matou deuses, tá achando que eu vendo mais barato que isso? Não depois de saber que atravessou os peitos de Hera!");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF




                else if (ic == Lâminas_Do_Caos_Manager.Identificador.ToString())
                {

                    Console.WriteLine("Você gostaria de comprar " + Lâminas_Do_Caos_Manager.INome + " por " + Lâminas_Do_Caos_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    resp = resp.ToLower();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Lâminas_Do_Caos_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Lâminas_Do_Caos_Manager.Valor;
                            p.Itens.Add(Lâminas_Do_Caos_Manager);
                            Console.Clear();
                            Console.WriteLine("As Lâminas do Caos foram compradas e adicionadas ao inventário com sucesso!");
                            Console.WriteLine("Cuidado com as correntes, elas pegam fogo também..");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {

                            Console.WriteLine("Sem dinheiro eu não dou, não elas..");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF




                else if (ic == Lanche_Da_Mamãe_Manager.Identificador.ToString())
                {

                    Console.WriteLine("Você gostaria de comprar " + Lanche_Da_Mamãe_Manager.INome + " por " + Lanche_Da_Mamãe_Manager.Valor + "G? (S)/(N)");
                    Console.WriteLine("Seu ouro:" + p.Ouro);
                    var resp = Console.ReadLine();
                    resp = resp.ToLower();
                    if (resp == "s")
                    {
                        if (p.Ouro >= Lanche_Da_Mamãe_Manager.Valor)
                        {
                            p.Ouro = p.Ouro - Lanche_Da_Mamãe_Manager.Valor;
                            p.Itens.Add(Lanche_Da_Mamãe_Manager);
                            Console.Clear();
                            Console.WriteLine("O Lanche da Mamãe foi comprado e adicionado ao inventário com sucesso!");
                            Console.WriteLine("Parece bem delicioso! Me dá um pedacinho?");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END IF
                        else
                        {

                            Console.WriteLine("Ahhh, é o Lanche da Mamãe, você sabe mais do que eu que vale tudo isso, então torce esse bolso ai!");
                            Console.WriteLine("Pressione qualquer tecla para continuar..");
                            Console.Read();
                        }//END ELSE
                    }//END IF
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.Read();
                    }//END ELSE 
                }//END ELSE IF






                else
                {
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado...");
                    Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                    Console.ReadLine();
                }//END ELSE



            }//END IF
        }//END FOREACH

    }




    private static bool MenuPrincipal()
    {

        Item Punhal_Do_Louco = new Item();
        Punhal_Do_Louco.Identificador = 1;
        Punhal_Do_Louco.INome = "Punhal do Louco";
        Punhal_Do_Louco.Valor = 90;
        Punhal_Do_Louco.Detalhes = "O Punhal que uma vez pertenceu a um Serial Killer usuário de magia elétrica(+30% DE DANO ELÉTRICO)";

        Item Manoplas_Do_Dragão = new Item();
        Manoplas_Do_Dragão.Identificador = 2;
        Manoplas_Do_Dragão.INome = "Manoplas do Dragão";
        Manoplas_Do_Dragão.Valor = 300;
        Manoplas_Do_Dragão.Detalhes = "Essas manoplas foram criadas a partir de escamas do lendário dragão de fogo Falkor(+70% DE DANO DE FOGO)";

        Item Cetro_De_Rá = new Item();
        Cetro_De_Rá.Identificador = 3;
        Cetro_De_Rá.INome = "Cetro de Rá";
        Cetro_De_Rá.Valor = 400;
        Cetro_De_Rá.Detalhes = "Um Cetro egípcio que muito antigo, com hieróglifos talhados, dizem que uma vez pertenceu a Rá, o Deus Egípcio do Sol(+50% NA VELOCIDADE DE CONJURAÇÃO)";

        Item Lemegeton = new Item();
        Lemegeton.Identificador = 4;
        Lemegeton.INome = "Lemegeton";
        Lemegeton.Valor = 350;
        Lemegeton.Detalhes = "Também conhecido como 'A Chave Menor de Salomão' esse Grimório possui o conhecimento de invocação demoníaca do Rei Salomão(+50% DE CHANCE DE INVOCAR UM DEMÔNIO DE CLASSIFICAÇÃO ALEATÓRIA AO MATAR UM INIMIGO)";

        Item Espada_Matadora_De_Deuses = new Item();
        Espada_Matadora_De_Deuses.Identificador = 5;
        Espada_Matadora_De_Deuses.INome = "Espada Matadora de Deuses";
        Espada_Matadora_De_Deuses.Valor = 1000;
        Espada_Matadora_De_Deuses.Detalhes = "Espada usada por um semideus grego para derrubar o Olimpus em uma vingança com os Titãs(20% DE CHANCE DE MATAR INSTANTANEAMENTE QUALQUER MONSTRO)";

        Item Lâminas_Do_Caos = new Item();
        Lâminas_Do_Caos.Identificador = 6;
        Lâminas_Do_Caos.INome = "Lâminas do Caos";
        Lâminas_Do_Caos.Valor = 700;
        Lâminas_Do_Caos.Detalhes = "Arma concedida a um mortal pelo deus da guerra Áres(+70% DE BÔNUS DE DANO QUANDO A VIDA ESTIVER ABAIXO DE 80%)";

        Item Lanche_Da_Mamãe = new Item();
        Lanche_Da_Mamãe.Identificador = 7;
        Lanche_Da_Mamãe.INome = "Lanche da Mamãe";
        Lanche_Da_Mamãe.Valor = 10000;
        Lanche_Da_Mamãe.Detalhes = "Esse lanche foi preparado pelas graciosas mãos da mamãe, e feito com muito carinho S2(+200% DE BÔNUS EM TODOS OS STATUS POR 48h)";





        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Digite '1' para criar um perfil (necessário para entrar na loja).");
        Console.WriteLine("Digite '2' para olhar o perfil de todos os jogadores.");
        Console.WriteLine("Digite '3' para checar o seu inventário.");
        Console.WriteLine("Digite '4' para entrar na loja.");
        Console.WriteLine("Digite '5' para encerrar o programa.");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        switch (Console.ReadLine())
        {
            case "1":
                CriarPlayer();
                return true;//END CASE (SWITCH)


            case "2":
                VerPlayer();
                return true;//END CASE (SWITCH)


            case "3":
                OlharInventário();
                return true;//END CASE (SWITCH)


            case "4":
                Gerência(
                    Punhal_Do_Louco,
                    Manoplas_Do_Dragão,
                    Cetro_De_Rá,
                    Lemegeton,
                    Espada_Matadora_De_Deuses,
                    Lâminas_Do_Caos,
                    Lanche_Da_Mamãe
                );
                return true;//END CASE (SWITCH)


            //END PROGRAM
            case "5":
                return false;


            //DEFAULT ROUTE (BACK TO MENU)
            default:
                return true;





        }//END SWITCH

    }//END METHOD






}//END CLASS