using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Unit
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Unit> GetAll()
        {
            return _context.Units
                .ToList();
        }

        public void Add(Unit unit)
        {
            _context.Add(unit);
            _context.SaveChanges();
        }

        public void Update(Unit unit)
        {
            var existing = _context.Units.FirstOrDefault(u => u.Id == unit.Id);
            if (existing != null)
            {
                existing.UnitName = unit.UnitName;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var unit = _context.Units.FirstOrDefault(u => u.Id == id);
            if (unit != null)
            {
                _context.Remove(unit);
                _context.SaveChanges();
            }
        }
    }
}
