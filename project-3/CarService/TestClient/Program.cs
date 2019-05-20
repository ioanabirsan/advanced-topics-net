using System;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CarServiceClient client = new CarServiceClient();

            // Use the 'client' variable to call operations on the service.

            // Always close the client.
            Console.WriteLine("Client in execution...");
            client.Close();
        }
    }
}
