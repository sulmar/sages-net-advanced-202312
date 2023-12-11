using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyCollectionExample;

internal class DecisionTree : TreeNode<Decision>
{
    public DecisionTree(Decision decision) : base(decision)
    {
    }
}

class Decision
{
    public string Description { get; }

    public Decision(string description)
    {
        Description = description;
    }

    public override string ToString()
    {
        return $"Decision: {Description}";
    }
}

class TreeNode<T>
{
    public T Value { get; }
    public TreeNode<T> Yes { get; set; }
    public TreeNode<T> No { get; set; }

    public TreeNode(T value)
    {
        Value = value;
    }
}

class BinaryTree<T>
{
    private readonly TreeNode<T> root;

    public BinaryTree(TreeNode<T> root)
    {
        this.root = root;
    }

    public IEnumerable<T> TraverseInOrder()
    {
        return TraverseInOrder(root);
    }

    private IEnumerable<T> TraverseInOrder(TreeNode<T> node)
    {
        throw new NotImplementedException();
    }
}