using YPF.Application.Responses;
using MediatR;

namespace YPF.Application.Requests;

public record BursatilListRequest 
    : IRequest<IEnumerable<BursatilListResponse>>
{
}
