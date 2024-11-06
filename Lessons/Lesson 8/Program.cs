//-----------------------------------------------------------------
//    <copyright file="Lesson.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>30-10-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using System.Text;
using System.Text.Json;

namespace Lesson_8
{
    /// <summary>
    /// Summary description for Lesson.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
            #region Files

            #region Checking if a File Exists create

            string filePath = "example.txt";
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            #endregion

            #region 1. Writing Text to a File

            // Write a single line of text
            File.WriteAllText(filePath, "Hello, World!");

            // Write multiple lines
            string[] lines1 = { "Line 1", "Line 2", "Line 3" };
            File.WriteAllLines(filePath, lines1);

            #endregion

            #region 2. Reading Text from a File

            // Read all text
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // Read all lines
            string[] lines2 = File.ReadAllLines(filePath);
            foreach (string line in lines2)
            {
                Console.WriteLine(line);
            }

            #endregion

            #region 3. Appending Text to a File

            // Append text to the file
            File.AppendAllText(filePath, "\nAppended Line");

            Console.WriteLine(File.ReadAllText(filePath));

            #endregion

            #region 4. Checking if a Diretory Exists

            if (Directory.Exists(filePath))
            {
                Console.WriteLine("Directory Exists");
            }

            #endregion

            #region 5. Copying a File

            string sourceFilePath = "example.txt";
            string destinationFilePath = "example_copy.txt";

            if (File.Exists(sourceFilePath))
            {
                File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
                Console.WriteLine("File copied.");
            }

            #endregion

            #region 6. Moving a File

            string sourceMovingFilePath = "moving_example.txt";
            
            if (!File.Exists(sourceMovingFilePath))
            {
                File.Create(sourceMovingFilePath).Close();
            }
            
            if (!Directory.Exists("new_location"))
            {
                Directory.CreateDirectory("new_location");
            }

            string destinationNewLocationFilePath = "new_location/moving_example.txt";

            if (File.Exists(sourceMovingFilePath) && !File.Exists(destinationNewLocationFilePath))
            {
                File.Move(sourceMovingFilePath, destinationNewLocationFilePath);
                Console.WriteLine("File moved.");
            }

            #endregion

            #region 7. Deleting a File

            string fileDeletePath = "exampleToDelete.txt";
            // always check first if file exist
            if (!File.Exists(fileDeletePath))
            {
                File.Create(fileDeletePath).Close();
            }

            if (File.Exists(fileDeletePath))
            {
                File.Delete(fileDeletePath);
                Console.WriteLine("File deleted.");
            }

            #endregion

            #region 8. Working with FileStream (for reading and writing bytes)

            // Stream is the base class for file and data stream handling in C#.
            // FileStream, MemoryStream, NetworkStream, and other stream types
            // inherit from Stream. When you work with a FileStream directly,
            // each read and write operation interacts with the file directly
            // on disk, meaning each read or write goes through the operating
            // system to the disk.
            //
            //     - Direct Disk Access: Each call to Read or Write in FileStream
            //     results in a system-level I/O operation.
            //     - Less Efficient for Small Operations: If you’re reading or
            //     writing small amounts of data frequently, FileStream can be
            //     slower since each call triggers a system I/O operation.
            
            string fileDatPath = "example.dat";

            if (!File.Exists(fileDatPath))
            {
                File.Create(fileDatPath).Close();
            }
            
            // Writing bytes to a file
            using (FileStream fs = new FileStream(fileDatPath, FileMode.Create))
            {
                byte[] data = { 0x1, 0x2, 0x3, 0x4 };
                fs.Write(data, 0, data.Length);
            }
            
            // Reading bytes from a file
            using (FileStream fs = new FileStream(fileDatPath, FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);

                foreach (byte b in data)
                {
                    Console.Write($"{b:X} ");
                }
            }
            
            // How to write and read bytes array
            // and show text

