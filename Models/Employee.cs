using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HRApi.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid Uuid { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string Recruiter { get; set; }
        public string Manager { get; set; }
        public double Salary { get; set; }
        public int ZipCode { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public DateOnly DateOfJoining { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactRelationship { get; set; }
        public string EmergencyContactAddress { get; set; }
        public string EmergencyContactCity { get; set; }
        public string EmergencyContactState { get; set; }
        public string EmergencyContactZipCode { get; set; }
        public string EmergencyContactCountry { get; set; }
        public string EmergencyContactNotes { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

    }
    public enum EmploymentType
    {
        // [Display(Name = "FullTime")]
        FullTime,
        PartTime,
        Contract,
        Intern,
        Freelance
    }
    public enum Department
    {
        HR,
        IT,
        Sales,
        Marketing,
        Finance,
        Operations,
        CustomerService
    }
    public enum Position
    {
        Manager,
        Senior,
        Junior,
        Intern,
        Executive
    }
    public enum Country
    {
        USA,
        Canada,
        UK,
        Australia,
        India,
        Germany,
        France,
        Spain,
        Italy,
        Netherlands
    }
    public enum State
    {
        California,
        Texas,
        NewYork,
        Florida,
        Illinois,
        Pennsylvania,
        Ohio,
        Georgia,
        NorthCarolina,
        Michigan
    }
    public enum City
    {
        LosAngeles,
        NewYorkCity,
        Chicago,
        Houston,
        Phoenix,
        Philadelphia,
        SanAntonio,
        SanDiego,
        Dallas,
        SanJose
    }
}
