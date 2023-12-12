using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample;

// Originator
internal class Article
{
    public string Title { get; set; }
    public string Content { get; set; }    
    public string Notes { get; set; }

    // Backup (utwórz migawkę)
    public ArticleMemento CreateMemento()
    {
        return new ArticleMemento(Title, Content);
    }

    // Restore (przywracamy wartości na podstawie migawki)
    public void SetMemento(ArticleMemento memento)
    {
        this.Title = memento.Title;
        this.Content = memento.Content;
    }

    public override string ToString() => $"{Title} {Content} {Notes}";
}

// Memento Pattern

// Snapshot (migawka)
class ArticleMemento
{
    public string Title { get; }
    public string Content { get; }    
    public DateTime SnapshotDate { get; }

    public ArticleMemento(string title, string content)
    {
        Title = title;
        Content = content;
        SnapshotDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{SnapshotDate} {Title} {Content}";
    }
}

// Abstract Caretaker (Abstrakcyjny Nadzorca)
interface IArticleCaretaker
{
    ArticleMemento GetState();
    void SetState(ArticleMemento state);
}


// Concrete Caretaker (Konkretny Nadzorca) z zastosowaniem stosu (Stack)
class StackArticleCaretaker : IArticleCaretaker
{
    private readonly Stack<ArticleMemento> _mementos = new Stack<ArticleMemento>();
    public ArticleMemento GetState() => _mementos.Pop();
    public void SetState(ArticleMemento state) => _mementos.Push(state);
}




