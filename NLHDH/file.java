import java.io.File;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.List;
import java.util.stream.Collectors;

public class file {
    public static void main(String[] args) {
        String fol = "C:\\Users\\dung5\\OneDrive\\HOMEWORK\\NLHDH\\November-15";

        try {
            List<File> files = Files.list(Paths.get(fol)).filter(Files::isRegularFile).map(Path::toFile)
                    .collect(Collectors.toList());
                    
            files.forEach(System.out::println);
        } catch (IOException e) {
            // Error while reading the directory
        }
    }
}