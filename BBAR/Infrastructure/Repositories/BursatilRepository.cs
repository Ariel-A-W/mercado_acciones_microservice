using BBAR.Domain;

namespace BBAR.Infrastructure.Repositories;

public class BursatilRepository : IBursatil
{
    public IEnumerable<Bursatil> GetAll()
    {
        List<Bursatil> list = new List <Bursatil>();
        list.Add(
            new Bursatil() {
                Id = new ID(1), 
                Especie = new Especie("BBAR"),
                Ultimo = new Ultimo(3890.00M), 
                Dia = new Dia(8.21M),
                Mes = new Mes(5.71M),    
                Anio = new Anio(108.02M), 
                Anterior = new Anterior(3595.00M), 
                Apertura = new Apertura(3750.00M), 
                Minimo = new Minimo(3750.00M), 
                Maximo = new Maximo(3890.00M), 
                Hora = new Hora(DateTime.Now), 
                VolumenNominal = new VolumenNominal(3M), 
                Volumen = new Volumen(1080987620.00M)
            }    
        );
        return list;        
    }
}
