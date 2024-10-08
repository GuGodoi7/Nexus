﻿namespace _NEXUS.Models
{
    public class PedidosModel
    {
        public int IdPedido { get; set; }

        public long CodigoPedido { get; set; }

        public int Quantidade { get; set; }

        public int ValorPedido { get; set; }

        //1..N
        public int IdUsuario { get; set; }
        public UsuarioModel? Usuario { get; set; }

    }
}
