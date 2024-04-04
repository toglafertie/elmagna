// Define the directory path and the commit file name
string dirPath = "your_directory_path";
string commitFile = "your_commit_file.txt";

// Combine the directory path with the commit file name to create a full file path
// This method also takes care of different directory separators on different OS
string filePath = Path.Combine(dirPath, commitFile);

// Check if the directory exists before proceeding
if (Directory.Exists(dirPath))
{
    // Check if the file exists within the directory
    if (File.Exists(filePath))
    {
        // The file path is valid and the file exists
        Console.WriteLine($"File found: {filePath}");
        // You can add additional code here to work with the file
    }
    else
    {
        // The file does not exist
        Console.WriteLine("The commit file does not exist in the specified directory.");
    }
}
else
{
    // The directory does not exist
    Console.WriteLine("The specified directory path does not exist.");
}
