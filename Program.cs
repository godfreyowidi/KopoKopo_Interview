
namespace Interview_Code_Test
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] csvRows = File.ReadAllLines(@"C:\Users\Admin\Desktop\interview_code_test\test_data\transaction_data_1.csv");

      var customerId = new List<string>();

      for (int i = 1; i < csvRows.Length; i++)
      {
        string[] csvData = csvRows[i].Split(',');
        customerId.Add(csvData[0]);
        
        // Check for duplicates 
        for(int j = i + 1; j < csvData.Length; j++)
        {
          if (csvData[i] == csvData[j])
          {
            if(csvRows.Contains(customerId[j]))
            {
              break;
            }
            else
            {
              Console.WriteLine("Customer IDs");
              for (int k =0; k < customerId.Count; k++)
              {
                customerId.Sort();
                customerId.Reverse();
                Console.WriteLine(customerId[i]);
              }
            }
          }
        }
      }
      Console.ReadKey();
    }
  }
}

