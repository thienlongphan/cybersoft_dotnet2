internal class Program
{
    public static void Main(string[] args)
    {
        
        // Setting để hiển thị những ký tự đặc biệt trên console
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // ẩn con trỏ chuột
        Console.CursorVisible = false;
        
        // vẽ cây thông
        string[] tree = { // ma trận 2 chiều để vẽ cây thông
            "         *         ",
            "        *        ",
            "       ***       ",
            "      *****      ",
            "     *******     ",
            "    *********    ",
            "   ***********   ",
            "  *************  ",
            " *************** ",
            "        |||        ",
            "        |||        "
        };

        while (true)
        {
            Console.Clear();
            
            // lấy chieu dai và chieu rộng của console
                    // để vẽ cây thông và tuyết rơi
                    int width = Console.WindowWidth;
                    int height = Console.WindowHeight;
                    
                    
                    // define biến random để tạo hieu ung ngau nhien
                    Random rnd = new Random();
                    
                    // tạo hiệu ứng tuyết rơi
                    char[] snowFlakes = { '.', '*', '+', '0' };
                    
                    // vẽ cây thông
                    for (int i = 0; i < tree.Length; i++)
                    {
                        Console.SetCursorPosition((width  - tree[i].Length)/2, (height - tree.Length)/2 + i);
                        foreach (var ch in tree[i]) // for này dùng để vẽ từng ký tự
                        {
                            if (ch == '*')
                            {
                                // vẽ màu ngẫu nhiên cho cây thông
                                Console.ForegroundColor = (ConsoleColor)rnd.Next(8, 16);
                                
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            Console.Write(ch);
                        }
                    }
                    
                    // ve tuyet roi 
                    // tao so luong tuyet roi
                    int snowCount = 100;
            
                    for (int i = 0; i < snowCount; i++)
                    {
                        // setup vị trí vẽ tuyết rơi 
                        // sẽ dùng random để vẽ tuyết trên console
                        int snowX = rnd.Next(0, width);
                        int snowY = rnd.Next(0, height / 2);
                        
                        
                        // Set vị trí tuyết rơi
                        Console.SetCursorPosition(snowX, snowY);
                        // set màu cho tuyết 
                        Console.ForegroundColor = ConsoleColor.White;
                        // vẽ tuyết rơi 
                        Console.Write(snowFlakes[rnd.Next(snowFlakes.Length)]);
                    }
                    Thread.Sleep(150);
        }
        
    }
}
