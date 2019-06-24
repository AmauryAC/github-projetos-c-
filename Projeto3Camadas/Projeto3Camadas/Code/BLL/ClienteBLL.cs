using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;
using System.Data;

namespace Projeto3Camadas.Code.BLL
{
    class ClienteBLL
    {
        AcessoBancoDados bd;

        public void Inserir(ClienteDTO cliDTO)
        {
            try
            {
                bd = new AcessoBancoDados();

                bd.Conectar();

                string nome = cliDTO.Nome.Replace("'", "''");
                string comando = "INSERT INTO cliente(nome, email) VALUES('" + nome + "','" + cliDTO.Email + "')";

                bd.ExecutarComandoSQL(comando);
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao tentar inserir um novo cliente: " + ex.Message);
            }
            finally
            {
                //Gerar Log
                bd = null;
            }
        }

        public void Atualizar(ClienteDTO cliDTO)
        {
            try
            {
                bd = new AcessoBancoDados();

                bd.Conectar();

                string nome = cliDTO.Nome.Replace("'", "''");
                string comando = "UPDATE cliente SET nome = '" + cliDTO.Nome + "', email = '" + cliDTO.Email + "' WHERE id = " + cliDTO.Id;

                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar o cliente: " + ex.Message);
            }
            finally
            {
                //Gerar Log
                bd = null;
            }
        }

        public void Excluir(string idCliente)
        {
            try
            {
                bd = new AcessoBancoDados();

                bd.Conectar();

                string comando = "DELETE FROM cliente WHERE id = " + idCliente;

                bd.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o cliente: " + ex.Message);
            }
            finally
            {
                //Gerar Log
                bd = null;
            }
        }

        public DataTable SelecionaTodosClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                bd = new AcessoBancoDados();
                bd.Conectar();

                string comando = "SELECT id, nome, email FROM cliente";

                dt = bd.RetDataTable(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar selecionar todos os clientes: " + ex.Message);
            }
            finally
            {
                //Gerar Log
                bd = null;
            }

            return dt;
        }
    }
}
