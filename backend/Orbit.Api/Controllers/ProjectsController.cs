
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orbit.Api.Data;
using Orbit.Api.Models;

namespace Orbit.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly OrbitDbContext _dbContext;

    public ProjectsController(OrbitDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<List<Project>>> GetAll()
    {
        var projects = await _dbContext.Projects
            .AsNoTracking()
            .OrderBy(project => project.Name)
            .ToListAsync();

        return Ok(projects);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Project>> GetById(Guid id)
    {
        var project = await _dbContext.Projects
            .AsNoTracking()
            .FirstOrDefaultAsync(project => project.Id == id);

        if (project is null)
        {
            return NotFound();
        }

        return Ok(project);
    }

    [HttpPost]
    public async Task<ActionResult<Project>> Create(
        CreateProjectRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
        {
            return BadRequest(new
            {
                error = "Project name is required."
            });
        }

        var project = new Project
        {
            Name = request.Name.Trim(),
            Description = request.Description?.Trim()
        };

        _dbContext.Projects.Add(project);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetById),
            new { id = project.Id },
            project);
    }
}
