import java.io.File;

public class file {
  public static void main(String[ ] args) {
    File x = new File("C:\\Users\\dung5\\OneDrive\\HOMEWORK\\NLHDH");

    System.out.println("File name: " + x.getName());
    System.out.println("File parent: " + x.getParent());
    System.out.println("File path: " + x.getPath());


    if(x.exists()) {
     System.out.println(x.getName() +  " exists!");
    }
    else {
     System.out.println("The file does not exist");
    }
  }
}