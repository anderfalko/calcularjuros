using System;

namespace ProvaTecnica.Calculos
{
    public class CalculosJuros
    {
        public double CalcurarJuros(double valorinicial, int meses)
        {
            // Fórmula: Valor Final = Valor Inicial * (1 + juros) ^ Tempo
            // Fórmula: Valor Final = Valor Inicial * (1 + juros) ^ Tempo
            double juros = 1 + 0.01;
            double potencializacao = Math.Pow(juros, meses);
            double valor_final = valorinicial * potencializacao;
            double valor_truncado = Math.Truncate(100 * valor_final) / 100;
            return valor_truncado;
        }
    }
}