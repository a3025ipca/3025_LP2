﻿// Autor: César Morgado
// Email: a3025@alunos.ipca.pt
// Data: 23/04/2020
// Versão: 1.0
// Comentários: Classe para definir o que é um funcionário

namespace GestaoDeGabinete
{
    public class Funcionario
    {
        #region Estado

        #region Propriedades

        private string username, senha;
        private bool valido;

        #endregion

        #region Variáveis Globais

        #endregion

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor default para a classe funcionário
        /// </summary>
        public Funcionario()
        {
            Username = default;
            Senha = default;
            Valido = true;
        }

        /// <summary>
        /// Construtor para criar um funcionário
        /// </summary>
        /// <param name="username">Username do funcionário</param>
        /// <param name="senha">Senha do funcionário</param>
        public Funcionario(string username, string senha)
        {
            Username = username;
            Senha = senha;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Devolve ou define a variável Username
        /// </summary>
        public string Username 
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Devolve ou define a variável Senha
        /// </summary>
        public string Senha 
        {
            get { return senha; }
            set { senha = value; }
        }

        /// <summary>
        /// Devolve ou define o estado da variável valido
        /// Variável usada para eliminar o funcionário
        /// </summary>
        public bool Valido
        {
            get { return valido; }
            set { valido = value; }
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Função para comparar dois funcionários
        /// </summary>
        /// <param name="obj">Objeto do tipo Funcionario</param>
        /// <returns>Verdadeiro caso seja igual, falso caso sejam diferentes</returns>
        public override bool Equals(object obj)
        {
            // Variáveis locais
            Funcionario aux;

            // Verifica se o objeto enviado é do tipo Cliente
            if (!(obj is Funcionario))
                return false;

            // Converte o objeto para Cliente
            aux = (Funcionario)obj;

            // Verifica se são iguais
            return (aux.Username == this.Username && aux.Senha == this.Senha);
        }

        /// <summary>
        /// Operador para verificar se dois funcionarios são iguais
        /// </summary>
        /// <param name="funcionario1">Funcionario 1</param>
        /// <param name="funcionario2">Funcionario 2</param>
        /// <returns>Verdadeiro caso seja iguais, falso caso sejam diferentes</returns>
        public static bool operator ==(Funcionario funcionario1, Funcionario funcionario2)
        {
            return (funcionario1.Equals(funcionario2));
        }

        /// <summary>
        /// Operador para verificar se dois funcionários são diferentes
        /// </summary>
        /// <param name="funcionario1">Funcionario 1</param>
        /// <param name="funcionario2">Funcionario 2</param>
        /// <returns>Verdadeiro caso seja diferentes, falso caso sejam iguais</returns>
        public static bool operator !=(Funcionario funcionario1, Funcionario funcionario2)
        {
            return (!(funcionario1.Equals(funcionario2)));
        }

        public override int GetHashCode()
        {
            return this.Username.GetHashCode();
        }

        #endregion

        #region Outros métodos

        #endregion

        #endregion
    }
}
