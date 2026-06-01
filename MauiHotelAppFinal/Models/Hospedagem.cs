namespace MauiHotelAppFinal.Models
{
    public class Hospedagem
    {
        int qnt_adultos = 0;
        Quarto quarto_selecionado;

        public Quarto QuartoSelecionado
        {
            get => quarto_selecionado;
            set
            {
                if (value == null)
                    throw new Exception("Selecione seu quarto.");

                quarto_selecionado = value;
            }
        }


        public int QntAdultos
        {
            get => qnt_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Selecione a quantidade de adultos");

                qnt_adultos = value;
            }
        }


        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto;
                double valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca;

                double total = (valor_adultos + valor_criancas) * Estadia;
                return total;
            }
        }
    }
}
