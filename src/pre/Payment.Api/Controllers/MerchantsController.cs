using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Payment.Application.Base.Models;
using Payment.Application.Features.Commands;
using Payment.Application.Features.Merchant.Commands;

namespace Payment.Api.Controllers
{
	/// <summary>
	/// API for CRUD with Merchant
	/// </summary>
	[Route("api/[controller]")]
	[ApiController]
	public class MerchantsController : ControllerBase
	{
		/// <summary>
		/// GET Merchant base on criteria
		/// </summary>
		/// <param name="criteria"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult Get(string criteria)
		{
			return Ok();
		}
		/// <summary>
		/// GET Merchant paging
		/// </summary>
		/// <param name="query"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("with-paging")]
		public IActionResult GetPaging([FromQuery]BasePagingQuery  query)
		{
			return Ok();
		}
		/// <summary>
		/// GET One Merchant = id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpGet]
		[Route("{id}")]
		public IActionResult GetOne([FromRoute]string id)
		{
			return Ok(id);
		}
		/// <summary>
		/// Create Merchant
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		[HttpPost]
		public IActionResult Create([FromBody]CreateMerchant request)
		{
			return Ok();
		}
		/// <summary>
		/// Update Merchant
		/// </summary>
		/// <param name="id"></param>
		/// <param name="request"></param>
		/// <returns></returns>
		[HttpPut]
		[Route("{id}")]
		public IActionResult Update(string id, [FromBody]UpdateMerchant request)
		{
			return Ok();
		}
		/// <summary>
		/// Set Active Flag
		/// </summary>
		/// <param name="id"></param>
		/// <param name="request"></param>
		/// <returns></returns>
		[HttpPut]
		[Route("{id}/set-active")]
		public IActionResult SetActive(string id, [FromBody] SetActiveMerchant request)
		{
			return Ok();
		}
		/// <summary>
		/// Delete Merchant
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[HttpDelete]
		[Route("{id}")]
		public IActionResult Delete(string id)
		{
			return Ok();
		}
	}
}
