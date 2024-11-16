namespace session_optional;

public class TuDienAnhViet
{
    public static void Process()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        // 1. Thêm từ
        // 2. Tra từ (tìm kiếm từ)
        // 3. Xóa từ
        // 4. Thoát
        while (true)
        {
            // Dừng đến khi user nhập vào option 4: Thoát thì dừng chương trình
            Console.WriteLine("1. Add word: ");
            Console.WriteLine("2. Search word: ");
            Console.WriteLine("3. Delete word: ");
            Console.WriteLine("4. Search English Word base on Vietnamese word: ");
            Console.WriteLine("5. Exit: ");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter your english word: ");
                string englishWord = Console.ReadLine();
                Console.WriteLine("Enter your Vietnamese word: ");
                string vietnameseWord = Console.ReadLine();
                // add Eng-Viet to dictionary
                // c1:
                //dictionary[englishWord] = vietnameseWord;
                // c2: 
                dictionary.Add(englishWord, vietnameseWord);
                Console.WriteLine("Added successfully");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter your english word need to search: ");
                string englishWord = Console.ReadLine();
                // containsKey để tìm cặp key-value
                if (dictionary.ContainsKey(englishWord))
                {
                    Console.WriteLine($"Meaning of word {englishWord} was {dictionary[englishWord]}");
                }
                else
                {
                    Console.WriteLine($"Meaning of word {englishWord} was not found");
                }
                Console.WriteLine("---------------------------------------------------");
            }
            else if (choice == 3)
            {
                // Remove để xóa từ trong từ điển
                Console.WriteLine("Enter your english word need to delete: ");
                string englishWord = Console.ReadLine();
                if (dictionary.Remove(englishWord))
                {
                    Console.WriteLine($"Meaning of word {englishWord} was removed");
                }
                else
                {
                    Console.WriteLine("The word you entered was not found");
                }
                Console.WriteLine("---------------------------------------------------");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter your vietnamese word need to search: ");
                string vietnameseWord = Console.ReadLine();
                // Duyet tung key-value trong dictionary so sanh voi value nhap tu ban phim
                string englishOutput = null;
                foreach (KeyValuePair<string, string> item in dictionary)
                {
                    if (item.Value.Equals(vietnameseWord))
                    {
                        englishOutput = item.Key;
                        break;
                    }
                }

                if (englishOutput != null)
                {
                    Console.WriteLine("English word is: {0}", englishOutput);
                }
                else
                {
                    Console.WriteLine("English word was not found");
                }
                Console.WriteLine("-----------------------------------------------");
            }
            else
            {
                break;
            }
        }
    }
}