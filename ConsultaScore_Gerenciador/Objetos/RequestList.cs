using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaScore_Gerenciador.Objetos
{
    class RequestList
    {
        public int ID { get; set; }
        public int CPF { get; set; }

        public RequestList()
        {

        }
        public RequestList(int ID, int CPF)
        {
            this.ID  = ID;
            this.CPF = CPF;
        }


    }
}
