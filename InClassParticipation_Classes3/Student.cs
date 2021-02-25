﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InClassParticipation_Classes3
{
    public class Student
    {
        public string FirstName {get; set;}
        public string LastName  {get; set;}
        public string Major     {get; set;}
        public double GPA       {get; set;}
        public Address Address { get; set; }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Major = string.Empty;
            GPA = 0;
            Address = new Address();
        }

        public Student(string firstName, string lastName, string major, double gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Major = major;
            GPA = gpa;
        }

        public string CalculateDistinction()
        {
            string distinction;

            if (GPA > 3.79)
            {
                distinction = "Summa Cum Laude";
            }
            else if (GPA > 3.5)
            {
                distinction = "Magna Cum Laude";
            }
            else if (GPA > 3.3)
            {
                distinction = "Cum Laude";
            }
            else
            {
                distinction = "No Distinction";
            }

            return distinction;
        }
        public void SetAddress(int streetNumber, string streetName, string state, string city, int zipCode)
        {
            Address = new Address(streetNumber, streetName, state, city, zipCode);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Major}, {CalculateDistinction()}";
        }

    }
}
