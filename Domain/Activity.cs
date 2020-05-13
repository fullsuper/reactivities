using System;

namespace Domain
{
    public class Activity
    {
        public Activity()
        {
        }

        public Activity(Guid id, string title, string description, string category, DateTime date, string city, string venue)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Category = category;
            this.Date = date;
            this.City = city;
            this.Venue = venue;

        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}