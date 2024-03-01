using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVehiculos
{
    internal class Menu:Vehiculos
    {
        public Menu() { }

        int cnt = 0;
        public void SeleccionOpc()
        {
            byte num1 = 0;
            Console.WriteLine("***Menu Principal***");
            Console.WriteLine("1- Vehiculos" + "\n" + "2- Ventas" + "\n" + "3- Reportes" + "\n" + "4- Salir");
            while (num1 < 1 || num1 > 4)
            {
                Console.Write("Digite una opcion: ");
                num1 = byte.Parse(Console.ReadLine());

                switch (num1)
                {
                    case 1:
                        Console.Clear(); MenuV();
                        break;
                    case 2:
                        Console.Clear(); Ventas();
                        break;
                    case 3:
                        Console.Clear(); Reportes();
                        break;
                    case 4:
                        Console.Clear(); Salir();
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;
                }
            }
        }

        public void MenuV()
        {
            byte num2 = 0;

            Console.WriteLine("***Vehiculos***");
            Console.WriteLine("1- Agregar" + "\n" + "2- Modificar" + "\n" + "3- Consultar" + "\n" + "4- Volver");
            while (num2 < 1 || num2 > 4)
            {
                Console.Write("Digite una opcion: ");
                num2 = byte.Parse(Console.ReadLine());
                switch (num2)
                {
                    case 1:
                        Console.Clear(); AgregarV();
                        break;
                    case 2:
                        Console.Clear(); ModificarV();
                        break;
                    case 3:
                        Console.Clear(); ConsultarV();
                        break;
                    case 4:
                        Console.Clear(); SeleccionOpc();
                        break;
                    default:
                        Console.WriteLine("Esa opcion no existe");
                        break;
                }
            }
        }

        public void AgregarV()
        {
            if (codigo[4] == 0)
            {
                Console.WriteLine("Ingrese el codigo del vehiculo " + (cnt + 1));
                this.codigo[cnt] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la marca del vehiculo " + (cnt + 1));
                this.marca[cnt] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del vehiculo " + (cnt + 1));
                this.costo[cnt] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el modelo(año) del vehiculo " + (cnt + 1));
                this.modelo[cnt] = int.Parse(Console.ReadLine());
                cnt++;
                Console.WriteLine("Vehiculo agregado.");
                Console.WriteLine("Presione enter para volver...");
                Console.ReadKey();
                Console.Clear();
                MenuV();
            }
            else
            {
                Console.WriteLine("La cantidad maxima de vehiculos ya fue agregada.");
                Console.WriteLine("Presione enter para volver...");
                Console.ReadKey();
                Console.Clear();
                MenuV();
            }
        }

        public void ModificarV()
        {
            Console.Write("Ingrese el codigo del vehiculo a modificar: ");
            int codigoM = int.Parse(Console.ReadLine());
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigoM == this.codigo[i])
                {
                    Console.WriteLine("Codigo: " + this.codigo[i]);
                    Console.WriteLine("Ingrese la nueva marca: ");
                    this.marca[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo costo: ");
                    this.costo[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el nuevo modelo: ");
                    this.modelo[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("Vehiculo modificado.");
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    MenuV();
                }
            }
            Console.WriteLine("Este vehiculo no existe.");
            Console.WriteLine("Presione enter para volver...");
            Console.ReadKey();
            Console.Clear();
            MenuV();
        }

        public void ConsultarV()
        {
            Console.Write("Ingrese el codigo del vehiculo a consultar: ");
            int codigoC = int.Parse(Console.ReadLine());

            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigoC == this.codigo[i])
                {
                    Console.WriteLine("Codigo: " + this.codigo[i]);
                    Console.WriteLine("Marca: " + this.marca[i] + "\n" + "Costo: " + this.costo[i] + "\n" + "Modelo: " + this.modelo[i]);
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    MenuV();
                }
            }
            Console.WriteLine("Este vehiculo no existe.");
            Console.WriteLine("Presione enter para volver...");
            Console.ReadKey();
            Console.Clear();
            MenuV();
        }

        public void Ventas()
        {
            Console.Clear();
            Console.WriteLine("***Ventas***");

            Console.Write("Ingrese el codigo del vehiculo: ");
            int codigoVh = int.Parse(Console.ReadLine());
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigoVh == this.codigo[i])
                {
                    Console.WriteLine("Vehiculo existente: ");
                    Console.WriteLine("Codigo: " + this.codigo[i]);
                    Console.WriteLine("Marca: " + this.marca[i] + "\n" + "Costo: " + this.costo[i] + "\n" + "Modelo: " + this.modelo[i]);
                    break;

                }
                else if (i == 4)
                {
                    Console.WriteLine("Este vehiculo no existe.");
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    SeleccionOpc();
                }
            }

            Console.Write("Ingrese el codigo del vendedor: ");
            int codigoV = int.Parse(Console.ReadLine());

            if (codigoV == 4321)
            {
                Console.WriteLine("Vendedor encontrado:");
                Console.WriteLine("Codigo: " + 4321);
                Console.WriteLine("Vendedor: Luis");

            }
            else if (codigoV == 1234)
            {
                Console.WriteLine("Vendedor encontrado:");
                Console.WriteLine("Codigo: " + 1234);
                Console.WriteLine("Vendedor: Adrian");
            }
            else
            {
                Console.WriteLine("Este vendedor no existe.");
                Console.WriteLine("Presione enter para volver...");
                Console.ReadKey();
                Console.Clear();
                SeleccionOpc();
            }

            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigoVh == this.codigo[i])
                {
                    Console.WriteLine("La cantidad a pagar es de: $" + this.costo[i]);
                    Console.WriteLine("Presione enter para volver...");
                    Console.ReadKey();
                    Console.Clear();
                    SeleccionOpc();
                }
            }
        }

        public void Reportes()
        {
            Vendedores v = new Vendedores();
            Tipo t = new Tipo();
            Tipo.Automovil v1 = new Tipo.Automovil();
            Tipo.Motocicleta v2 = new Tipo.Motocicleta();
            Tipo.Dron v3 = new Tipo.Dron();
            Console.Clear();
            Console.WriteLine("***Reportes***");
            Console.WriteLine("Vendedores: ");
            v.ListadoVendedores();
            Console.WriteLine("\n" + "Tipos: ");
            t.Tipo_Vehiculo();
            v1.TipoVehiculo();
            v2.TipoVehiculo();
            v3.TipoVehiculo();

            Console.WriteLine("\n" + "Vehiculos ingresados: ");
            if (this.codigo[0] > 0)
            {
                for (int i = 0; i < codigo.Length; i++)
                {
                    if (this.codigo[i] > 0)
                    {
                        Console.WriteLine("Codigo: " + this.codigo[i] + " - " + "Marca: " + this.marca[i] + " - " + "Costo: " + this.costo[i] + " - " + "Modelo(año): " + this.modelo[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Aun no se ha agregado ningun vehiculo.");
            }

            Console.WriteLine("\n" + "Presione enter para volver...");
            Console.ReadKey();
            Console.Clear();
            SeleccionOpc();
        }
        public void Salir() { Environment.Exit(1); }
    }
}
