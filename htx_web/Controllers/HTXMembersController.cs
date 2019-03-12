using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using htx_web.Models;

namespace htx_web.Controllers
{
    public class HTXMembersController : Controller
    {
        private readonly MyDbContext _context;

        public HTXMembersController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            return View(await _context.HTXMember.ToListAsync());
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create(HTXMember member)
        {
            if (ModelState.IsValid)
            {
                member.created = System.DateTime.Now;
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.HTXMember.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(HTXMember member)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var m = await _context.HTXMember.FindAsync(member.id);
                    m.name = member.name;
                    m.email = member.email;
                    m.phone = member.phone;
                    m.address = member.address;

                    _context.Update(m);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.id))
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
            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.HTXMember.FindAsync(id);
            _context.HTXMember.Remove(member);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.HTXMember.Any(e => e.id == id);
        }
    }
}
