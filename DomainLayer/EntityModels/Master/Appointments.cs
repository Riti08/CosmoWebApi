﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Appointments
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(70)]
        public string AppointmentType { get; set; }
        [MaxLength(50)]
        public string Diagnosis { get; set; }
        [MaxLength(50)]
        public string AppointmentStatus { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public DateTime ModifiedDate { get; set; }

        [MaxLength(50)]
        public string ModifiedReason { get; set; }
        public Guid DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedReason { get; set; }
        [ForeignKey("PatientDetails")]
        public Guid PatientId { get; set; }
        //public PatientDetails PatientDetails { get; set; }
        [ForeignKey("EmployeeDetails")]
        public Guid PhysicianId { get; set; }
        //public EmployeeDetails PhysicianEmployee { get; set; }
        [ForeignKey("EmployeeDetails")]
        public Guid NurseId { get; set; }
        //public EmployeeDetails NurseEmployee { get; set; }

        [MaxLength(100)]
        public string bookslot { get; set; }

        [MaxLength(100)]
        public string Mode { get; set; }




        [MaxLength(700)]
        public string PatientMeetingLink { get; set; }




        [MaxLength(int.MaxValue)]
        public string PhysicianMeetingLink { get; set; }
        [MaxLength(50)]
        public string QueueStatus { get; set; }


    }
}
