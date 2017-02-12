using System;
using NormalAI;

namespace UserSpecs
{
    public  class user
    {
        public  int age {get;set;}
        public  DateTime birthdate {get;set;}
        public  string firstname {get;set;}
        public  string lastname {get;set;}
        public string password {get; set;}
        
        public user()
        {
            this.age = age;
            this.birthdate = birthdate;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        ~user()
        {
            ai.say("user deleted.");
        }
    }
}