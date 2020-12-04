using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Técnica
{
   public abstract class Tripulacao
    {
        protected string piloto { get; set; }

        protected string ofc1 { get; set; }

        protected string ofc2 { get; set; }

        protected string chefe { get; set;}

        protected string com1 { get; set; }

        protected string com2 { get; set; }

        protected string policial { get; set; }

        protected string presidiario { get; set; }
    }
}
