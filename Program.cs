 string file = "TicketData.txt";
string choice;
do
{
    
    Console.WriteLine("1) Read Ticket Information.");
    Console.WriteLine("2) Create New Ticket.");
    Console.WriteLine("Enter any other key to exit.");
    
    choice = Console.ReadLine();

    if (choice == "1")
    {
        if (File.Exists(file))
        {
                StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                
                string[] arr = line.Split('|');
                // display array data
                Console.WriteLine("Ticket ID:{0}, Summary: {1}, Status: {2}, Priority: {3}, Submitted by: {4}, Assigned to: {5}, Watched by: {6}", arr[0], arr[1],arr[2],arr[3],arr[4],arr[5],arr[6]);
            }

            sr.Close();
        }
    }
    else if (choice == "2")
    {
                            
        StreamWriter sw = new StreamWriter(file);
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Enter ticket (Y/N)?");
            string resp = Console.ReadLine().ToUpper();

            if (resp != "Y"){
                break;
            }
            int ticketnum = i + 1;
            
            Console.WriteLine("Enter a Ticket Summary");
            
            string summary = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter Ticket Status");
            
            string status = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter Ticket Priority");
            
            string priority = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Who Submitted Ticket?");
            
            string name = Console.ReadLine().ToUpper();
            
            Console.WriteLine("Who To Assign to Ticket?");
            
            string assign = Console.ReadLine().ToUpper();

            Console.WriteLine("Who is Watching Ticket?");
            
            string watch = Console.ReadLine().ToUpper();

            

            sw.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", ticketnum, summary, status, priority, name, assign, watch);
        }
        sw.Close();
    }
} while (choice == "1" || choice == "2");
            

