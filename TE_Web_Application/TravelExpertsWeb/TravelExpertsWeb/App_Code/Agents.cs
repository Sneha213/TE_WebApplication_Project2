using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelExpertsWeb.App_Code
{
    // bussiness class for Agents
    public class Agents
    {
        public int AgentId { get; set; }

        public  string AgtFirstName { get; set; }

        public string AgtMiddleInitial { get; set; }

        public string AgtLastName { get; set; }

        public string AgtBusPhone { get; set; }

        public string AgtEmail { get; set; }

        public string AgtPosition { get; set; }

        public int AgencyId { get; set; }

    }
}