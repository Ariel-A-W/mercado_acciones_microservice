using YPF.Application.Requests;
using YPF.Application.Responses;
using YPF.Domain;
using MediatR;

namespace YPF.Application.Queries;

public class BursatilListHandler
    : IRequestHandler<BursatilListRequest, IEnumerable<BursatilListResponse>>
{
    private readonly IBursatil _bursatil;

    public BursatilListHandler(IBursatil bursatil)
    {
        _bursatil = bursatil;
    }

    public async Task<IEnumerable<BursatilListResponse>> Handle(
        BursatilListRequest request,
        CancellationToken cancellationToken
    )
    {
        var bolsa = _bursatil.GetAll();

        var lst = new List<BursatilListResponse>();

        var bls = (from bl in bolsa
                   select bl);

        foreach (var item in bolsa)
        {
            lst.Add(
                new BursatilListResponse()
                {
                    Especie = item.Especie!.Value,
                    Ultimo = item.Ultimo!.Value,
                    Dia = item.Dia!.Value,
                    Mes = item.Mes!.Value,
                    Anio = item.Anio!.Value,
                    Anterior = item.Anterior!.Value,
                    Apertura = item.Apertura!.Value,
                    Minimo = item.Minimo!.Value,
                    Maximo = item.Maximo!.Value,
                    Hora = item.Hora!.GetHora,
                    VolumenNominal = item.VolumenNominal!.Value,
                    Volumen = item.Volumen!.Value
                }
            );
        }

        return lst;
    }
}
