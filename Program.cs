Console.WriteLine("Mês por extenso\n");

Console.Write("Digitar o número correspondente ao mês:");
int mes = Convert.ToInt32(Console.ReadLine());

string mesExtenso;

switch (mes)
{
    case 1:
        mesExtenso = "JANEIRO";
        break;
    case 2:
        mesExtenso = "FEVEREIRO";
        break;
    case 3:
        mesExtenso = "MARÇO";
        break;
    case 4:
        mesExtenso = "ABRIL";
        break;
    case 5:
       mesExtenso = "MAIO";
        break;
    case 6:
        mesExtenso = "JUNHO";
        break;
    case 7:
        mesExtenso = "JULHO";
        break;
    case 8:
        mesExtenso = "AGOSTO";
        break;
    case 9:
        mesExtenso = "SETEMBRO";
        break;
    case 10:
        mesExtenso = "OUTUBRO";
        break;
    case 11:
        mesExtenso = "NOVEMBRO";
        break;
    case 12:
        mesExtenso = "DEZEMBRO";
        break;
    default:
        mesExtenso = "Mês incorreto.";
        break;
}

Console.WriteLine();
Console.WriteLine(mesExtenso);