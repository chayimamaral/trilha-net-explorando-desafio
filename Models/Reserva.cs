namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // Implementado...
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // Implementado...
                throw new Exception("Capacidade da suíte é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // Implementado...
            if (Hospedes != null)
            {
                return Hospedes.Count;
            }
            else
            {
                return 0;
            }
        }

        public decimal CalcularValorDiaria()
        {
            // Nos meus testes, percebi que o valor da diária estava sendo calculado mesmo quando não havia hóspedes cadastrados.
            // Adicionei uma verificação para garantir que haja hóspedes antes de calcular o valor da
            if (Hospedes == null || Hospedes.Count == 0)
            {
                return 0;
            }
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // Implementado...
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // Implementado...
            if (DiasReservados >= 10)
            {
                valor *= 0.9M; // desconto de 10%
            }

            return valor;
        }
    }
}