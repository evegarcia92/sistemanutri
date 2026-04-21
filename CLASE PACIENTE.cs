using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_PACIENTE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //testeo

            //para agregar un paciente nuevo: primero el tipo de dato y luego un nombre random para la lista = new nombre de la clase y en parentesis los valores directamente del constructor\
            //DateTime(2025, 3, 19)
            Paciente paciente1 = new Paciente("Nala", "Garcia", 1234, "1223444443", new DateTime(2025, 3, 19));

            Console.WriteLine(paciente1.Nombre);
            Console.WriteLine(paciente1.Apellido);
            Console.WriteLine(paciente1.Telefono);

            paciente1.Registrarse();
            Console.WriteLine(Paciente.Pacientes.Count); // debería mostrar 1

            paciente1.Telefono = "999999999";
            Console.WriteLine(paciente1.Telefono); // debería mostrar el nuevo teléfono







        }
    }
    public class Paciente
    {
        //atributos de clase
        //tipo de dato es la lista pacientes el nombre del atributo

        private static List<Paciente> pacientes = new List<Paciente>();

        //atributos de instancia

        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fechaNacimiento;
        private string domicilio;
        private string telefono;
        private string obraSocial;
        private string numeroAfiliado;
        private string email;
        //atributo de referencia entre clases:
        private PlanAlimentario planAlimentario;
        private Chat chat;
        private List<Turno> turnos = new List<Turno>();
        private List<DatosAntropometricos> datosAntropometricos = new List<DatosAntropometricos>();

        //constructor

        public Paciente(string nombre, string apellido, int dni, string telefono, DateTime fechaNacimiento)

        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;

        }

        //propiedades

        public string Nombre
        {
            get { return nombre; }
        }
        public string Apellido
        {
            get { return apellido; }
        }
        public int Dni
        {
            get { return dni; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }
        public string NumeroAfiliado
        {
            get { return numeroAfiliado; }
            set { numeroAfiliado = value; }
        }
        public static List<Paciente> Pacientes
        {
            get { return pacientes; }
        }
        // PlanAlimentario: tipo de dato, la clase Plan Alimentario que tengo que hacer
        //segundo PlanAlimentario el nombre de la propiedad
        public PlanAlimentario PlanAlimentario
        {
            get { return planAlimentario; }
            set { planAlimentario = value; }
        }
        public Chat Chat
        {
            get { return chat; }
            set { chat = value; }
        }
        public List<DatosAntropometricos> DatosAntropometricos
        {
            get { return datosAntropometricos; }
            set { datosAntropometricos = value; }
        }
        public List<Turno> Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }
        // comandos

        public void Registrarse()
        {
            Pacientes.Add(this);
        }
        /*public void SacarTurno(DateTime fecha, TimeSpan hora)
        {
            Turno turno = new Turno(fecha, hora, this);
            turnos.Add(turno);
        }
       /* public void SubirRegistroAlimentario(string rutaArchivo)
        {
            /* RegistroAlimentario es el tipo del objeto que vamos a crear
             * registro es el nombre que le damos a ese objeto dentro del metodo
             * =new RegistroAlimentario() crea el objeto
             * rutaArchivo le pasa la ruta del archivo al constructor de RegistroAlimentario
             * this le pasa el paciente actual para que el registro sepa a quien pertenece */
         //   RegistroAlimentario registro = new RegistroAlimentario(rutaArchivo, this);
            // registro es el objeto que acabamos de crear, .Guardar() llama al metodo Guardar () de RegistroAlimentario que se encarga de guardarlo en el sistema del Registro alimentario que tengo que crear
         //   registro.Guardar();
       // }
        
        /*public void DescargarPlanAlimentario()
        {
            planAlimentario.Descargar();
        }*/
        /*public void EnviarMensaje(string mensaje)
        {
            //atributo de referencia y accion: le pasa el texto del mensaje y el paciente que lo envia
            chat.EnviarMensaje(mensaje, this);
        }*/
        //consultas
        public List<DatosAntropometricos> VerDatosAntropometricos()
        {
            return datosAntropometricos;
        }
        //VerDatosAntopometricos muestra las mediciones de una consulta puntual y VerSeguimiento provee los datos para graficar la evolucion en el tiempo

        public List<DatosAntropometricos> VerSeguimiento()
        {
            return datosAntropometricos;
         }


    }


    public class Turno { }
    public class PlanAlimentario { }
    public class Chat { }
    public class DatosAntropometricos { }
    public class RegistroAlimentario { }


    

}



















