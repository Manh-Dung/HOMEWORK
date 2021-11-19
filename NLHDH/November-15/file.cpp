#include <iostream>
#include <string>
#include <fstream>
#include <experimental/filesystem>

namespace fs = std::experimental::filesystem;

int main()
{
  fs::path path("C:\\Users\\dung5\\OneDrive\\HOMEWORK\\NLHDH");
  for (auto& p : fs::directory_iterator(path))
    std::cout << p << '\n';
  
}