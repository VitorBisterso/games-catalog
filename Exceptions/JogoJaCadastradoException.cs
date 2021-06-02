using System;

namespace games_catalog.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException() : base("Esse jogo já está cadastrado")
        {  }
    }
}