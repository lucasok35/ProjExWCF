using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicoHostWCF
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Servico" no arquivo de código e configuração ao mesmo tempo.
    public class Servico : IServico
    {
        TesteCadastroBO boTesteCadastro;
        public List<EntTesteCadastro> Consultar(string nome)
        {
            boTesteCadastro = new TesteCadastroBO();
            EntTesteCadastro cliente = new EntTesteCadastro();
            cliente.Nome = nome;
            return boTesteCadastro.BuscarCliente(cliente);
        }
    }
}
