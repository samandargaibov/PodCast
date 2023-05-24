﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodCast.DAL;
using PodCast.Models;
using System.Diagnostics;

namespace PodCast.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var speakers = await _dbContext.Speakers.Include(x => x.SpeakerTopics).ThenInclude(x => x.Topic).ToListAsync();
            var latestEpisodes = await  _dbContext.Episodes.Include(x => x.Speaker).OrderByDescending(x => x.Id).Take(2).ToListAsync();
            var trendingEpisodes = await   _dbContext.Episodes.Include(x => x.Speaker).OrderByDescending(x => x.ListeningCount).Take(3).ToListAsync();
            var topics = await _dbContext.Topics.Take(4).ToListAsync();

            var model = new HomeViewModel
            {
                Speakers = speakers,
                LatesEpisodes = latestEpisodes,
                TrendingEpisodes = trendingEpisodes,
                Topics = topics
            };

            return View(model);
        }
    }
}