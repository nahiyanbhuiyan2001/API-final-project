using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyAPI.Models;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : ControllerBase
    {
        private readonly MyAPIDBContext _context;

        public TeamController(MyAPIDBContext context)
        {
            _context = context;
        }

        // GET: api/team
        [HttpGet]
        public async Task<ActionResult<SoccerResult<STeam>>> GetTeams()
        {
            var teams = await _context.Teams.ToListAsync();

            if (teams == null || teams.Count == 0)
            {
                return NotFound("No teams found.");
            }

            return Ok(new SoccerResult<STeam>
            {
                StatusCode = 200,
                StatusDescription = "Successful Fetch",
                Response = teams,
            });
        }

        // GET: api/team/5
        [HttpGet("{teamNo}")]
        public async Task<ActionResult<STeam>> GetTeam(int teamNo)
        {
            var team = await _context.Teams.FindAsync(teamNo);

            if (team == null)
            {
                return NotFound("Team not found.");
            }

            return Ok(team);


        }

        // POST: api/team
        [HttpPost]
        public async Task<ActionResult<SoccerResult<STeam>>> CreateTeam(STeam team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTeam), new { teamNo = team.TeamNum }, team);
        }

        // PUT: api/team/{teamNo}
        [HttpPut("{teamNo}")]
        public async Task<IActionResult> UpdateTeam(int teamNo, STeam team)
        {
            if (teamNo != team.TeamNum)
            {
                return BadRequest("The team number in the request body does not match the one in the URL.");
            }

            _context.Entry(team).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return Ok("Team info updated.");
        }

     
    }
}