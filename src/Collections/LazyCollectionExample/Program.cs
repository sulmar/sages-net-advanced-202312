
using LazyCollectionExample;

Console.WriteLine("Hello, Lazy Collection!");

DecisionTreeTest();

static void DecisionTreeTest()
{

    // Create a simple decision tree
    DecisionTree root = new DecisionTree(new Decision("Should I take a job offer?"))
    {
        Yes = new DecisionTree(new Decision("Is the salary acceptable?"))
        {
            Yes = new DecisionTree(new Decision("Accept the job")),
            No = new DecisionTree(new Decision("Decline the job"))
        },
        No = new DecisionTree(new Decision("Consider other offers"))
        {
            Yes = new DecisionTree(new Decision("Explore other opportunities")),
            No = new DecisionTree(new Decision("Wait for better offers"))
        }
    };

    BinaryTree<Decision> decisionTree = new BinaryTree<Decision>(root);

    foreach (var decision in decisionTree.TraverseInOrder())
    {
        Console.WriteLine(decision);
    }
}