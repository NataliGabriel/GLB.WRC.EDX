using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.ModeloXml
{
    public class ATUALIZA_PC : IEdxCorpo
    {
        public ATUALIZA_PC()
        {
            PCK = new PCK();
        }
        public PCK PCK { get; set; }
    }
}
