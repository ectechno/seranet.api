﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Seranet.Api.Plugins.Contacts
{
    public class ContactsController: ApiController
    {
        public IEnumerable<Contact> Get()
        {
            string path = System.Environment.GetEnvironmentVariable("SERANET.API.PLUGINS.CONTACT.RESOURCEFILE");//("SERANET.API.PLUGINS.CONTACT.RESOURCEFILE");

            ResourcePlanReader reader = new ResourcePlanReader(path);
            return reader.ReadFile();

        }
    }
}