using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Models;

namespace SacramentPlanner.Controllers
{
    public class MeetingSpeakersController : Controller
    {
        private readonly SacramentPlannerContext _context;

        public MeetingSpeakersController(SacramentPlannerContext context)
        {
            _context = context;
        }

        // GET: MeetingSpeakers
        public async Task<IActionResult> Index()
        {
            var sacramentPlannerContext = _context.MeetingSpeaker.Include(m => m.meeting).Include(m => m.speaker);
            return View(await sacramentPlannerContext.ToListAsync());
        }

        // GET: MeetingSpeakers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingSpeaker = await _context.MeetingSpeaker
                .Include(m => m.meeting)
                .Include(m => m.speaker)
                .FirstOrDefaultAsync(m => m.MeetingSpeakerId == id);
            if (meetingSpeaker == null)
            {
                return NotFound();
            }

            return View(meetingSpeaker);
        }

        // GET: MeetingSpeakers/Create
        public IActionResult Create()
        {
            ViewData["MeetingId"] = new SelectList(_context.Meeting, "MeetingId", "Date");
            ViewData["SpeakerId"] = new SelectList(_context.Speaker, "SpeakerId", "SpeakerName");
            return View();
        }

        // POST: MeetingSpeakers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MeetingSpeakerId,MeetingId,SpeakerId")] MeetingSpeaker meetingSpeaker)
        {
            if (ModelState.IsValid)
            {
                _context.Add(meetingSpeaker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MeetingId"] = new SelectList(_context.Meeting, "MeetingId", "Date", meetingSpeaker.MeetingId);
            ViewData["SpeakerId"] = new SelectList(_context.Speaker, "SpeakerId", "SpeakerName", meetingSpeaker.SpeakerId);
            return View(meetingSpeaker);
        }

        // GET: MeetingSpeakers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingSpeaker = await _context.MeetingSpeaker.FindAsync(id);
            if (meetingSpeaker == null)
            {
                return NotFound();
            }
            ViewData["MeetingId"] = new SelectList(_context.Meeting, "MeetingId", "Date", meetingSpeaker.MeetingId);
            ViewData["SpeakerId"] = new SelectList(_context.Speaker, "SpeakerId", "SpeakerName", meetingSpeaker.SpeakerId);
            return View(meetingSpeaker);
        }

        // POST: MeetingSpeakers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeetingSpeakerId,MeetingId,SpeakerId")] MeetingSpeaker meetingSpeaker)
        {
            if (id != meetingSpeaker.MeetingSpeakerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meetingSpeaker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeetingSpeakerExists(meetingSpeaker.MeetingSpeakerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MeetingId"] = new SelectList(_context.Meeting, "MeetingId", "Date", meetingSpeaker.MeetingId);
            ViewData["SpeakerId"] = new SelectList(_context.Speaker, "SpeakerId", "SpeakerName", meetingSpeaker.SpeakerId);
            return View(meetingSpeaker);
        }

        // GET: MeetingSpeakers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meetingSpeaker = await _context.MeetingSpeaker
                .Include(m => m.meeting)
                .Include(m => m.speaker)
                .FirstOrDefaultAsync(m => m.MeetingSpeakerId == id);
            if (meetingSpeaker == null)
            {
                return NotFound();
            }

            return View(meetingSpeaker);
        }

        // POST: MeetingSpeakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meetingSpeaker = await _context.MeetingSpeaker.FindAsync(id);
            _context.MeetingSpeaker.Remove(meetingSpeaker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeetingSpeakerExists(int id)
        {
            return _context.MeetingSpeaker.Any(e => e.MeetingSpeakerId == id);
        }
    }
}
