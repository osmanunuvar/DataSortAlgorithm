namespace Core
{
    public class Sorter
    {
        public void Sort(string inputPath, string outputPath)
        {
            //  Code here 
            var lineList = File.ReadLines(inputPath);
            List<ulong> numberList = new List<ulong>();
            foreach (var item in lineList)
            {
                numberList.Add(Convert.ToUInt64(item));
            }
            ulong temp;
            for (int j = 0; j <= numberList.Count - 2; j++)
            {
                for (int i = 0; i <= numberList.Count - 2; i++)
                {
                    if (numberList[i] > numberList[i + 1])
                    {
                        temp = numberList[i + 1];
                        numberList[i + 1] = numberList[i];
                        numberList[i] = temp;
                    }
                }
            }
            var sortedList = new List<string>();
            numberList.ForEach(x => sortedList.Add(x.ToString()));
            File.WriteAllLines(outputPath, sortedList);
            Console.WriteLine("sorted numbers moved to sorted_file");
        }
    }
}