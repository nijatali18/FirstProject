﻿using Layihe2023.Models;

namespace Layihe2023;

public class Department:IEquatable<Department>,IdIntarface
{
    public int DepartmentId { get; }
    public string Name { get; set; }
    public int EmployeeLimit { get; set; }
    public int CompanyId { get; set; }

    public int Id => throw new NotImplementedException();

    public override string ToString()
    {
        return $"DepartmentId:{DepartmentId}\nDepartmentName{Name}";
    }

    public bool Equals(Department? other)
    {
        throw new NotImplementedException();
    }

    static int count = 0;
    public Department()
    {
        count++;
        this.DepartmentId = count;
    }
}