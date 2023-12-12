using LazyCollectionExample;
using System.Data;

Console.WriteLine("Hello, Lazy Collection!");

//GenerateTemperaturesTest();

//GenerateNumbersTest();

//DataTableToEnumerationTest();

//YieldTest();

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

static void YieldTest()
{
    var weekDays = DateHelper.GetWeekDays();

    foreach (var day in weekDays)
    {
        Console.WriteLine(day);

        if (day == "Sr")
            break;
    }
}

static void DataTableToEnumerationTest()
{
    DataTable dataTable = new();
    dataTable.Columns.Add(new DataColumn("FirstName"));
    dataTable.Columns.Add(new DataColumn("LastName"));

    var newRow = dataTable.NewRow();
    newRow[0] = "John";
    newRow[1] = "Smith";
    dataTable.Rows.Add(newRow);

    newRow = dataTable.NewRow();
    newRow[0] = "Kate";
    newRow[1] = "Smith";
    dataTable.Rows.Add(newRow);

    newRow = dataTable.NewRow();
    newRow[0] = "Bob";
    newRow[1] = "Smith";
    dataTable.Rows.Add(newRow);

    var rows = DateHelper.AsEnumerable(dataTable);

    foreach (var row in rows)
    {
        Console.WriteLine(row);
    }
}

static void GenerateNumbersTest()
{
    var numbers = DateHelper.Generate(10, 20);


    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
}

static void GenerateTemperaturesTest()
{
    var temperatures = DateHelper.GetTemperatures();

    foreach (var temperature in temperatures)
    {
        Console.WriteLine(temperature);

        Thread.Sleep(1000);
    }
}