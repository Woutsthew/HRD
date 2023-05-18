using HRD.Models;
using Microsoft.EntityFrameworkCore;

namespace HRD.Controllers
{
    static internal class Subdivisions
    {
        static public dynamic[] GetSubdivisionsAsDymanic()
        {
            using var hrd = new HRDContext();
            return hrd.Subdivisions
                .Select(subdivision => new { Text = subdivision.Name, Value = subdivision.Id }).ToArray();
        }

        static public TreeNode[] GetTreeStructureByDateTime(DateTime dt)
        {
            using var hrd = new HRDContext();
            var subdivisions = hrd.Subdivisions.ToList();
            hrd.ChangeTracker.Clear();

            var employees = hrd.Employees.Where(emp => emp.HireDate <= dt && (emp.DismissalDate == null || emp.DismissalDate > dt))
                .Include(emp => emp.Transfers.OrderBy(t => t.atDateTime).Where(t => t.atDateTime > dt).Take(1))
                .ToList();

            foreach (var employee in employees)
            {
                var subdivisionId = employee.Transfers.Count != 0 ? employee.Transfers.First().FromSubdivisionId : employee.SubdivisionId;
                subdivisions.Find(s => s.Id == subdivisionId)!.Employees.Add(employee);
            }

            return CreateTreeStructure(subdivisions);
        }

        static private TreeNode[] CreateTreeStructure(List<Subdivision> subdivisions)
        {
            var rootsSubdivisions = new List<Subdivision>(subdivisions.Where(s => s.ParentId == null));
            var treeNodes = new List<TreeNode>(rootsSubdivisions.Count);

            foreach (Subdivision subdivision in rootsSubdivisions)
                treeNodes.Add(CreateNode(subdivision));

            return treeNodes.ToArray();
        }

        static private TreeNode CreateNode(Subdivision subdivision)
        {
            var node = new TreeNode(subdivision.Name);
            node.NodeFont = new Font("Arial", 10, FontStyle.Bold);

            var employees = subdivision.Employees.Select(e => new TreeNode(e.FIO)).ToArray();
            node.Nodes.AddRange(employees);

            foreach (Subdivision children in subdivision.Childrens)
                node.Nodes.Add(CreateNode(children));

            return node;
        }
    }
}
