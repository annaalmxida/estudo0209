using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Funcionario :Pessoa
    {
        private int RegistroCarteira;
        protected double Salario;
        public string Cargo;
        protected string Admissão;
        protected double VA;
        protected double VT;
        protected double VR;
        protected string AssistenciaMedica;

        public void CadastrarFuncionario()
        {
            Console.WriteLine("Digite seu Registro:");
            RegistroCarteira = int.Parse(Console.ReadLine());
        }
        public void ConsultarFuncionario()
        {
            Console.WriteLine("Olá, seu registro é: {0}", RegistroCarteira);
        }
    }
}
