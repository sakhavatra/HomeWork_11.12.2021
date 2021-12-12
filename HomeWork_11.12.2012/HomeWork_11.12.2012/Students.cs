using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11._12._2012
{
    class Students
    {
        public string Fullname;
        public string Course;
        public string Subject;
        public string University;
        public string Email;
        public double PhoneNumber;
        public Students
            (
            string fullname, 
            string course, 
            string subject, 
            string university, 
            string email, 
            double phoneNumber
            )
        {
            Fullname = fullname;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public string InfoMetod()
        {
         return  
                $"Fullname:     {Fullname}\n"+ 
                $"Course:       {Course}\n" +
                $"Subject:      {Subject}\n" +
                $"University:   {University}\n" +
                $"Email:        {Email}\n" +
                $"PhoneNumber:  {PhoneNumber}\n"
                ;
        }
    }
}
