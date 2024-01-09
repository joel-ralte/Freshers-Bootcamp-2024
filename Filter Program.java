import java.util.*;
import java.util.function.Predicate;

class FilterStringArray {
    public static void main(String[] args) {
        String[] array = { "ask","play","type","code","asia","app" };
        ArrayList<String> filtered = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        
        System.out.print("Enter the starting string to search: ");
        String s = sc.nextLine();
        
        filtered = filter(array,s);
        display(filtered);
    }
    static ArrayList filter(String[] array, String s){
        Predicate<String> startsWith = str -> str.startsWith(s);
        ArrayList<String> filtered = new ArrayList<>();
        for(int i=0;i<array.length;i++){
              if(startsWith.test(array[i])){
                  filtered.add(array[i]);
              }
        }
        return filtered;
    }
    static void display(ArrayList<String> list){
        if(list.isEmpty()){
            System.out.println("No matches");
            return;
        }
        for(int i=0;i<list.size();i++)
            System.out.println(list.get(i));
    }
}
