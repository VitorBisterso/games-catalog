using System;

namespace games_catalog.Exceptions
{
    public class JogoNaoCadastradoException : Exception
    {
        public JogoNaoCadastradoException() : base("Esse jogo não está cadastrado")
        {  }
    }
}