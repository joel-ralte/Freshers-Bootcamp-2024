import java.util.*;
import java.util.function.Predicate;

class FilterStringArray {
    public static void main(String[] args) {
        // Variable declaration and input
        String[] inputArray = { "ask","play","type","code","asia","app" };
        ArrayList<String> filteredArray = new ArrayList<>();
        Scanner sc = new Scanner(System.in);
        
        System.out.print("Enter the starting string to search: ");
        String inputString = sc.nextLine();
        Predicate<String> startsWith = str -> str.startsWith(inputString);
        
        // Function calls
        filteredArray = filter(inputArray,startsWith);
        displayInTerminal(filteredArray);
    }
    static ArrayList filter(String[] inputArray, Predicate<String> startsWith){
        ArrayList<String> filteredArray = new ArrayList<>();
        for(int i=0;i<inputArray.length;i++){
              if(startsWith.test(inputArray[i])){
                  filteredArray.add(inputArray[i]);
              }
        }
        return filteredArray;
    }
    static void displayInTerminal(ArrayList<String> list){
        for(int i=0;i<list.size();i++)
            System.out.println(list.get(i));
    }
}
