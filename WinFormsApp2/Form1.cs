namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private LinkedList<Persona> listaPersonas = new LinkedList<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = nombre_text.Text;
            int edad;

            // Validar la entrada de la edad
            if (int.TryParse(edad_text.Text, out edad))
            {
                // Crear una nueva persona
                Persona nuevaPersona = new Persona(nombre, edad);

                // Agregar la persona a la lista enlazada
                listaPersonas.AddLast(nuevaPersona);

                // Limpiar los campos del formulario
                LimpiarCampos();

                MessageBox.Show("Persona agregada con éxito");
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida");
            }
        }
        // Clase para representar a una persona
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
        }

        private void LimpiarCampos()
        {
            nombre_text.Text = string.Empty;
            edad_text.Text = string.Empty;
        }

        private void jove_Click(object sender, EventArgs e)
        {
            // Verificar si hay personas en la lista
            if (listaPersonas.Count > 0)
            {
                // Encontrar a la persona más joven
                Persona personaMasJoven = EncontrarPersonaMasJoven();

                // Mostrar el nombre de la persona más joven en una etiqueta
                data.Text = $"Persona más joven: {personaMasJoven.Nombre}, y su edad es {personaMasJoven.Edad}";

            }
            else
            {
                MessageBox.Show("No hay personas en la lista");
            }
        }

        private Persona EncontrarPersonaMasJoven()
        {
            int edadMinima = int.MaxValue;
            Persona personaMasJoven = null;

            foreach (Persona persona in listaPersonas)
            {
                if (persona.Edad < edadMinima)
                {
                    edadMinima = persona.Edad;
                    personaMasJoven = persona;
                }
            }

            return personaMasJoven;
        }

        private void viejo_Click(object sender, EventArgs e)
        {
            // Verificar si hay personas en la lista
            if (listaPersonas.Count > 0)
            {
                // Encontrar a la persona más vieja
                Persona personaMasVieja = EncontrarPersonaMasVieja();

                // Mostrar el nombre de la persona más vieja en una etiqueta
                data.Text = $"Persona más vieja: {personaMasVieja.Nombre}, y su edad es de: {personaMasVieja.Edad}";
            }
            else
            {
                MessageBox.Show("No hay personas en la lista");
            }
        }

        private Persona EncontrarPersonaMasVieja()
        {
            int edadMaxima = int.MinValue;
            Persona personaMasVieja = null;

            foreach (Persona persona in listaPersonas)
            {
                if (persona.Edad > edadMaxima)
                {
                    edadMaxima = persona.Edad;
                    personaMasVieja = persona;
                }
            }

            return personaMasVieja;
        }
    }
}
