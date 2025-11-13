namespace DeCodify
{
    public class Runner
    {
        public void Run()
        {
            try
            {
                string input = Console.ReadLine();
                var output = new Decompression().DecodeString(input);

                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
