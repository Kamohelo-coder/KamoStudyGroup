using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KamoStudyGroup.Models
{
    public class StudentDetails   //Create a class 
    {
        [DisplayName ("STUDENT NUMBER")]  //Display the name of your attributes on the table as STUDENT NUMBER, NAME, SURNAME, EMAIL ADDRESS
        public string StudentNo { get; set; }  //Attributes added to the student table
        [DisplayName ("NAME")]
        public string StudentName { get; set;}
        [DisplayName ("SURNAME")]
        public string StudentSurname { get; set;}
        [DisplayName ("EMAIL ADDRESS")]
        public string StudentEmail { get; set;}

    }
}