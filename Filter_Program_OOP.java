import java.util.*;

class Container {
    String[] array;
    String startsWith;
    public Container(String[] inputArray, String inputString){
        array = inputArray;
        startsWith = inputString;
    }
}
class FilterArray {
    public ArrayList filterMethod (String[] inputArray, String inputString){
        ArrayList<String> filteredArray = new ArrayList<>();
        for(int i=0;i<inputArray.length;i++){
              if((inputArray[i]).startsWith(inputString)){
                  filteredArray.add(inputArray[i]);
              }
        }
        return filteredArray;
    }
}
class DisplayFilteredArray {
    public void displayInTerminal(ArrayList<String> list){
        for(int i=0;i<list.size();i++)
            System.out.println(list.get(i));
    }
}
class FilterStringArray {
    public static void main(String[] args) {
        String[] inputArray = { "ask","play","type","code","asia","app" };
        ArrayList<String> filteredArray = new ArrayList<>();
        
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the starting string to search: ");
        String inputString = sc.nextLine();
        
        Container containerObj = new Container(inputArray,inputString);
        FilterArray filterObj = new FilterArray();
        DisplayFilteredArray displayObj = new DisplayFilteredArray();
        
        filteredArray = filterObj.filterMethod(containerObj.array, inputString);
        displayObj.displayInTerminal(filteredArray);
    }
}
