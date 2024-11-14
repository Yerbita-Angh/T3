using CitasMedicas;
class Program
{
    static void Main(string[] args)
    {
        List<Cita> citas = new List<Cita>();
        int opcion;

        do
        {
            Console.WriteLine("\n--- Menú de Opciones ---");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Universidad");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CitaUtil.CrearCita(citas);
                    break;
                case 2:
                    CitaUtil.ListarCitas(citas);
                    break;
                case 3:
                    CitaUtil.ModificarUniversidad(citas);
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 4);
    }
}