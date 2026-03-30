// IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

// foreach (var dir in listOfDirectories) {
//     Console.WriteLine(dir);
// }

// IEnumerable<string> files = Directory.EnumerateFiles("stores");

// foreach (var file in files)
// {
//     Console.WriteLine(file);
// }

// // Find all *.txt files in the stores folder and its subfolders
// IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

// foreach (var file in allFilesInAllFolders)
// {
//     Console.WriteLine(file);
// }

// using System.IO;
// using System.Collections.Generic;

// var salesFiles = FindFiles("stores");

// foreach (var file in salesFiles)
// {
//     Console.WriteLine(file);
// }

// IEnumerable<string> FindFiles(string folderName)
// {
//     List<string> salesFiles = new List<string>();

//     var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

//     foreach (var file in foundFiles)
//     {
//         // The file name will contain the full path, so only check the end of it
//         if (file.EndsWith("sales.json"))
//         {
//             salesFiles.Add(file);
//         }
//     }

//     return salesFiles;
// }

string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
Console.WriteLine(Path.Combine("stores","201")); 
Console.WriteLine(Path.GetExtension("sales.json"));
string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";
FileInfo info = new FileInfo(fileName);
Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more