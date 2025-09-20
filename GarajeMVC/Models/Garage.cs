namespace GarajeMVC.Models
{
    public class Garage
    {
        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosOcupados { get; set; }
        
        public List<Auto> Autos { get; set; }
        public Garage(int numeroGaraje, string descripcion, int
        capacidadEspacios, int espaciosOcupados)
        {
        NumeroGaraje = numeroGaraje; 
        Descripcion = descripcion; 
        CapacidadEspacios = capacidadEspacios; 
        EspaciosOcupados = espaciosOcupados; 
        
        Autos = new List<Auto>();
        }

        public void ingresarAuto(Auto auto)
        { 
         // Agrega el objeto Auto a la lista de autos del garaje
         this.Autos.Add(auto); 
            
         //incrementar los espacios ocupados //
         this.EspaciosOcupados++;
        }

        public List<Auto> getAutos()
        { 
        return this.Autos;
        }


    }


}
