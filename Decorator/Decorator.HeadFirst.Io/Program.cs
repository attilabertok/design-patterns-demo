using Bogus;

namespace Decorator.HeadFirst.Io
{
    public static class Program
    {
        public static void Main()
        {
            var faker = new Faker();
            using var memoryStream = new MemoryStream();
            using var stream = new LowerCaseInputStream(memoryStream);
            using var streamWriter = new StreamWriter(stream);
            for (var i = 0; i < 10; i++)
            {
                streamWriter.WriteLine(faker.Rant.Review());
            }

            streamWriter.Flush();
            stream.Seek(0, SeekOrigin.Begin);

            using var streamReader = new StreamReader(stream);
            var data = streamReader.ReadToEnd();
            Console.WriteLine(data);
        }
    }
}
