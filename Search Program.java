import java.util.Scanner;

class StringStartsWith {
    public static void main(String[] args) {
        String[] array = { "ask","play","type","code" };
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter the starting string to search: ");
        String s = sc.nextLine();
        boolean ans = search(array,s);
        if(ans){
            System.out.println("Found");
        }
        else{
            System.out.println("Not Found");
        }
    }
    static boolean search(String[] array, String s){
        for(int i=0;i<array.length;i++){
            if(array[i].startsWith(s))
                return true;
        }
        return false;
    }
}
