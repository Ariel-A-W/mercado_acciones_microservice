namespace YPF.Domain;

public class Bursatil
{
    public ID? Id { get; set; }
    public Especie? Especie { get; set; }
    public Ultimo? Ultimo { get; set; }
    public Dia? Dia { get; set; }
    public Mes? Mes { get; set; }
    public Anio? Anio { get; set; }
    public Anterior? Anterior { get; set; }
    public Apertura? Apertura { get; set; }
    public Minimo? Minimo { get; set; }
    public Maximo? Maximo { get; set; }
    public Hora? Hora { get; set; }
    public VolumenNominal? VolumenNominal { get; set; }
    public Volumen? Volumen { get; set; }
}
