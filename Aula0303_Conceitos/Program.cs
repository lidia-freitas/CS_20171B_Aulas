using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Aula0303_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {

            Aula0303_Conceitos.Util.TipoMeioTransporte tipo = (Aula0303_Conceitos.Util.TipoMeioTransporte) Aula0303_Conceitos.Util.Menu();

            switch (tipo)
            {
                case Util.TipoMeioTransporte.Carro:
                    Carro c = new Carro("Fusca");
                    c.Ano = 1978;
                    c.Capacidade = 4;
                    c.Acelerar();
                    c.Frear();
                    c.Parar();
                    break;
                case Util.TipoMeioTransporte.Bicicleta:
                    Bicicleta b = new Bicicleta();
                    b.Nome = "Caloi";
                    b.Ano = 1955;
                    b.QuantidadeMarcha = 21;
                    b.Parar();
                    break;
                case Util.TipoMeioTransporte.Barco:
                    Barco ba = new Barco();
                    ba.Ano = 1969;
                    ba.QuantidadePes = 50;
                    ba.Capacidade = 2000;
                    ((IMotorizado)ba).Acelerar();
                    ((IMotorizado)ba).Frear();
                    ba.Parar();
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
