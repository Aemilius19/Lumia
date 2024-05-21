using Lumia_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumia_Application.Abstractions
{
    public interface ITeamService
    {
        List<TeamSlider> GetAll();
        void Create(TeamSlider teamSlider);
        TeamSlider Update(int id);
        void Update(TeamSlider teamSlider);
        void Delete(int id);
    }
}
