namespace Recuperacion_Unidad_3_FAOG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            Carro carro = new Carro();
            int opcion = 0;
            string opcionS = "";
            string modelo = "";
            int año = 0;
            string marca = "";
            while(opcion != 4)
            {
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1 Agregar ");
                Console.WriteLine("2 Buscar");
                Console.WriteLine("3 Mostrar");
                Console.WriteLine("4 Ordenado Desendente");
                Console.WriteLine("5 Salir");
                opcionS = Console.ReadLine();
                if (opcionS == "")
                {
                    Console.WriteLine("Ingresar un valor, intente de nuevo plis");

                }
                else
                {
                    switch (opcionS)
                    {
                        case "1":
                            Console.WriteLine("Ingrese el Modelo");
                            modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese la Marca");
                            marca = Console.ReadLine();
                            Console.WriteLine("Ingrese el Año");
                            año=Convert.ToInt32(Console.ReadLine());
                            carro = new Carro
                            {
                                Modelo = modelo,

                                Marca = marca,

                                Año = año                               
                            };
                            lista.Insertar(carro);
                            break;
                        case "2":
                            Console.WriteLine("Ingrese la marca del Automovil");
                            marca = Console.ReadLine();
                            lista.BuscarTodos(marca);
                            break;
                            case "3":
                            lista.MostraLista();
                            break;
                            case "4":
                            opcion=Convert.ToInt32(opcionS);
                            break;
                            case "5":
                            lista.OrdenarDescendente();
                            break;
                        default:
                            Console.WriteLine("Selecciona una opcion");
                            break;
                    }
                }
            }
        }
    }
}