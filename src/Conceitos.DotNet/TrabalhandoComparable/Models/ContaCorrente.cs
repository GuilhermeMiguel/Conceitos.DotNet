using System;

namespace Conceitos.DotNet.TrabalhandoComparable.Models
{
    public class ContaCorrente : IComparable
    {
        private static int TaxaOperacao;

        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }

        public int Agencia { get; }

        private double _saldo = 100;



        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return false;
            }

            return Numero == outraConta.Numero && Agencia == outraConta.Agencia;
        }

        //metodo implementado da interface -- assinei o contrato da interface
        //No caso vou comparar duas contas corrente, o compareTo deve retornar um int

        public int CompareTo(object obj){

            //Retornar negativo quando a instancia precede o obj; -- Por conveção retorna-se -1
            //Retornar zero quando nossa instancia e obj forem equivalentes; 
            //Retornar positivo diferente de zero quando obj for precedente. -- Por convenção retorna-se 1

            var outraConta = obj as ContaCorrente;

            if(outraConta == null)
            {
                return -1;
            }

            if(Numero < outraConta.Numero)
            {
                return -1;
            }
            else if (Numero == outraConta.Numero)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ContadorSaquesNaoPermitidos, ContadorTransferenciasNaoPermitidas, Numero, Agencia, _saldo);
        }
    }
}