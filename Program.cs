using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLMADO
    {
    class Program
    {
        private struct Ventas
        {
            public string NOMBREproductos { get; set; }
            public List<string> NOMBREclientes { get; set; }
        }
        private static List<string> Productos = new List<string>();
        private static List<string> clientes = new List<string>();
        private static List<Ventas> SelecciondeProductos = new List<Ventas>();
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.Clear();

            }
        }
        private static void menu()

        {

            Console.Write("\t\t\t\t\t\t\tItla Market \n");
            Console.WriteLine("Seleccione la opcion que desea realizar: \n 1.Productos para el colmado \n 2.Servicio al Cliente \n 3.Realizar ventas \n 4.Salir \n");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    menuProductos();
                    break;
                case 2:
                    menuclientes();
                    break;
                case 3:
                    ListarVentas();

                    break;
                case 4:
                    break;
            }
        }


        private static void menuProductos()
        {
            Console.Clear();

            Console.WriteLine("Mantenimiendo del colmado \n");
            Console.WriteLine("Seleccione la opcion que desea realizar\n1.Agregar producto\n2.Listar producto\n3.Editar producto\n4.Eliminar producto\n\n 5.volver al menu principal\n");
            int menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    List(Productos, true);
                    menuProductos();
                    break;
                case 3:
                    EditarProducto();
                    break;
                case 4:
                    EliminarProducto();
                    break;
            }
        }

        private static void AgregarProducto()
        {
            Console.Write("Introduzca el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca el Precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());
            Add(Productos, nombre + precio);




            menuProductos();
        }
        private static void EditarProducto()
        {
            Console.WriteLine("Listado de productos");
            List(Productos, false);
            Console.WriteLine("Seleccione el producto que desea editar");
            int Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del nuevo producto ");
            string nombre = Console.ReadLine();
            Edit(Productos, (Index - 1), nombre);
            menuProductos();
        }


        private static void EliminarProducto()
        {
            Console.WriteLine("Eiminar productos");
            List(Productos, false);
            Console.WriteLine("seleccione el producto que desea eliminar");
            int index = Convert.ToInt32(Console.ReadLine());
            Delete(Productos, (index - 1));
            menuProductos();
        }





        private static void menuclientes()
        {
            Console.Clear();
            Console.WriteLine("Servicio al cliente \n");
            Console.WriteLine("Seleccione la opcion que desea realizar\n1.Agregar cliente\n2.Listar cliente\n3.Editar cliente\n4.Eliminar cliente\n \n 5.volver al menu principal\n");

            int menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (menu)

            {

                case 1:
                    Agregarcliente();
                    break;
                case 2:
                    List(clientes, true);
                    menuclientes();
                    break;
                case 3:
                    Editarcliente();
                    break;
                case 4:
                    Eliminarcliente();
                    break;
            }
        }
        private static void Agregarcliente()
        {
            Console.WriteLine("Introduzca el nombre del cliente");

            string nombre = Console.ReadLine();
            Add(clientes, nombre);
            menuclientes();
        }

        private static void Editarcliente()
        {
            Console.WriteLine("Listado de clientes");
            List(clientes, false);
            Console.WriteLine("Seleccione el cliente que desea editar");
            int Index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del nuevo cliente ");
            string nombreP = Console.ReadLine();
            Edit(clientes, (Index - 1), nombreP);
            menuclientes();
        }


        private static void Eliminarcliente()
        {
            Console.WriteLine("Eiminar clientes");
            List(clientes, false);
            Console.WriteLine("seleccione el cliente que desea eliminar");
            int index = Convert.ToInt32(Console.ReadLine());
            Delete(clientes, (index - 1));
            menuclientes();
        }
        private static void List<T>(List<T> Listado, bool ISwait)
        {
            int contador = 1;
            foreach (T item in Listado)
            {

                Console.WriteLine(contador + "." + item);
                contador++;

            }
            if (ISwait)
            {
                Console.ReadKey();
            }

        }
        private static void Add<T>(List<T> Listado, T item)
        {
            Listado.Add(item);
        }
        private static void Edit<T>(List<T> Listado, int Index, T value)
        {
            Listado[Index] = value;
        }

        private static void Delete<T>(List<T> Listado, int Index)
        {
            Listado.RemoveAt(Index);
        }
        private static void ListarVentas()
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("Bienvenio a itla market!,\tDesea comprar? \n");
                Console.WriteLine(" 1.realisar venta \n 2.volver al menu principal \n ");
                int menu = Convert.ToInt32(Console.ReadLine());
                bool salir = false;

                switch (menu)
                {
                    case 1:

                        //
                        break;

                    case 2:
                        salir = true;
                        break;








                }
            }
        }
    }
}

