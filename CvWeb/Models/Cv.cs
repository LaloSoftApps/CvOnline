using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvWeb.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Location
    {
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string countryCode { get; set; }
        public string region { get; set; }
        public string map { get; set; }
    }

    public class Profile
    {
        public string network { get; set; }
        public string username { get; set; }
        public string url { get; set; }
    }

    public class Basics
    {
        public string name { get; set; }
        public string label { get; set; }
        public string birthdate { get; set; }
        public string picture { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public string summary { get; set; }
        public Location location { get; set; }
        public List<Profile> profiles { get; set; }
    }

    public class Education
    {
        public string institution { get; set; }
        public string city { get; set; }
        public string degree { get; set; }
        public string studyType { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string CertificateUrl { get; set; }
    }

    public class Cours
    {
        public string institution { get; set; }
        public string course { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string CertificateUrl { get; set; }
    }

    public class OtherCourses
    {
        public string description { get; set; }
    }

    public class Language
    {
        public string language { get; set; }
        public string fluency { get; set; }
    }

    public class Work
    {
        public string institution { get; set; }
        public string position { get; set; }
        public List<string> Tasks { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string reference { get; set; }
    }

    public class Cv
    {
        public Basics basics { get; set; }
        public List<Education> education { get; set; }
        public List<Cours> courses { get; set; }
        public List<OtherCourses> other_courses { get; set; }
        public List<Language> languages { get; set; }
        public List<Work> work { get; set; }
        public List<string> skills { get; set; }
        public List<string> interests { get; set; }
    }


}
