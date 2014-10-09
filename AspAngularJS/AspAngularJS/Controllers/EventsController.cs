namespace AspAngularJS.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Web.Http;

    using Newtonsoft.Json;

    public class EventsController : ApiController
    {
        public Event[] Get()
        {
            return this.GetAllData().Events;
        }

        public Event GetById(int id)
        {
            return GetData(id);
        }


        private EventList GetAllData()
        {
            var path = GetBasePath();

            path = Path.Combine(path,"data\\event");

            var files = new List<string>()
                            {
                                Path.Combine(path, "1.json"),
                                Path.Combine(path, "2.json"),
                                Path.Combine(path, "3.json"),
                                Path.Combine(path, "4.json")
                            };

            var eventList = new List<Event>();
            foreach (var file in files)
            {
                var eventItem = this.GetData(file);
                if (eventItem != null)
                {
                    eventList.Add(eventItem);
                }
            }

            return new EventList { Events = eventList.ToArray() };
        }

        private static string GetBasePath()
        {
            var codebase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codebase);
            var path = Path.GetDirectoryName(Uri.UnescapeDataString(uri.Path));
            return path;
        }

        private Event GetData(string path)
        {
            var str = File.ReadAllText(path);
            var eventItem = JsonConvert.DeserializeObject<Event>(str);
            return eventItem;
        }

        private Event GetData(int i)
        {
            var path = Path.Combine(GetBasePath() , "data\\event", i  + ".json");
            return GetData(path);
        }
    }




    public class EventList
    { 
        public Event[] Events { get; set; }
    }

    public class Event
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Date { get; set; } 
        public string Time { get; set; }

        public Location Location { get; set; }
        public string ImageUrl { get; set; } 
        public Session[] Sessions { get; set; }
    }


    public class Session
    { 
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public string Level { get; set; }
        public string Abstract { get; set; }
        public int UpVoteCount { get; set; }
        public int Duration { get; set; }
    }

    public class Location
    { 
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
    }
}
