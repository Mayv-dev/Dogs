using Dogs.Types;

namespace Dogs.Adapters;

interface IFileAdapter
{
    void WriteToFile(DogFileContent content);
    DogFileContent ReadFromFile();
}