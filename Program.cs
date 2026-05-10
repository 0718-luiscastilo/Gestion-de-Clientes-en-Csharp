using System;

public class Program{
    public static void CalcularMonto (int[] mont){
        int suma=0;
        for(int i =0; i<mont.Length;i++)  {
            suma = suma + mont[i];
        }
        int promedio = suma / mont.Length;
        Console.WriteLine("Monto total: " + suma);
        Console.WriteLine("Promedio: " + promedio);
        }
    public static void ClasificarClientes(string[] nom, int[] mont){
        int contador =0;
        for( int i =0; i<mont.Length; i++){
            string clasificacion = "";
            if(mont[i]<500){
                clasificacion = "Regular";
            }
            else if(mont[i]<=1000){
                clasificacion = "Frecuente";
            }
            else{
                clasificacion = "VIP";
            }

            if(clasificacion == "VIP"){
                contador++;
            }
            Console.WriteLine(nom[i] + " - " + mont[i] + " - " + clasificacion);
            
        }
        Console.WriteLine("Clientes VIP: " + contador);
        
    }
    public static bool ValidarCorreo(string correo){
        if(correo.Contains("@")){
            return true;
    }
        else{
            return false;
    }

}
public static void BuscarCliente(string[] nombres, string[] correos, int[] montos, string nombreBuscar){

    bool encontrado = false;

    for(int i = 0; i < nombres.Length; i++){

        if(nombres[i].Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase)){

            string clasificacion = "";

            if(montos[i] < 500){
                clasificacion = "Regular";
            }
            else if(montos[i] <= 1000){
                clasificacion = "Frecuente";
            }
            else{
                clasificacion = "VIP";
            }

            Console.WriteLine("Cliente encontrado:");
            Console.WriteLine("Nombre: " + nombres[i]);
            Console.WriteLine("Correo: " + correos[i]);
            Console.WriteLine("Monto: " + montos[i]);
            Console.WriteLine("Clasificación: " + clasificacion);

            encontrado = true;
            break;
        }
    }

    if(!encontrado){
        Console.WriteLine("Cliente no encontrado.");
    }
}
    public static void Main(string[] args){
        Console.WriteLine("Ingrese la cantidad de Clientes: ");
        int cantidadClientes = int.Parse(Console.ReadLine());
        string[] nombres = new string[cantidadClientes];
        string[] correo = new string[cantidadClientes];
        int[] monto = new int[cantidadClientes];

        for(int i=0; i<cantidadClientes;i++){
            Console.WriteLine("Cliente " + (i+1) + ": ");
            Console.WriteLine("Nombre: ");
            string nombreClientes = Console.ReadLine();
            Console.WriteLine("Correo: ");
            string correoCliente = Console.ReadLine();
            while(!ValidarCorreo(correoCliente)){
                Console.WriteLine("Correo inválido. Intente nuevamente: ");
                correoCliente = Console.ReadLine();
                }
            Console.WriteLine("Monto: ");
            int montoClientes = int.Parse(Console.ReadLine());
            nombres[i] = nombreClientes;
            correo[i] = correoCliente;
            monto[i] = montoClientes;
        }

        Console.WriteLine("-----------------");
        ClasificarClientes(nombres, monto);
        CalcularMonto(monto);

        Console.WriteLine("Buscar cliente por nombre:");
        string nombreBuscar = Console.ReadLine();
        BuscarCliente(nombres, correo, monto, nombreBuscar);

    }
}