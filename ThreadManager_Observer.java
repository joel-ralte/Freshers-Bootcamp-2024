import java.util.*;

interface Subject {
    public void subscribe(Observer o);
    public void unsubscribe(Observer o);
    private void notifyObservers() {};
}
interface Observer {
    public void update(String state);
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
    }
    public void start() {
        state = "Running";
    }
    public void abort() {
        state = "Aborted";
    }
    public void sleep() {
        state = "Sleeping";
    }
    public void waitThread() {
        state = "Waiting";
    }
    public void suspend() {
        state = "Suspended";
    }
    public void stop() {
        state = "Stopped";
    }
    public void subscribe(Observer o) {
        observerList.add(o);
    }
    public void unsubscribe(Observer o) {
        observerList.remove(observerList.indexOf(o));
    }
    private void notifyObservers() {
        for (Iterator<Observer> it =
              observerList.iterator(); it.hasNext();)
        {
            Observer o = it.next();
            o.update(state);
        }
    }
}
class User implements Observer {
    private String state;
    
    public void update(String state) {
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
        
        thread.subscribe(user1);
        thread.notifyObservers();
        user1.display();
        thread.unsubscribe(user1);
    }
}
