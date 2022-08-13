using JogoDeFutebol;

Placar TimeX = new Placar();

Console.WriteLine("Digite o nome do time 1");
TimeX.NomeTime = Console.ReadLine();

Placar TimeY = new Placar();

Console.WriteLine("Digite o nome do time 2");
TimeY.NomeTime = Console.ReadLine();

string opcaoPlacar;
bool loop = true;
while (loop)
{
    Console.WriteLine($"Selecione uma das opções: (1) Marcar gol para {TimeX.NomeTime} - (2) Marcar gol para {TimeY.NomeTime} - (3) Fim de jogo ");
    opcaoPlacar = Console.ReadLine();

    if(opcaoPlacar == "1")
    {
        TimeX.NumeroGol++;
    }
    else if (opcaoPlacar == "2")
    {
        TimeY.NumeroGol++;
    }
    else if (opcaoPlacar == "3")
    {
       if(TimeX.NumeroGol == TimeY.NumeroGol)
        {
            Console.WriteLine($"Empate! {TimeX.NumeroGol} X {TimeY.NumeroGol}");
        }
        else if (TimeX.NumeroGol > TimeY.NumeroGol)
        {
            Console.WriteLine($"{TimeX.NumeroGol} X {TimeY.NumeroGol} para o  {TimeX.NomeTime}");
        }
        else if (TimeX.NumeroGol < TimeY.NumeroGol)
        {
            Console.WriteLine($"{TimeY.NumeroGol} X {TimeX.NumeroGol} para o  {TimeY.NomeTime}");
        }
        break;
    }
}