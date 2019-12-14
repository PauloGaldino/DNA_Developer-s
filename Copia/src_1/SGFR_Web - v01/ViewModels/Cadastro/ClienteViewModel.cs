using Domain.Entities.Producao;
using Domain.Entities.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGFR_Web.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        [DisplayName("Indetificação")]
        public int ClienteId { get; set; }

      
   
        [DisplayName("Data do cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

        //Um para muitos
        public List<Venda> Vendas { get; set; }
        public List<Pedido> Pedidos { get; set; }

    }
}