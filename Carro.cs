class Carro
{
    public string fabricante;
    public string modelo;
    public int ano;
    public int quantidadePortas;
    public int velocidade;

    public void exibirInformacoes()
    {
        Console.WriteLine($"\nInformações do carro: {this.fabricante} {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }

    public void acelerar()
    {
        Console.WriteLine("\nAcelerando...");

        if (velocidade < 100)
        {
            velocidade = velocidade + 5;
        }
    }

    public void frear()
    {
        Console.WriteLine("\nFreando...");

        if (velocidade > 0)
        {
            velocidade = velocidade - 5;
        }
    }

    public void buzinar()
    {
        Console.WriteLine("\nBi Bi");
    }
}
