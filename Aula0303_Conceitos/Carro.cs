using System;

namespace Aula0303_Conceitos
{
    class Carro : MeioTransporte, IMotorizado
    {

        public Carro(string nome)
        {
            this.Nome = Nome;
        }

        public void Acelerar()
        {
            Console.WriteLine("Carro: Acelerando...");

        }

        public void Frear()
        {
            Console.WriteLine("Carro: Freando...");
        }

        public override void Parar()
        {
            base.Parar();
            Console.WriteLine("Carro: Parando...");
        }
    }
}
