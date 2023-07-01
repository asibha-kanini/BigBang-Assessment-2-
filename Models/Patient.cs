﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigBang_Assessment_2.Models
{
    public class Patient
    {
        [Key] 
        public int Patient_Id { get; set; }
        public string? Patient_Name { get; set; }
        public string? Disease { get; set; }
        public string? Disease_Description { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Patient_No { get; set; }
        public string? Password { get; set; }


        [ForeignKey("Doctor")]
        public int? Doctor_Id { get; set; }
        public Doctor? Doctors { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }

    }
}

