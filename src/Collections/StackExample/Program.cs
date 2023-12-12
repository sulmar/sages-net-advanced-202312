using StackExample;

Console.WriteLine("Hello, Stack!");

IArticleCaretaker articleCaretaker = new StackArticleCaretaker();

Article article = new Article();
article.Content = "a";
articleCaretaker.SetState(article.CreateMemento());

article.Content = "b";
articleCaretaker.SetState(article.CreateMemento());

article.Content = "c";

// TODO: undo
article.SetMemento(articleCaretaker.GetState()); // b
article.SetMemento(articleCaretaker.GetState()); // a
article.SetMemento(articleCaretaker.GetState());





DepotTest();

static void DepotTest()
{
    Depot depot = new Depot();

    depot.AddItem("Item1", "Place1");
    depot.AddItem("Item2", "Place2");
    depot.AddItem("Item3", "Place1");
    depot.AddItem("Item4", "Place1"); 
    depot.AddItem("Item5", "Place2");
    
    depot.DisplayDepotContents();

    depot.SendItem("Place1");
    depot.SendItem("Place1");
    depot.SendItem("Place1");

    depot.DisplayDepotContents();
}


static void ArticleTest()
{
    var article = new Article { Title = "Lorem ipsum" };

    article.Content = "a";
    article.Content = "b";
    article.Content = "c";

    // TODO: Undo
}