using System;

namespace E_migrant.App.Dominio{

    public class Dominio{
        private int Id { get; set; };
        private string nombre { get; set; };
        private string apellidos { get; set; };
        private string tipo_documento { get; set; };
        private string documento { get; set; };
        private string pais { get; set; };
        private string nacimiento { get; set; };
    }
}