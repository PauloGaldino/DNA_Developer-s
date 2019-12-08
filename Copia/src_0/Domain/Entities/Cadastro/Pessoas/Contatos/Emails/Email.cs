using System.Collections.Generic;

namespace Domain.Entities.Cadastro.Pessoas.Contatos.Emails
{
    public class Email
    {
        public Email()
        {

        }
        public int EmailId { get; set; }

        public string EnderecoEmail { get; set; }

        public ICollection<Contato> Contatos { get; set; }


    }
}
