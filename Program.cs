int vitorias = 55;
int derrotas = 30;

(int saldoVitorias, string nivel) = CalcularRanking(vitorias, derrotas);

Console.WriteLine($"O Herói tem de saldo de {saldoVitorias} está no nível de {nivel}");

static (int, string) CalcularRanking(int vitorias, int derrotas)
{
    int saldoVitorias = vitorias - derrotas;
    string nivel;
    
    if (vitorias < 10)
            {
                nivel = "Ferro";
            }
            else if (vitorias >= 11 && vitorias <= 20)
            {
                nivel = "Bronze";
            }
            else if (vitorias >= 21 && vitorias <= 50)
            {
                nivel = "Prata";
            }
            else if (vitorias >= 51 && vitorias <= 80)
            {
                nivel = "Ouro";
            }
            else if (vitorias >= 81 && vitorias <= 90)
            {
                nivel = "Diamante";
            }
            else if (vitorias >= 91 && vitorias <= 100)
            {
                nivel = "Lendário";
            }
            else // vitorias >= 101
            {
                nivel = "Imortal";
            }

            return (saldoVitorias, nivel);
}