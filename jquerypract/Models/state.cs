using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jquerypract.Models
{
    public class state
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
    public class city
    {
        [Key]
        public int cityid { get; set; }
        public int id { get; set; }
        [ForeignKey("id")]
        public state state { get; set; }
        public string name { get; set; }
    }

    public class login
    {
        [Key]
        public int id { get; set; }
        public string mailid { get; set; }
        public string password { get; set; }
    }

    public class SignUp
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string dob { get; set; }
        public string state { get; set; }
        public string gender { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmpass { get; set; }
        public string address { get; set; }
    }

  



}
