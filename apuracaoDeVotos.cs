using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace urna
{
    public class apuracaoDeVotos : Politico
    {
        private int votoPedro;
        private int votoJoao;
        private int votoNulo;
        public int VotoPedro
        {
            get { return votoPedro; }
            set { votoPedro = value; }
        }
        public int VotoJoao
        {
            get { return votoJoao; }
            set { votoJoao = value; }
        }
        public int VotoNulo
        {
            get { return votoNulo; }
            set { votoNulo = value; }
        }
        public void acrescentarPedro(int computar)
        {
            VotoPedro += computar;
        }
        public void acrescentarJoao(int computar)
        {
            VotoJoao += computar;
        }
        public void acrescentarNulo(int computar)
        {
            VotoNulo += computar;
        }
    }
}
