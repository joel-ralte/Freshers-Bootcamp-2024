using System;
using System.Collections.Generic;

interface ISubject
{
    void SubscribeThread(IObserver o);
    void UnsubscribeThread(IObserver o);
    private void NotifyThreadObservers() { }
}

class Thread : ISubject
{
    private int id;
    private string state;
    private string priority;
    private string culture;
    private List<IObserver> observerList;

    public Thread()
    {
        state = "Created";
        observerList = new List<IObserver>();
        NotifyThreadObservers();
    }

    public void Start()
    {
        state = "Running";
        NotifyThreadObservers();
    }

    public void Abort()
    {
        state = "Aborted";
        NotifyThreadObservers();
    }

    public void Sleep()
    {
        state = "Sleeping";
        NotifyThreadObservers();
    }

    public void WaitThread()
    {
        state = "Waiting";
        NotifyThreadObservers();
    }

    public void Suspend()
    {
        state = "Suspended";
        NotifyThreadObservers();
    }

    public void Stop()
    {
        state = "Stopped";
        NotifyThreadObservers();
    }

    public void SubscribeThread(IObserver o)
    {
        observerList.Add(o);
    }

    public void UnsubscribeThread(IObserver o)
    {
        observerList.Remove(o);
    }

    private void NotifyThreadObservers()
    {
        foreach (var o in observerList)
        {
            o.UpdateState(state);
        }
    }
}

interface IObserver
{
    void UpdateState(string state);
}

class User : IObserver
{
    private string state;

    public void UpdateState(string state)
    {
        this.state = state;
    }

    public void Display()
    {
        Console.WriteLine("State of current thread: " + state);
    }
}

class ThreadManager
{
    static void Main()
    {
        User user1 = new User();
        Thread thread = new Thread();

        thread.SubscribeThread(user1);

        thread.Start();
        user1.Display();
        thread.Stop();
        user1.Display();
        thread.Abort();
        user1.Display();

        thread.UnsubscribeThread(user1);
    }
}
