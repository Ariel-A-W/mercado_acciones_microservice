using BBAR.Application.Responses;
using MediatR;

namespace BBAR.Application.Requests;

public record BursatilListRequest 
    : IRequest<IEnumerable<BursatilListResponse>>
{
}
