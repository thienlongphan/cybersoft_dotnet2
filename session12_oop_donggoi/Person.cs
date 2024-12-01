namespace session12_oop_donggoi;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        // Gán giá trị cho thuộc tính thông qua setter (quan trọng)
        Name = name;
        Age = age;
    }
    
    // Dùng property để truy cập vào từng thuộc tính
    public string Name
    {
        get => name;
        // thêm các logic kiểm tra giá trị trước khi 
        // gán cho thuộc tính
        // check tên không được rong
        // hoặc check tên có độ dài 3 ký tự
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value < 0 || value > 150)
            {
                throw new ArgumentException("Age must be between 0 and 150");
            }
            age = value;
        }
    }
}