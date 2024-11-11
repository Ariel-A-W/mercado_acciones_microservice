using LomaNegra.Application.Responses;
using MediatR;

namespace LomaNegra.Application.Requests;

public record BursatilListRequest 
    : IRequest<IEnumerable<BursatilListResponse>>
{
}
