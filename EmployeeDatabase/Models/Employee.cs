﻿using System;
using System.ComponentModel.DataAnnotations;
using EmployeeBusinessLogic.Enums;

namespace EmployeeDatabase.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required] public string Fio { get; set; }

        public DateTime? VacationStart { get; set; }

        /// <summary>
        /// должность сотрудника
        /// </summary>
        [Required] public Position Position { get; set; }
    }
}