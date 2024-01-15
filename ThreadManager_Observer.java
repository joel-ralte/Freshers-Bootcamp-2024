import java.util.*;

interface Subject {
    public void subscribeThread(Observer o);
    public void unsubscribeThread(Observer o);
    private void notifyThreadObservers() {};
}
class Thread implements Subject{
    int id;
    String state;
    String priority;
    String culture;
    ArrayList<Observer> observerList;
    
    public Thread() {
        state = "Created";
        observerList = new ArrayList<>();
        notifyThreadObservers();
    }
    public void start() {
        state = "Running";
        notifyThreadObservers();
    }
    public void abort() {
        state = "Aborted";
        notifyThreadObservers();
    }
    public void sleep() {
        state = "Sleeping";
        notifyThreadObservers();
    }
    public void waitThread() {
        state = "Waiting";
        notifyThreadObservers();
    }
    public void suspend() {
        state = "Suspended";
        notifyThreadObservers();
    }
    public void stop() {
        state = "Stopped";
        notifyThreadObservers();
    }
    public void subscribeThread(Observer o) {
        observerList.add(o);
    }
    public void unsubscribeThread(Observer o) {
        observerList.remove(observerList.indexOf(o));
    }
    private void notifyThreadObservers() {
        for (Iterator<Observer> it =
              observerList.iterator(); it.hasNext();)
        {
            Observer o = it.next();
            o.updateState(state);
        }
    }
}
interface Observer {
    public void updateState(String state);
}
class User implements Observer {
    private String state;
    
    public void updateState(String state) {
        this.state = state;
    }
    public void display() {
        System.out.println("State of current thread: "+state);
    }
}
class ThreadManager {
    public static void main(String[] args) {
        User user1 = new User();
        Thread thread = new Thread();
        
        thread.subscribeThread(user1);
        
        thread.start();
        user1.display();
        thread.stop();
        user1.display();
        thread.abort();
        user1.display();
        
        thread.unsubscribeThread(user1);
    }
}
