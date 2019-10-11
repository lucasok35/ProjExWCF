using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoHostWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IServico" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    interface IServico
    {
        [OperationContract]
        List<EntTesteCadastro> Consultar(string nome);
    }

}
