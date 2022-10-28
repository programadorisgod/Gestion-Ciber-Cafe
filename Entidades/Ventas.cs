using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Ventas
    {
        private int NumeroVenta
        {
            get => default;
            set
            {
            }
        }

        private DateTime FechaVenta
        {
            get => default;
            set
            {
            }
        }

        private int CantidadVendidaProducto
        {
            get => default;
            set
            {
            }
        }

        private Double TotalVenta
        {
            get => default;
            set
            {
            }
        }

        public Producto Producto
        {
            get => default;
            set
            {
            }
        }

        public Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        public List<DetalleSalida> ListaDetalleSalida
        {
            get => default;
            set
            {
            }
        }
    }
}