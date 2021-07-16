
using System;
using System.Linq;
using AutoMapper;
using csharp_apiRest.Data;
using csharp_apiRest.Data.DTOS;
using csharp_apiRest.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_apiRest.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MovieController : ControllerBase
  {
    private MovieContext _context;
    private IMapper _mapper;
    public MovieController(MovieContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpPost]
    public IActionResult Create(CreateMovieDTO movieDTO)
    {
      var movie = _mapper.Map<Movie>(movieDTO);
      _context.Movies.Add(movie);
      _context.SaveChanges();
      return CreatedAtAction(nameof(Get), new { id = movie.Id }, movie);
    }

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_context.Movies.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
      var movie = _context.Movies.FirstOrDefault(m => m.Id == id);

      if (movie == null)
      {
        return NotFound();
      }

      var movieDTO = _mapper.Map<ReadMovieDTO>(movie);
      movieDTO.Consultation = DateTime.Now;
      return Ok(movieDTO);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, UpdateMovieDTO movieDTO)
    {
      var movieToUpdate = _context.Movies.FirstOrDefault(m => m.Id == id);
      if (movieToUpdate == null)
      {
        return NotFound();
      }
      _mapper.Map(movieDTO, movieToUpdate);
      _context.SaveChanges();
      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      Movie movieToDelete = _context.Movies.FirstOrDefault(m => m.Id == id);
      if (movieToDelete == null)
      {
        return NotFound();
      }
      _context.Movies.Remove(movieToDelete);
      _context.SaveChanges();
      return Ok();
    }
  }
}