            // Step 1: Write a byte array to a file
            // "Hello World" in ASCII
            byte[] dataToWrite = { 0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x20, 0x57, 0x6F, 0x72, 0x6C, 0x64 }; 

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(dataToWrite, 0, dataToWrite.Length);
                Console.WriteLine("Data written to file.");
            }

            // Step 2: Read the byte array back from the file
            byte[] dataRead;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                dataRead = new byte[fs.Length];
                fs.Read(dataRead, 0, dataRead.Length);
            }

            // Step 3: Display the data in hexadecimal format
            Console.WriteLine("Hexadecimal representation:");
            foreach (byte b in dataRead)
            {
                Console.Write($"{b:X2} ");
            }
            Console.WriteLine();

            // Step 4: Display the data as text
            string text = Encoding.ASCII.GetString(dataRead);
            Console.WriteLine("Text representation:");
            Console.WriteLine(text);
            
            // Step 5: Display encoding as UTF8
            string message = "Hello World";
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(message);

            // Print the byte array in hexadecimal format
            Console.WriteLine("UTF-8 Byte Array:");
            foreach (byte b in utf8Bytes)
            {
                Console.Write($"{b:X2} ");
            }

            #region ASCII vs UTF-8 Encoding
            // - ASCII
            //     Limited Characters: ASCII is a 7-bit encoding that supports only 128 characters, which include English letters (A-Z, a-z), numbers (0-9), and some basic symbols (like punctuation).
            //     Smaller Size: Since ASCII characters are just 7 bits (or 1 byte when stored), it’s very compact for simple text.
            //     Usage: ASCII is ideal if you're working only with plain English text without special characters.
            // - UTF-8
            //     Supports Many Languages: UTF-8 is a variable-length encoding that can represent every character in the Unicode standard. This includes characters from almost all languages, symbols, and even emojis.
            //     Backward Compatible with ASCII: UTF-8 uses 1 byte for ASCII characters, so any valid ASCII text is also valid UTF-8. But UTF-8 can also use up to 4 bytes to encode more complex characters.
            //     Usage: UTF-8 is a good choice when you need to support a range of languages, special symbols, or emojis, which are beyond ASCII’s limitations. UTF-8 is the standard encoding for most of the web.
            #endregion

            #endregion

            #region 9. Directory and Get and Delete Files in Directory

            string dirPath = "exampleDir";

            // Create directory
            Directory.CreateDirectory(dirPath);

            // List files in directory
            string[] files = Directory.GetFiles(dirPath);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            // Delete directory
            if (Directory.Exists(dirPath))
            {
                Directory.Delete(dirPath, recursive: true);
                Console.WriteLine("Directory deleted.");
            }

            #endregion

            #region 10. Buffered Stream Example

            // BufferedStream acts as a wrapper around a Stream (e.g., FileStream),
            // providing a buffer in memory for data read or write operations.
            // It is designed to improve performance by reducing the number of
            // times data is read from or written to the underlying stream.
            // Instead of reading or writing small chunks directly to the disk,
            // BufferedStream accumulates data in memory up to a specified buffer
            // size and then performs the operation in larger, more efficient chunks.
            
            //     - Reduced I/O Operations: BufferedStream only interacts with
            //       the underlying stream when the buffer is full (for writes)
            //       or needs to be refilled (for reads), reducing the frequency
            //       of disk I/O operations.
            //     - Best for Many Small Reads/Writes: If you are performing
            //       multiple small read/write operations, BufferedStream can
            //       significantly improve performance.
            //     - Configurable Buffer Size: The buffer size is configurable
            //       and should be set based on the workload and system capabilities.
            //       Larger buffers generally offer better performance up to a
            //       certain limit.
            
            string largeFilePath = "largeFile.txt";
            if (!File.Exists(largeFilePath))
            {
                File.Create(largeFilePath);
            }

            int bufferSize = 4096; // 4KB buffer

            using (FileStream fs = new FileStream(largeFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (BufferedStream bs = new BufferedStream(fs, bufferSize))
            using (StreamReader reader = new StreamReader(bs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line); // Process each line
                }
            }

            #endregion

            #region 11. Loading Slices of Large Files Efficiently

            string largeDataFilePath = "largeFile.dat";
            if (!File.Exists(largeDataFilePath))
            {
                File.Create(largeDataFilePath).Close();
            }

            Utils.String helper = new Utils.String(); // DLL
            
            int numberOfStrings = 1000000; // Number of random strings to generate
            int stringLength = 10; 
            string[] randomStrings = helper.RandomStrings(numberOfStrings, stringLength);

            // Example of using the generated strings, such as writing to a file or displaying
            File.WriteAllLines(largeDataFilePath, randomStrings);
            
            long offset = 0;        // Start position
            int sliceSize = 1024;   // 1 KB per slice

            using (FileStream fs = new FileStream(largeDataFilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] buffer = new byte[sliceSize];
                int bytesRead;

                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Helper.ProcessData(buffer, bytesRead);
                    offset += bytesRead;

                    if (offset >= fs.Length) // Stop if reached end of file
                        break;

                    fs.Seek(offset, SeekOrigin.Begin); // Move to next slice
                }
            }

            #endregion

            #region 12. Serialize and Deserialize file List<Person>
            
            Person person = new Person
            {
                Name = "Alice", Age = 30, Profile = 4
            };
            
            string fileName = "personLesson.json";

            // Serialize one Person to JSON
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(person, options);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine("Serialization to JSON complete.");

            // Deserialize one Person from JSON
            string readJsonString = File.ReadAllText(fileName);
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(readJsonString);
            Console.WriteLine(deserializedPerson.Name);
            
            string fileNamePersons = "personsLesson.json";

            List<Person> persons = new List<Person>
            {
                new Person { Name = "Alice", Age = 30, Profile = 4},
                new Person { Name = "Joana", Age = 30}
            };
            
            // Serialize the list of people to JSON
            string jsonPersonsString = JsonSerializer.Serialize(persons, options);
            File.WriteAllText(fileNamePersons, jsonPersonsString);
            Console.WriteLine("Serialization to JSON complete.");

            // Deserialize the list of people from JSON
            string readJsonStrings = File.ReadAllText(fileNamePersons);
            List<Person> deserializedPersons = JsonSerializer.Deserialize<List<Person>>(readJsonStrings);

            Console.WriteLine("Deserialization from JSON complete.");
            foreach (Person p in deserializedPersons)
            {
                Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
            }
            #endregion
            
            #endregion
        }
    }
}
      
   