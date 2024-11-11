using BBAR.Application.Requests;
using BBAR.Application.Responses;
using BBAR.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BBAR.Controllers;

[ApiController]
[Route("/[controller]/")]
public class BursatilController : ControllerBase
{
    private readonly ISender _sender;

    public BursatilController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("/[controller]/getall")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BursatilListResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<IEnumerable<BursatilListResponse>> GetAll(
        CancellationToken cancellationToken
    )
    {
        var query = new BursatilListRequest();

        var registros = _sender.Send(query, cancellationToken);

        if (registros is null)
            return NotFound();

        return Ok(registros.Result);
    }
}
