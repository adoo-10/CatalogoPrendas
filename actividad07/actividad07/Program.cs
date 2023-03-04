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

        //catalogo de ropa media
        public void Medium()
        {
            Console.WriteLine("---- CATALOGO PRENDAS CALIDAD MEDIUM ----");
            Console.WriteLine("1. Camisa");
            Console.WriteLine("2. Pantalon");
            Console.WriteLine("3. Vestido");
            Console.WriteLine("4. Ropa Interior");
            Console.WriteLine("Escoja la opcion del tipo de prenda que desea adquirir");
            opcTipo = Convert.ToInt32(Console.ReadLine());

            switch (opcTipo)
            {
                case 1:
                    Nombre = "Camisa";
                    Console.WriteLine("--- CAMISAS CALIDAD MEDIUM ---");
                    Console.WriteLine("1. Marca: Scotta 1985");
                    Console.WriteLine("2. Marca: Tom Tailor");
                    Console.WriteLine("3. Marca: Tommy");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Cuello en normal";
                            Caracteristicas = "Color: Azul.\n Sin estampados\n Marca: Scotta 1985";
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
                            Caracteristicas = "Color: Blanco y Negro. \nEstampado: Cuadriculada\n Marca: Tom Tailor";
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
                            Diseno = "Camiseta";
                            Caracteristicas = "Color: Naranja \nEstampado: si logo de marca \nMarca: Tommy";
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
                    Console.WriteLine("--- PANTALON CALIDAD MEDIUM ---");
                    Console.WriteLine("1. Marca: Logophile");
                    Console.WriteLine("2. Marca: Frame");
                    Console.WriteLine("3. Marca: Calvin Klein");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());


                    while (opcPrenda < 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Boyfriend";
                            Caracteristicas = "Color: Negro. \nMarca: Logophile";
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
                            Caracteristicas = "Color: azul Negro \nMarca: Frame";
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
                            Diseno = "Palazzo";
                            Caracteristicas = "Color: Blanco \nMarca: Calvin Klein";
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
                    Console.WriteLine("--- VESTIDO CALIDAD MEDIUM ---");
                    Console.WriteLine("1. Marca: Hermès");
                    Console.WriteLine("2. Marca: Chanel");
                    Console.WriteLine("3. Marca: Givenchy");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "para gala";
                            Caracteristicas = "Color: Negro. \nMarca: Hermès";
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
                            Diseno = "Abertura lateral";
                            Caracteristicas = "Color: Rojo \nMarca: Chanel";
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
                            Diseno = "Sin Escote";
                            Caracteristicas = "Color: Dorado \nMarca: Givenchy";
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
                    Console.WriteLine("--- ROPA INTERIOR CALIDAD MEDIUM ---");
                    Console.WriteLine("1. Marca: H&M");
                    Console.WriteLine("2. Marca: Hugo Boss");
                    Console.WriteLine("3. Marca: Giorgio Armani");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Cachetero";
                            Caracteristicas = "Color: Gris \nMarca: H&M";
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
                            Diseno = "Boxer";
                            Caracteristicas = "Color: Negro \nMarca: Hugo Boss";
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
                            Diseno = "Calzoncillos Briefs";
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
                    Medium();
                    break;

            }
        }


    //catalogo de repa premiun
    public void Premiun()
        {
            Console.WriteLine("---- CATALOGO PRENDAS CALIDAD PREMIUN ----");
            Console.WriteLine("1. Camisa");
            Console.WriteLine("2. Pantalon");
            Console.WriteLine("3. Vestido");
            Console.WriteLine("4. Ropa Interior");
            Console.WriteLine("Escoja la opcion del tipo de prenda que desea adquirir");
            opcTipo = Convert.ToInt32(Console.ReadLine());

            switch (opcTipo)
            {
                case 1:
                    Nombre = "Camisa";
                    Console.WriteLine("--- CAMISAS CALIDAD PREMIUN ---");
                    Console.WriteLine("1. Marca: Louis Vuitton");
                    Console.WriteLine("2. Marca: Gucci");
                    Console.WriteLine("3. Marca: Balenciaga");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = " Mangas Cortas ";
                            Caracteristicas = "Color: Roja.\n Sin estampados\n Marca: Louis Vuitton";
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
                            Caracteristicas = "Color: Gris. \nEstampado: Sin estampados\n Marca: Gucci";
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
                            Diseno = "Mangas largas";
                            Caracteristicas = "Color: Negra \nEstampado: Sin estampados \nMarca: Balenciaga";
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
                    Console.WriteLine("--- PANTALON CALIDAD PREMIUN ---");
                    Console.WriteLine("1. Marca: Escada Sport");
                    Console.WriteLine("2. Marca:  Levi Strauss & Co");
                    Console.WriteLine("3. Marca: Circo secreto");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());


                    while (opcPrenda < 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Flare";
                            Caracteristicas = "Color: Gris. \nMarca: Escada Sport";
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
                            Caracteristicas = "Color: Negro \nMarca: Levi Strauss & Co";
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
                            Diseno = "High Waist";
                            Caracteristicas = "Color: azul \nMarca: Circo secreto";
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
                    Console.WriteLine("--- VESTIDO CALIDAD PREMIUN ---");
                    Console.WriteLine("1. Marca: Oscar de la Renta");
                    Console.WriteLine("2. Marca: Burberry");
                    Console.WriteLine("3. Marca: Yves Saint Laurent");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Sin Escote";
                            Caracteristicas = "Color: Azul Cielo. \nMarca: Oscar de la Renta";
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
                            Diseno = "Abertura lateral";
                            Caracteristicas = "Color: Gris \nMarca: Burberry";
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
                            Diseno = "Con Escote";
                            Caracteristicas = "Color: Rosado \nMarca: Yves Saint Laurent";
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
                    Console.WriteLine("--- ROPA INTERIOR CALIDAD PREMIUN ---");
                    Console.WriteLine("1. Marca: Love Stories");
                    Console.WriteLine("2. Marca: Nice Laundry");
                    Console.WriteLine("3. Marca: Polo Ralph Lauren");
                    opcPrenda = Convert.ToInt32(Console.ReadLine());
                    while (opcPrenda > 4)
                    {
                        if (opcPrenda == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("--- Informacion " + Nombre + " ---\n");
                            Diseno = "Tanga";
                            Caracteristicas = "Color: Rojo \nMarca: Love Stories";
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
                            Diseno = "Calzoncillos Briefs";
                            Caracteristicas = "Color: Blanco \nMarca: Nice Laundry";
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
                            Caracteristicas = "Colo: Negro \nMarca: Polo Ralph Lauren";
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
                    Premiun();
                    break;

            }
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
