int habilidade=0, energia=0, estagio = 1;
string criatura="", heroi, ResultSorte="";
int HabHeroi=0, SorHeroi=0, EneHeroi=0;
int Dano, DanoLevado;

Console.WriteLine("Digite o seu Nome: ");
heroi = Console.ReadLine()!;

HabHeroi = new Random().Next(1,7)+6;
SorHeroi = new Random().Next(1,7)+ new Random().Next(1,7)+12;
EneHeroi = new Random().Next(1,7)+6;

void carregar (){
switch (estagio)
{
    case 1:
        criatura = "Lobo Cinzento";
        energia = 3;
        habilidade = 3;
    break;

    case 2:
        criatura = "Lobo Branco";
        energia = 3;
        habilidade = 3;
    break;
    
    case 3:
        criatura = "Goblin";
        energia = 5;
        habilidade = 4;
    break;

    case 4:
        criatura = "Orc Vesgo";
        energia = 5;
        habilidade = 5;
    break;

    case 5:
        criatura = "Orc Barbudo";
        energia = 5;
        habilidade = 5;
    break;

    case 6:
        criatura = "Zumbi Manco";
        energia = 7;
        habilidade = 6;
    break;

    case 7:
        criatura = "Zumbi Balofo";
        energia = 7;
        habilidade = 6;
    break;

    case 8:
        criatura = "Troll";
        energia = 7;
        habilidade = 8;
    break;

    case 9:
        criatura = "Ogro";
        energia = 9;
        habilidade = 8;
    break;

    case 10:
        criatura = "Ogro Furioso";
        energia = 9;
        habilidade = 10;
    break;

    case 11:
        criatura = "Necromante Maligno";
        energia = 12;
        habilidade = 12;
    break;

    default:
    break;
}
}

Console.WriteLine("SORTE");
Console.WriteLine("HABILIDADE");
Console.WriteLine("ENERGIA");

void loop(){
    Console.Clear();
Console.WriteLine($"{criatura} hp {energia} ataque {habilidade}");
Console.WriteLine($"{heroi} hp {EneHeroi} ataque {HabHeroi} sorte {SorHeroi}");
Console.WriteLine("Você deseja testar sua sorte?");

string resposta = Console.ReadLine()!;
if (resposta.ToUpper() == "SIM")
{
    int AleatorioSorte = new Random().Next(1,7) + new Random().Next(1,7);
    if (AleatorioSorte <= SorHeroi)
    {
        ResultSorte = "sortudo";
    }
    else if (AleatorioSorte > SorHeroi)
    {
        ResultSorte = "azarado";
    }
    SorHeroi = SorHeroi - 1;
}

void CalculoDano ()
{
    if (ResultSorte == "sortudo")
    {
        Dano = 4;
        DanoLevado = 1;
    } 
    else if (ResultSorte == "azarado")
    {
        Dano = 1;
        DanoLevado = 3;
    }
    else {
        Dano = 2;
        DanoLevado = 2;
    }
}

int Aleatorio = new Random().Next(1,7) + new Random().Next(1,7);
int AleatorioCriatura = new Random().Next(1,7) + new Random().Next(1,7);

CalculoDano ();
if (Aleatorio + HabHeroi > AleatorioCriatura + habilidade)
{
    energia = energia-Dano;
    Console.WriteLine($"Heroi acerta o {criatura}");
}
else if (Aleatorio + HabHeroi < AleatorioCriatura + habilidade)
{
    EneHeroi = EneHeroi-DanoLevado;
    Console.WriteLine($"Inimigo acerta o {heroi}");
}
else
{
    Console.WriteLine("Ambos erraram o ataque");
}

ResultSorte = "";

Console.ReadKey();
if (estagio < 11 && energia <= 0)
{
    estagio += 1;
    carregar ();
    loop();
}
else if (estagio == 11 && energia <= 0)
{
    Console.WriteLine("Parabéns. Você matou todos os inimigos da masmorra !!!");
}
else{
    loop();
}
}
carregar();
loop();



