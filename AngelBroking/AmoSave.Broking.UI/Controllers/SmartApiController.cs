using Microsoft.AspNetCore.Mvc;
using AngelBroking;
using System;
using AmoSave.Broking.Models.Session;
using AmoSave.Broking.Models.Client;

namespace AmoSave.Broking.UI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmartApiController : ControllerBase
    {
        private readonly SmartApi _smartApi;

        // You may want to use dependency injection for configuration/secrets
        public SmartApiController()
        {
            // Replace with your actual private key and optionally tokens
            _smartApi = new SmartApi("YOUR_PRIVATE_KEY");
        }

        [HttpPost("GenerateSession")]
        public IActionResult GenerateSession([FromBody] SessionRequest request)
        {
            var result = _smartApi.GenerateSession(request.ClientCode, request.Password);
            return Ok(result);
        }

        [HttpPost("GenerateToken")]
        public IActionResult GenerateToken()
        {
            var result = _smartApi.GenerateToken();
            return Ok(result);
        }

        [HttpGet("GetProfile")]
        public IActionResult GetProfile()
        {
            var result = _smartApi.GetProfile();
            return Ok(result);
        }

        [HttpPost("LogOut")]
        public IActionResult LogOut([FromBody] ClientCodeRequest request)
        {
            var result = _smartApi.LogOut(request.ClientCode);
            return Ok(result);
        }

        [HttpGet("GetRMS")]
        public IActionResult GetRMS()
        {
            var result = _smartApi.getRMS();
            return Ok(result);
        }

        [HttpPost("PlaceOrder")]
        public IActionResult PlaceOrder([FromBody] OrderInfo order)
        {
            var result = _smartApi.placeOrder(order);
            return Ok(result);
        }

        [HttpPost("ModifyOrder")]
        public IActionResult ModifyOrder([FromBody] OrderInfo order)
        {
            var result = _smartApi.modifyOrder(order);
            return Ok(result);
        }

        [HttpPost("CancelOrder")]
        public IActionResult CancelOrder([FromBody] OrderInfo order)
        {
            var result = _smartApi.cancelOrder(order);
            return Ok(result);
        }

        [HttpGet("GetOrderBook")]
        public IActionResult GetOrderBook()
        {
            var result = _smartApi.getOrderBook();
            return Ok(result);
        }

        [HttpGet("GetTradeBook")]
        public IActionResult GetTradeBook()
        {
            var result = _smartApi.getTradeBook();
            return Ok(result);
        }

        [HttpPost("GetLTPData")]
        public IActionResult GetLTPData([FromBody] LTPDataRequest req)
        {
            var result = _smartApi.GetLTPData(req);
            return Ok(result);
        }

        [HttpGet("GetHolding")]
        public IActionResult GetHolding()
        {
            var result = _smartApi.getHolding();
            return Ok(result);
        }

        [HttpGet("GetPosition")]
        public IActionResult GetPosition()
        {
            var result = _smartApi.getPosition();
            return Ok(result);
        }

        [HttpPost("ConvertPosition")]
        public IActionResult ConvertPosition([FromBody] ConvertPositionRequest req)
        {
            var result = _smartApi.convertPosition(req);
            return Ok(result);
        }

        [HttpPost("CreateRule")]
        public IActionResult CreateRule([FromBody] CreateRuleRequest req)
        {
            var result = _smartApi.CreateRule(req);
            return Ok(result);
        }

        [HttpPost("ModifyRule")]
        public IActionResult ModifyRule([FromBody] CreateRuleRequest req)
        {
            var result = _smartApi.modifyRule(req);
            return Ok(result);
        }

        [HttpPost("CancelRule")]
        public IActionResult CancelRule([FromBody] CancelRuleRequest req)
        {
            var result = _smartApi.cancelRule(req);
            return Ok(result);
        }

        [HttpGet("RuleDetails/{ruleId}")]
        public IActionResult RuleDetails(string ruleId)
        {
            var result = _smartApi.ruleDetails(ruleId);
            return Ok(result);
        }

        [HttpPost("RuleList")]
        public IActionResult RuleList([FromBody] RuleListRequest req)
        {
            var result = _smartApi.ruleList(req);
            return Ok(result);
        }

        [HttpPost("GetCandleData")]
        public IActionResult GetCandleData([FromBody] CandleRequest req)
        {
            var result = _smartApi.GetCandleData(req);
            return Ok(result);
        }
    }
}
