using _18AprelTAskClass;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Help.Students = new List<Student>();
        Help.Groups= new List<Group>();
        List<Group> grups=new List<Group>();
        Console.WriteLine("1.Group Menu");
        Console.WriteLine("2.Student Menu");
        Console.WriteLine("0.Exit");
        
       for(; ; )
        {
            string click=Console.ReadLine();
            if (click == "1")
            {
                Console.WriteLine("Grupun adin daxil edin");
                string groupname = Console.ReadLine();
                Group group = new Group(groupname);
                Help.Groups.Add(group);
            }
            if (click == "2")
            {
                    Console.WriteLine("ID ni daxil edin");
                    int iD = int.Parse(Console.ReadLine());
                    Group oldgroup = Help.Groups.Find(x => x.Id == iD);
                    Help.Groups.Remove(oldgroup);


            }
            if (click == "3")
            {
                    Console.WriteLine("YEnide ID gonder");
                    int ID = int.Parse((Console.ReadLine()));
                    Group searchgroup = Help.Groups.Find(x => x.Id == ID);
                    Console.WriteLine("name daxil et");
                    string Gropname = Console.ReadLine();
                    searchgroup.GroupName = Gropname;

            }
            if (click == "4")
            {
                foreach (Group group in Help.Groups)
                {
                    Console.WriteLine(group.GroupName);

                }
            }
            if(click == "5")
            {
                break;
            }
            
            
        }
    }
}