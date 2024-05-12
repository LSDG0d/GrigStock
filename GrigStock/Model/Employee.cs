using System;
using System.Collections.Generic;

namespace GrigStock.Model;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeFirstName { get; set; } = null!;

    public string EmployeeLastName { get; set; } = null!;

    public string? EmployeePatronymic { get; set; }

    public string EmployeeJobTitle { get; set; } = null!;

    public DateTime EmployeeBirthDay { get; set; }

    public string? EmployeeAddress { get; set; }

    public string? EmployeePhone { get; set; }

    public string? EmployeeMail { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
