using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PersonalAgenda
{
    public class BinarySerialization
    {
        public static void Serialize(string path, PersonalAgenda personalAgenda)
        {
            var fileStream = new FileStream(path, FileMode.Create);

            var formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fileStream, personalAgenda);
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                fileStream.Close();
            }
        }

        public static PersonalAgenda Deserialize(string path)
        {
            var fileStream = new FileStream(path, FileMode.Open);
            try
            {
                var formatter = new BinaryFormatter();
                var personalAgenda = (PersonalAgenda) formatter.Deserialize(fileStream);

                return personalAgenda;
            }
            catch (SerializationException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                fileStream.Close();
            }
        }

        public static void DeleteContent(string path)
        {
            var fileStream = File.Open(path, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close(); 
        }
    }
}