using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace actividad07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prenda prenda = new Prenda();
            prenda.mostrarCalidad();
            prenda.Recibo();
        }
    }

    public abstract class TipoPrenda
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }

    public class Prenda : TipoPrenda
    {

        public string Size;
        public string Caracteristicas;
        public string Diseno;
        public int Calidad;
        public int opcTipo;
        public int opcPrenda;
        int i = 4;

        public Prenda(string size, string caracteristicas, string diseno, int calidad, int opcTipo, int opcPrenda)
        {
            this.Size = size;
            this.Caracteristicas = caracteristicas;
            this.Diseno = diseno;
            this.Calidad = calidad;
            this.opcTipo = opcTipo;
            this.opcPrenda = opcPrenda;
        }

        public Prenda(string nombre)
        {
            Nombre = nombre;
        }

        public Prenda()
        {
        }

        public void mostrarCalidad()
        {
            Console.WriteLine("---- Catalogo Prendas ----\n");
            Console.WriteLine("Eliga la calidad de la prenda que desea adquirir: ");
            Console.WriteLine("1. Basico");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Premiun");
            Calidad = Convert.ToInt32(Console.ReadLine());

            switch (Calidad)
            {
                case 1:
                    Console.Clear();
                    Basica();
                    break;

                case 2:
                    Console.Clear();
                    Medium();
                    break;

                case 3:
                    Console.Clear();
                    Premiun();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Seleccione una categoria valida porfavor");
                    mostrarCalidad();
                    break;
            }

        }

        public void Basica()
        {
            Console.WriteLine("---- CATALOGO PRENDAS CALIDAD BASICA ----");
            Console.WriteLine("1. Camisa");
            Console.WriteLine("2. Pantalon");
            Console.WriteLine("3. Vestido");
            Console.WriteLine("4. Ropa Interior");
            Console.WriteLine("Escoja la opcion del tipo de prenda que desea adquirir");
            opcTipo = Convert.ToInt32(Console.ReadLine());

            switch ( opcTipo )
            {
                case 1:
                    Nombre = "Camisa";
                    Console.WriteLine("--- CAMISAS CALIDAD BASICA ---");
                    Console.WriteLine("1. Marca: Lacoste");
                    Console.WriteLine("2. Marca: Paul & Shark");
                    Console.WriteLine("3. Marca: Original Penguin");
                    opcPrenda= Convert.ToInt32(Console.ReadLine());
                    while ( opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Cuello en V";
                            Caracteristicas = "Color: Negro.\n Sin estampados\n Marca: Lacoste";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Mangas Largas";
                            Caracteristicas = "Color: Blanco. \nEstampado: Lineas Verticales\n Marca: Paul & Shark";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Mangas Cortas";
                            Caracteristicas = "Color: Gris \nEstampado: No \nMarca: Original Penguin";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                    }
                    break;

                case 2:
                    Nombre = "Pantalon";
                    Console.WriteLine("--- PANTALON CALIDAD BASICA ---");
                    Console.WriteLine("1. Marca: Cos");
                    Console.WriteLine("2. Marca: Cargo");
                    Console.WriteLine("3. Marca: Lacoste");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());


                    while ( opcPrenda < 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Skinny";
                            Caracteristicas = "Color: Negro. \nMarca: Lacoste";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            opcPrenda = 5;
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Recto";
                            Caracteristicas = "Color: Gris \nMarca: Cargo";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Slim";
                            Caracteristicas = "Color: Azul \nMarca: Lacoste";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                    }
                    break;

                case 3:
                    Nombre = "Vestido";
                    Console.WriteLine("--- VESTIDO CALIDAD BASICA ---");
                    Console.WriteLine("1. Marca: Rixo");
                    Console.WriteLine("2. Marca: Musier");
                    Console.WriteLine("3. Marca: Marcia");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Escote Pronunciado";
                            Caracteristicas = "Color: Negro. \nMarca: Rixo";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Mangas en globo";
                            Caracteristicas = "Color: Blanco y Negro \nMarca: Musier";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Tejido Floral";
                            Caracteristicas = "Color: Rojo \nMarca: Musier";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Recibo();
                            Console.ReadLine();
                        }
                    }  
                    break;

                case 4:
                    Nombre = "Ropa Interior";
                    Console.WriteLine("--- ROPA INTERIOR CALIDAD BASICA ---");
                    Console.WriteLine("1. Marca: Calvin Klein");
                    Console.WriteLine("2. Marca: Victoria Secret");
                    Console.WriteLine("3. Marca: Derek");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Boxer";
                            Caracteristicas = "Color: Gris \nMarca: Calvin Klein";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Hipster";
                            Caracteristicas = "Color: Negro \nMarca: Victoria Secret";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                        else if (opcPrenda == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Boxer";
                            Caracteristicas = "Colo: Azul \nMarca: Derek";
                            Console.WriteLine("Diseño: " + Diseno);
                            Console.WriteLine("Caracteristicas: " + Caracteristicas);
                            Console.WriteLine("\n");
                            Console.WriteLine("Escriba cual es la talla que desea su " + Nombre);
                            Size = Console.ReadLine();
                            opcPrenda = 5;
                            Console.WriteLine("**** PROCESANDO SU PEDIDO ****");
                            Console.ReadLine();
                        }
                    } 
                    break;

                default:
                    Basica();
                    break;
            }

        }
        public void Medium()
        {
            Console.WriteLine("---- CATALOGO PRENDAS CALIDAD MEDIUM ----");
            Console.ReadLine();
        }
        public void Premiun()
        {
            Console.WriteLine("---- CATALOGO PRENDAS CALIDAD PREMIUN ----");
            Console.ReadLine();
        }

        public void Recibo()
        {
            Console.Clear();
            Console.WriteLine("--- FACTURA COMPRA ---\n");
            Console.WriteLine("Tipo de Prenda: " + Nombre);
            Console.WriteLine("Diseño: " + Diseno);
            Console.WriteLine("Caracteristicas: " + Caracteristicas);
            Console.WriteLine("Talla: " + Size);
            Console.WriteLine("\n *** GRACIAS POR SU COMPRA ***");
            Console.ReadLine();
        }

    }



}
