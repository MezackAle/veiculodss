using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_car
{
    public class Caminhao : Veiculo
    {
        private string bau;
        private string tipocarga;
        private int qtdrodas;

        public Caminhao()
        {
            this.bau = null;
            this.tipocarga = null;
            this.qtdrodas = 0;
        }

        public Caminhao(string marca, string modelo, string chassi, int quilometragem, string cor, int ano, string placa, string bau, string tipocarga, int qtdrodas)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Chassi = chassi;
            this.Quilometragem = quilometragem;
            this.Cor = cor;
            this.Ano = ano;
            this.Placa = placa;
            this.bau = bau;
            this.tipocarga = tipocarga;
            this.qtdrodas = qtdrodas;
        }


        public string Bau
        {
            get { return bau; }
            set { bau = value; }
        }

        public string Tipocarga
        {
            get { return tipocarga; }
            set { tipocarga = value; }
        }

        public int Qtdrodas
        {
            get { return qtdrodas; }
            set { qtdrodas = value; }
        }

        public override string Dados()
        {
            String Vcam = String.Empty;
             Vcam = String.Concat("Marca: ", this.Marca, "\r\n",
                 "Modelo: ", this.Modelo, "\r\n",
                 "Chassi: ", this.Chassi, "\r\n",
                 "Quilometragem: ", this.Quilometragem.ToString(), "\r\n",
                 "Cor: ", this.Cor, "\r\n",
                 "Placa: ", this.Placa, "\r\n",
                 "Bau: ", this.bau, "\r\n",
                 "Tipo de Carga: ", this.tipocarga, "\r\n",
                 "Quantidade de Rodas: ", this.qtdrodas, "\r\n");

                return Vcam;
        }

    }
}
