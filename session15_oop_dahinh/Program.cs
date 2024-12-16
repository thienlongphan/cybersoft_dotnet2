using session15_oop_dahinh;
using Newtonsoft.Json;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        // Animal dog = new Dog("Husky", "LuLu");
        // dog.Speak();
        // dog.DisplayInfo();
        //
        // Animal cat = new Cat("Mèo Mỹ lông ngắn", "White Black");
        // cat.Speak();
        // cat.DisplayInfo();
        
        // Dùng class Animal đại diện cho class con
        List<Animal> animals = new List<Animal>();
        
        // Tạo đối tượng Dog
        Dog dog1 = new Dog("Bulldog", "Hehe");
        
        // add dog1 vào list animal
        animals.Add(dog1);
        
        // tạo đối tượng cat
        Cat cat1 = new Cat("Meo", "White Yellow");
        
        // add cat1 vào list animal
        animals.Add(cat1);
        
        // in ra list animals
        // foreach (Animal animal in animals)
        // {
        //     animal.Speak();
        //     animal.DisplayInfo();
        //     Console.WriteLine("==============");
        // }
        
        // lưu list animal vào file json
        // lưu thêm type object vào file json
        // để khi load file lên, ta biết được object nào là Dog, Cat
        // dùng newtonSoft để lưu type object
        File.WriteAllText("animals.json", JsonConvert.SerializeObject(animals, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        }));
        Console.WriteLine("Save file animals.json sucessfully");
        
        // Đọc File Json
        string jsonRead = File.ReadAllText("animals.json");
        List<Animal>? animalList = JsonConvert.DeserializeObject<List<Animal>>(jsonRead, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
        });
        // lỗi vì khi load file lên thì các object list animalList 
        // không phải dog hay cat, mà là Animal
        
        
        // Solution
        // để fix lỗi này, ta cần lưu type của object vào file json
        // để khi load file lên, ta biết được object nào là Dog, class nào Cat
        // Thư viện Newtonsoft.Json sẽ giúp mình làm việc này
        
        foreach (Animal animal in animalList)
        {
            animal.Speak();
            animal.DisplayInfo();
            Console.WriteLine("==============");
        }
    }
}
