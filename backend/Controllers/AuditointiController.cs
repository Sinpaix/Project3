﻿using backend.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class AuditointiController : ControllerBase
	{
		private readonly ILogger<DbHuoltokirjaContext> _logger;
		private readonly DbHuoltokirjaContext _db;
		private readonly IConfiguration _conf;

		public AuditointiController(ILogger<DbHuoltokirjaContext> logger, DbHuoltokirjaContext db, IConfiguration conf)
		{
			_logger = logger;
			_db = db;
			_conf = conf;
		}


		[HttpGet("/auditointi/all")]
		public async Task<IEnumerable<Auditointi>> Get()
		{
			return await _db.Auditointis.OrderBy(i=>i.Idauditointi).ToListAsync();
		}

		[HttpGet("/auditointi/{id}")]
		public string Get(int id)
		{
			return "value";
		}

		[HttpPost("/auditointi")]
		public void Post([FromBody] string value)
		{
		}

		[HttpPut("/auditointi/{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		[HttpDelete("/auditointi/{id}")]
		public void Delete(int id)
		{
		}
	}
}