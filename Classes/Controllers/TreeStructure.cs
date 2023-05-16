using HRD.Classes.Models;

namespace HRD.Classes.Controllers
{
    static internal class TreeStructure
    {
        static public TreeNode[] CreateTreeStructure(List<Subdivision> subdivisions)
        {
            var rootsSubdivisions = new List<Subdivision>(subdivisions.Where(s => s.Parent == null));
            var treeNodes = new List<TreeNode>(rootsSubdivisions.Count);

            foreach (Subdivision subdivision in rootsSubdivisions)
                treeNodes.Add(CreateNode(subdivision));

            return treeNodes.ToArray();
        }

        static private TreeNode CreateNode(Subdivision subdivision)
        {
            var node = new TreeNode(subdivision.Name);
            node.NodeFont = new Font("Arial", 10, FontStyle.Bold);

            var emplyees = subdivision.Employees.Select(e => new TreeNode(e.FIO)).ToArray();
            node.Nodes.AddRange(emplyees);

            foreach (Subdivision children in subdivision.Children)
                node.Nodes.Add(CreateNode(children));

            return node;
        }
    }
}
