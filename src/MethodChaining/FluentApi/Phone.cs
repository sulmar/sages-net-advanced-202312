using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FluentApi.FluentPhone;

namespace FluentApi;

public class Phone
{
    public void Call(string from, string to, string subject)
    {
        Console.WriteLine($"Calling from {from} to {to} with subject {subject}");
    }

    public void Call(string from, string to)
    {
        Console.WriteLine($"Calling from {from} to {to}");
    }

    public void Call(string from, IEnumerable<string> tos, string subject)
    {
        foreach (var to in tos)
        {
            Call(from, to, subject);
        }
    }
}

public interface IFrom
{
    ITo From(string from);
}

public interface ITo
{
    IToOrSubjectOrCall To(string to);
    IToOrSubjectOrCall To(params string[] recipients);
}

public interface ISubject
{
    ICall WithSubject(string subject);
}

public interface ICall 
{
    void Call();
}

public class FluentPhone : IFrom, ITo, ISubject, ICall, ISubjectOrCall, IToOrSubjectOrCall
{
    private string from;
    private ICollection<string> recipients = new List<string>();
    private string subject;

    private bool highPriority = false;

    protected FluentPhone()
    {

    }

    public FluentPhone HighPrority
    {
        get
        {
            return this;
        }
        set
        {
            highPriority = true;
        }
    }

    public static IFrom Hangup()
    {
        return new FluentPhone();
    }

    public ITo From(string from)
    {
        this.from = from;

        return this;
    }

    public interface ISubjectOrCall : ISubject, ICall
    {

    }

    public interface IToOrSubjectOrCall : ITo, ISubjectOrCall
    {

    }

    public IToOrSubjectOrCall To(string to)
    {
        this.recipients.Add(to);

        return this;
    }

    public ICall WithSubject(string subject)
    {
        if (!string.IsNullOrEmpty(subject))
            throw new ArgumentException("Subject może być ustawiony tylko raz");

        this.subject = subject;

        return this;
    }

    public void Call()
    {
        foreach (var to in recipients)
        {
            Call(to);
        }
    }

    private void Call(string to)
    {
        if (string.IsNullOrEmpty(subject))
            Console.WriteLine($"Calling from {from} to {to}");
        else
            Console.WriteLine($"Calling from {from} to {to} with subject {subject}");

    }

    public IToOrSubjectOrCall To(params string[] recipients)
    {
        foreach (var recipient in recipients)
        {
            To(recipient);
        }

        return this;
    }
}