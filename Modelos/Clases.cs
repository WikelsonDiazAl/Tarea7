using System.ComponentModel.DataAnnotations;

public class Detencion{

    [Key]
    public int IdDentencion {get; set;} = 0;
    public string Nombre {get; set;} = "";
    public string Apellido {get; set;} = "";
    public string NumPasaporte {get; set;} = "";
    public DateTime? FechaNacimiento {get; set;} 
    public double Longitud {get; set;} = 0;
    public double Latitud {get; set;} = 0;
    public DateTime FechaDetencion {get; set;} = DateTime.Now;
    public string Coordenadas(){
        return $"{Latitud}, {Longitud}";
    }
}