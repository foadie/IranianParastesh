using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IranianParastesh.Controllers.Api
{
    public class SongsController : ApiController
    {
        private ApplicationDbContext _context;

        public SongsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET: /api/songs
        [HttpGet]
        public IHttpActionResult GetSongs()
        {
            var songs = _context.Songs.ToList();

            return Ok(songs);
        }

        //GET: /api/songs/1
        [HttpGet]
        public IHttpActionResult GetSong(int id)
        {
            var song = _context.Songs.SingleOrDefault(s => s.Id == id);

            if (song == null)
                return BadRequest();

            return Ok(song);
        }
    }
}
