using Domain.Entities.Producao;
using Domain.Entities.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGFR_Web_v02.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        [DisplayName("Indetificação")]
        public int ClienteId { get; set; }


        [Display(Name = "Data")]
        [Required(ErrorMessage = "The field {0} is required")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [ScaffoldColumn(false)] //nao quero esse campo criado no scafolding
        [DisplayName("Data do cadastro")]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

        //Um para muitos
        public List<Venda> Vendas { get; set; }
        public List<Pedido> Pedidos { get; set; }

    }
}