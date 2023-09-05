using GLB.WRC.EDX.Entidade;
using GLB.WRC.EDX.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLB.WRC.EDX.Negocio
{
    public class BLBroker
    {
        private DadosEmbarqueRepositorio _dadosEmbarqueRepositorio;

        public BLBroker()
        {
            _dadosEmbarqueRepositorio = new DadosEmbarqueRepositorio();
        }
        public V_BROKER DadosBroker(string referencia)
        {
            var dadosBroker = _dadosEmbarqueRepositorio.DadosEmbarque(referencia);
            dadosBroker.ItensAdicao = DadosItensAdicao(referencia);
            dadosBroker.Acrescimos = AcrescimosDI(referencia);
            foreach (var item in dadosBroker.ItensAdicao)
            {
                item.Impostos = DadosImpostos(item.CODIGO);
            }
            return dadosBroker;
        }
        private List<V_ITENS_ADICAO> DadosItensAdicao(string referencia)
        {
            return _dadosEmbarqueRepositorio.ItensAdicao(referencia);
        }
        private V_IMPOSTOS_ITENS DadosImpostos(int codigo)
        {
            return _dadosEmbarqueRepositorio.ImpostosItens(codigo);
        }
        public List<V_LANCAMENTOS> DadosLancamentos(string referencia)
        {
            return _dadosEmbarqueRepositorio.Lancamentos(referencia);
        }
        private List<ACRESCIMOS> AcrescimosDI(string referencia)
        {
            return _dadosEmbarqueRepositorio.Acrescimos(referencia);
        }
    }
}
