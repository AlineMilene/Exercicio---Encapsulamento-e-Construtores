using System.Globalization;

namespace ExercicioContaBancaria {
    class ContaBancaria {

        // declaração dos atributos 
        private string _nomeTitular;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        // criação dos construtores

        public ContaBancaria(int numero, string nome) {
            _nomeTitular = nome;
            Numero = numero;
        }
        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome) {
            Deposito(depositoInicial);
        }

        // método de proteção para mudanças no Nome
        public string Nome {
            get { return _nomeTitular; }
            set {
                if (value != null && value.Length > 1) {
                    _nomeTitular = value;
                }
            }
        }

        // outros métodos
        public void Saque(double valor) {
            Saldo -= valor + 5.00;
        }
        public void Deposito(double valor) {
            Saldo += valor;
        }
        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
