﻿using HRD.Models;
using Microsoft.EntityFrameworkCore;

namespace HRD.Controllers
{
    static internal class Employees
    {
        static public int CreateEmployee(string lastName, string firstName, string secondName, int subdivisionId)
        {
            var employee = new Employee
            {
                LastName = lastName,
                FirstName = firstName,
                SecondName = secondName,
                SubdivisionId = subdivisionId
            };

            using var hrd = new HRDContext();
            hrd.Employees.Add(employee);
            hrd.SaveChanges();
            return employee.Id;
        }

        static public TreeNode[] GetEmployeesBySubdivisionOnPeriod(int subdivisionid, DateTime dtStart, DateTime dtEnd)
        {
            using var hrd = new HRDContext();
            var employees = hrd.Employees.Where(emp => emp.HireDate <= dtEnd && (emp.DismissalDate == null || emp.DismissalDate > dtStart))
                .Include(emp => emp.Transfers.Where(t => t.atDateTime >= dtStart && t.atDateTime <= dtEnd
                && (t.FromSubdivisionId == subdivisionid || t.ToSubdivisionId == subdivisionid)).Take(1))
                .ToList();

            var employeesBySubdivision = new List<TreeNode>();
            foreach (var employee in employees)
            {
                if (employee.SubdivisionId == subdivisionid)
                {
                    employeesBySubdivision.Add(new TreeNode(employee.FIO));
                    continue;
                }

                if (employee.Transfers.Count != 0)
                    employeesBySubdivision.Add(new TreeNode(employee.FIO));
            }

            return employeesBySubdivision.ToArray();
        }
    }
}
