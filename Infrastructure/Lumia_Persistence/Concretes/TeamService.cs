using Lumia_Application.Abstractions;
using Lumia_Domain;
using Lumia_Persistence.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumia_Persistence.Concretes
{
    public class TeamService : ITeamService
    {
        AppDbContext _context;
        public TeamService(AppDbContext context)
            {
                _context = context;
            }

        public void Create(TeamSlider teamSlider)
        {
            _context.TeamSlider.Add(teamSlider);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           var delete=_context.TeamSlider.FirstOrDefault(x => x.Id == id);
            _context.TeamSlider.Remove(delete);
            _context.SaveChanges();
        }

        public List<TeamSlider> GetAll()
        {
            return _context.TeamSlider.ToList();
        }

        public TeamSlider Update(int id)
        {
            return _context.TeamSlider.FirstOrDefault(x=>x.Id==id);
        }

        public void Update(TeamSlider teamSlider)
        {
           var old=_context.TeamSlider.FirstOrDefault(x=>x.Id==teamSlider.Id);
            old.FullName= teamSlider.FullName;
            old.Description= teamSlider.Description;
            old.Title= teamSlider.Title;
            _context.SaveChanges();
        }
    }
}
