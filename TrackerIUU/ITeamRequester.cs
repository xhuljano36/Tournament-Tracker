using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerIUU
{
    public interface ITeamRequester
    {
        void TeamComplete(TeamModel t);
    }
}
