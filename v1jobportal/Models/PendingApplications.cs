﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace v1jobportal.Models
{
    public class PendingApplications
    {
        //Sa=submittedApplications
        //Jd=Job details
        //Bd=Biodata
        //Ed=Education details
        //Eh=Employment History
        //Ca=Certifications and Awards
        //Ud=Upload Documents
        //Submitted jobs variables

        public int Id { get; set; }

        //specific job application details
        [Display(Name = "Job id", AutoGenerateFilter = false)]
        public int? Jd_JobId { get; set; }

        [Display(Name = "Employee Id", AutoGenerateFilter = false)]
        public int Emp_Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Application Deadline", AutoGenerateFilter = false)]
        public DateTime? Deadline { get; set; }
        //Applicant's biodata

        [Display(Name = "First Name", AutoGenerateFilter = false)]
        public string Bd_FirstName { get; set; }
        public string Bd_MiddleName { get; set; }

        [Display(Name = "Last Name", AutoGenerateFilter = false)]
        public string Bd_LastName { get; set; }

        public string Bd_Residence { get; set; }

        [StringLength(13, MinimumLength = 10)]
        [DataType(DataType.PhoneNumber)]
        public string Bd_PrimaryPhoneNumber { get; set; }
        public string Bd_AlternativePhoneNumber { get; set; }
        
        public string Bd_LanguagesSpoken { get; set; }
        public bool? Bd_WorkedWithIDRC { get; set; }

        //applicant's Education Details
        public string Ed_NameOfInstitution { get; set; }
        public string Ed_QualificationAttained { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Ed_DateQualificationWasAttained { get; set; }
        //applicant's Employment History
        public string Eh_EmployerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Eh_EmploymentStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Eh_EmploymentEndDate { get; set; }
        
        public string Eh_JobTitle { get; set; }
        public string Eh_SummaryOfDuties { get; set; }
        public string Eh_SummaryOfAchievments { get; set; }
        //applicant's Certifications
        public string Ca_CertificationName { get; set; }
        public string Ca_CertifyingInstitutionName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Ca_CertificationDate { get; set; }
        //Applicant's Uploaded Documents
        public string Ud_CertificationAwardName { get; set; }

        public string Ud_InstitutionName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Ud_DateOfCertification { get; set; }
    }
}
