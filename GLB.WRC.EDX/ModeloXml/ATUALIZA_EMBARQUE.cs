using System;
using System.Collections.Generic;
using System.Text;

namespace GLB.WRC.EDX.ModeloXml
{
    public class ATUALIZA_EMBARQUE : IEdxCorpo
    {
        public ATUALIZA_EMBARQUE()
        {
            MAIN = new MAIN();
            BUK = new BUK();
            PAR = new PAR();
            PARS = new PARS();
            DAT = new DAT();
            DI = new DI();
            BL = new BL();
            SHP = new List<SHP>();
        }
        public MAIN MAIN { get; set; }
        public BUK BUK { get; set; }
        public PAR PAR { get; set; }
        public PARS PARS { get; set; }
        public DAT DAT { get; set; }
        public DI DI { get; set; }
        public BL BL { get; set; }
        public List<SHP> SHP { get; set; }
        
    }
}
