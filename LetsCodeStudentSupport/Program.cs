bool compraFinalizada = false;

Dictionary<string, int> ListaMercado = new Dictionary<string, int>();
ListaMercado.Add("Banana", 10);
ListaMercado.Add("Maça", 12);
ListaMercado.Add("Uva", 20);
ListaMercado.Add("Pera", 30);
ListaMercado.Add("Goaiba", 5);
ListaMercado.Add("Morango", 0);


Dictionary<string, int> ListaCliente = new Dictionary<string, int>();

while (!compraFinalizada)
{
    Console.Clear();
    Console.WriteLine("#### Mercado Atende Facil######");
    Console.WriteLine("Temos disponivel");

    foreach (KeyValuePair<string, int> kvp in ListaMercado) //Mudei aqui.
    {
        if(kvp.Value > 0)
            Console.WriteLine("Fruta: {0} Quantidade: {1}", kvp.Key, kvp.Value);
    }

    Console.WriteLine("Qual seu pedido?. Digita a fruta");
    string frutaEscolhida = Console.ReadLine();

    if (ListaMercado.ContainsKey(frutaEscolhida))
    {
        if (ListaMercado[frutaEscolhida] <= 0)
        {
            Console.WriteLine("A fruta {0} esta em falta. Tecle Enter para continuar", frutaEscolhida);
            Console.ReadKey();
            continue;
        }

        Console.WriteLine("Qual a quantidade");
        int qtdadeEscolhida = Convert.ToInt32(Console.ReadLine()); // usuario pode digitar letras ao inves de numero

        
        var qtdFrutaDisponivel = ListaMercado[frutaEscolhida];
        

        if (qtdFrutaDisponivel > qtdadeEscolhida)
        {
            Console.WriteLine($"A fruta escolhida é {frutaEscolhida} e a qtdade é {qtdadeEscolhida}");
            Console.WriteLine("Compra Efetuada");
            Console.ReadKey();

            ListaMercado[frutaEscolhida] -= qtdadeEscolhida;
            ListaCliente.Add(frutaEscolhida, qtdadeEscolhida);

            foreach (KeyValuePair<string, int> kvp in ListaCliente)
            {
                Console.WriteLine("** Lista Cliente é:\n Fruta: {0} Quantidade: {1}", kvp.Key, kvp.Value); // NAO FUNCIONA.
                Console.ReadKey();
            }
        }

        if (qtdFrutaDisponivel == qtdadeEscolhida)
        {
            Console.WriteLine("Compra Efetuada"); //NAO FUNCIONA
            ListaMercado.Remove(frutaEscolhida);
        }

        if (qtdFrutaDisponivel < qtdadeEscolhida)
        {
            Console.WriteLine("Quantidade maior que o estoque. Tente Novamente"); //NAO FUNCIONA
            Console.ReadKey();
        }
    }
    else
    {
        Console.WriteLine("Item Invalido. Tecle Enter para continuar");
        Console.ReadKey();
        continue;
    }
}




        