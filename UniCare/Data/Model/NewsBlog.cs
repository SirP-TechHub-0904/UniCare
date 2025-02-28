﻿namespace UniCare.Data.Model
{
    public class NewsBlog
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public string? ShortDescription { get; set; }
        public DateTime Date { get; set; }
        public string? Image {  get; set; }
    }
}
