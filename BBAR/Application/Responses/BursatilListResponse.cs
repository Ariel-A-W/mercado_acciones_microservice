namespace BBAR.Application.Responses;

public record BursatilListResponse
{ 
    public string? Especie { get; set; }
    public decimal Ultimo { get; set; }
    public decimal Dia { get; set; }
    public decimal Mes { get; set; }
    public decimal Anio { get; set; }
    public decimal Anterior { get; set; }
    public decimal Apertura { get; set; }
    public decimal Minimo { get; set; }
    public decimal Maximo { get; set; }
    public string? Hora { get; set; }
    public decimal VolumenNominal { get; set; }
    public decimal Volumen { get; set; }
}
