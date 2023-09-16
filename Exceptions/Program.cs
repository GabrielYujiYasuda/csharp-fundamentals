namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            string s = "";

            try {
                // for (int i = 0; i < 10; i++){
                //     Console.WriteLine(arr[i]);
                // }

                Save(s);
            } 
            catch (IndexOutOfRangeException e) {
                Console.WriteLine(e.InnerExcept+ion);
                Console.WriteLine(e.Message);
                Console.WriteLine($"Ops, Something is wrong!");
            } 
            catch(ArgumentNullException e) {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine($"Fail to save the text!!!");
            }
            catch(Implement e) {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                System.Console.WriteLine(e.WhenHappened);
                Console.WriteLine($"Custom EXCEPTION");
            }
            catch (Exception e) {
                Console.WriteLine(e.InnerException);
                //Console.WriteLine(e.Message);
                Console.WriteLine($"ESTOUROU O ARRAY!!!");
            }
            finally {
                System.Console.WriteLine("THE END");
            }
        }

        static void Save(string text) {
            if (string.IsNullOrEmpty(text)) {
                throw new Implement(DateTime.Now);
            }
        }
    }
}