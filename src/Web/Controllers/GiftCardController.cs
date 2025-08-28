using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class GiftCardController : ControllerBase
{
  [HttpPost]
  public ActionResult CreateGiftCard()
  {
    return Ok();
  }
}