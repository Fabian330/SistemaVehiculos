using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVehiculos
{
    internal class Vehiculos
    {
        protected int[] codigo = new int[5];
        protected string[] marca = new string[5];
        protected float[] costo = new float[5];
        protected int[] modelo = new int[5];

        public Vehiculos() { }

        public Vehiculos(int[] codigo, string[] marca, float[] costo, int[] modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.costo = costo;
            this.modelo = modelo;
        }
    }
}
