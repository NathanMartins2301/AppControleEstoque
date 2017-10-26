using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Equipamento
    {

        #region Variaveis e Propiedades

        private int id;
        List<Empresa> listaEmpresa = new List<Empresa>();

        
        private String fornecedor;
        private String equipamento;
        private String modelo;
        private int sd;
        private int numero_serie;
        private String ip;
        private String problema;
        private String acao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

  

        public String Fornecedor
        {
            get { return fornecedor; }
            set { fornecedor = value; }
        }

        public String equipamentos
        {
            get { return equipamento; }
            set { equipamento = value; }
        }

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Sd
        {
            get { return sd; }
            set { sd = value; }
        }

        public int Numero_serie
        {
            get { return numero_serie; }
            set { numero_serie = value; }
        }

        public String Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public String Problema
        {
            get { return problema; }
            set { ip = value; }
        }

        public String Acao
        {
            get { return acao; }
            set { acao = value; }
        }

        #endregion

    }
}
