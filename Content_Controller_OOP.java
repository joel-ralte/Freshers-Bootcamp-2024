import java.util.*;

class ConsoleDigitalController {
    private String content;
    
    public void setContent (String msg) {
        content = msg;
    }
    public void display() {
        System.out.println(content);
    }
}
class StartsWithStrategy {
    private String startsWith;
    
    public void setStartsWith(String key) {
        startsWith = key;
    }
    public boolean invoke(String item) {
        return item.startsWith(startsWith) ? true : false;
    }
}
class StringListFilterController {
    String[] array;
    ArrayList<String> filteredList = new ArrayList<>();
    
    public StringListFilterController(String[] inputArray) {
        array = inputArray;
    }
    public ArrayList filter(StartsWithStrategy predicate) {
        for(int i=0; i<array.length; i++){
            if(predicate.invoke(array[i])){
                filteredList.add(array[i]);
            }
        }
        return filteredList;
    }
}
class DisplayFilteredArray {
    public void displayInTerminal(ArrayList<String> list){
        for(int i=0;i<list.size();i++)
            System.out.println(list.get(i));
    }
}
class Main {
    public static void main(String[] args) {
        String[] inputArray = { "ask","play","type","code","asia","app" };
        String startsWith = "as";
        ArrayList<String> filteredList = new ArrayList<>();
        
        StringListFilterController filterObj = new StringListFilterController(inputArray);
        StartsWithStrategy predicate = new StartsWithStrategy();
        DisplayFilteredArray displayObj = new DisplayFilteredArray();
        
        predicate.setStartsWith(startsWith);
        filteredList = filterObj.filter(predicate);
        displayObj.displayInTerminal(filteredList);
    }
}
